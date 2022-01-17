using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Michael Lawrence
// CSC 331 - 001
// 11-18-2019 

namespace Form_Demo_Program6
{
    public partial class Form1 : Form
    {
        // To add picture: Properties -> Resources -> Add Resources from File
        static readonly object obj = new object();
        Button[,] gameButtons = new Button[5, 5];
        int hit = 0;
        int miss = 0;
        Bitmap image = new Bitmap((System.Drawing.Image)Properties.Resources.penguin, new Size(80,80));

        int gameID = 0;
        public int getGameID() { return gameID; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButtons();
        }

        private void clickbutton_evt(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if (temp.Image != null)
            {
                temp.Image = null;
                Hit();
            }
            else
            {
                Miss();
            }
            //temp.Image = null;
            this.Update();
        }

        private int[] AddImage()
        {
            lock (obj)
            {
                Random ran = new Random();
                int i = ran.Next(0, 5);
                int j = ran.Next(0, 5);
                while (gameButtons[i, j].Image != null)
                {
                    i = ran.Next(0, 5);
                    j = ran.Next(0, 5);
                }
                gameButtons[i, j].Image = image;
                int[] location = { i, j };
                return location;
            }
        }
        private void ClearImage(int[] location)
        {
            if (gameButtons[location[0], location[1]].Image != null)
            {
                gameButtons[location[0], location[1]].Image = null;
                Miss();
            }
        }

        private void CreateButtons()
        {
            // Game Button Dimensions
            int horizontal = 100;
            int vertical = 100;
            // Game Button Positions
            int hpos = 0;
            int vpos = 65;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Button tempButton = new Button();

                    tempButton.Location = new Point(hpos, vpos);    
                    tempButton.Width = horizontal;  // Width of button
                    tempButton.Height = vertical;   // Height of button
                    tempButton.BackgroundImageLayout = ImageLayout.Center; // Center image on button

                    tempButton.Click += clickbutton_evt;    // Button call to method
                    this.gameButtons[i, j] = tempButton;
                    this.Controls.Add(this.gameButtons[i, j]);
                    hpos += horizontal;
                }
                vpos += vertical;
                hpos = 0;
            }
        }

        private void Button_StartGame_Click(object sender, EventArgs e)
        {
            // Reset Score
            int gameNum = gameID;
            miss = 0;
            hit = 0;
            textBox_Miss.Text = miss.ToString();
            textBox_Hit.Text = hit.ToString();

            button_StartGame.Enabled = false;
            checkBox_Difficult.Enabled = false;
            Random ran = new Random();
            Task game = new Task(() =>
            {
                int numOfMoles = 5;
                if(checkBox_Difficult.Checked == true)
                {
                    numOfMoles = 15;
                }
                for (int i = 0; i <numOfMoles; i++)
                {
                    if (gameNum == gameID)
                    {
                        Task mole = new Task(() => Mole(gameNum));
                        mole.Start();
                        Thread.Sleep(ran.Next(10, 14) * 1000);
                    }
                    else
                    {
                        break;
                    }
                }
            });
            game.Start();
        }
        private void Mole(int gameNum)
        {
            int gameID = getGameID();
            while (gameID == gameNum)
            {
                int[] location = AddImage();
                Thread.Sleep(3000);
                ClearImage(location);
                gameID = getGameID();
            }
        }

        private void Miss()
        {
            miss++;
            textBox_Miss.Invoke((MethodInvoker)(() => textBox_Miss.Text = miss.ToString()));
            if(miss >= 10)
            {
                for(int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        gameButtons[i, j].Image = null;
                    }
                }
                gameID++;
                miss = 0;
                MessageBox.Show("Game finished, Number of Points: " + hit);
                button_StartGame.Invoke((MethodInvoker)(() => button_StartGame.Enabled = true));
                checkBox_Difficult.Invoke((MethodInvoker)(() => checkBox_Difficult.Enabled = true));
            }
        }
        private void Hit()
        {
            if(checkBox_Difficult.Checked == true) 
            { 
                hit += 300; 
            }
            else
            {
                hit += 100;
            }
            textBox_Hit.Invoke((MethodInvoker)(() => textBox_Hit.Text = hit.ToString()));
        }
    }
}
