namespace Form_Demo_Program6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Hit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Miss = new System.Windows.Forms.TextBox();
            this.button_StartGame = new System.Windows.Forms.Button();
            this.checkBox_Difficult = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // textBox_Hit
            // 
            this.textBox_Hit.Location = new System.Drawing.Point(138, 23);
            this.textBox_Hit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Hit.Name = "textBox_Hit";
            this.textBox_Hit.ReadOnly = true;
            this.textBox_Hit.Size = new System.Drawing.Size(162, 31);
            this.textBox_Hit.TabIndex = 1;
            this.textBox_Hit.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Points:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miss:";
            // 
            // textBox_Miss
            // 
            this.textBox_Miss.Location = new System.Drawing.Point(138, 62);
            this.textBox_Miss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Miss.Name = "textBox_Miss";
            this.textBox_Miss.ReadOnly = true;
            this.textBox_Miss.Size = new System.Drawing.Size(162, 31);
            this.textBox_Miss.TabIndex = 3;
            this.textBox_Miss.Text = "0";
            // 
            // button_StartGame
            // 
            this.button_StartGame.Location = new System.Drawing.Point(435, 28);
            this.button_StartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_StartGame.Name = "button_StartGame";
            this.button_StartGame.Size = new System.Drawing.Size(280, 65);
            this.button_StartGame.TabIndex = 5;
            this.button_StartGame.Text = "Start Game";
            this.button_StartGame.UseVisualStyleBackColor = true;
            this.button_StartGame.Click += new System.EventHandler(this.Button_StartGame_Click);
            // 
            // checkBox_Difficult
            // 
            this.checkBox_Difficult.AutoSize = true;
            this.checkBox_Difficult.Location = new System.Drawing.Point(737, 46);
            this.checkBox_Difficult.Name = "checkBox_Difficult";
            this.checkBox_Difficult.Size = new System.Drawing.Size(230, 29);
            this.checkBox_Difficult.TabIndex = 6;
            this.checkBox_Difficult.Text = "Difficult (x3 Points!)";
            this.checkBox_Difficult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_StartGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 881);
            this.Controls.Add(this.checkBox_Difficult);
            this.Controls.Add(this.button_StartGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Miss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Hit);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Whack-A-Mole!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Hit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Miss;
        private System.Windows.Forms.Button button_StartGame;
        private System.Windows.Forms.CheckBox checkBox_Difficult;
    }
}

