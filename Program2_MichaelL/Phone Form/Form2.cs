using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Form
{
    public partial class Form2 : Form
    {
        //Variables
        private string phone;
        private string serial;
        private string model;

        //Get/Set
        public string Phone { get { return phone; } set { phone = value; } }
        public string Serial { get { return serial; } set { serial = value; } }
        public string Model { get { return model; } set { model = value; } }

        public Form2()
        {
            InitializeComponent();
        }

        // stores values into string variables and sends default info if empty.
        private void Button_createPhone_Click(object sender, EventArgs e)
        {
            if(textBox_serialNum.Text == "")
                textBox_serialNum.Text = "111111111111";
            if (textBox_phoneNum.Text == "")
                textBox_phoneNum.Text = "1234567890";
            if (textBox_model.Text == "")
                textBox_model.Text = "Generic Model";
            phone = textBox_phoneNum.Text;
            serial = textBox_serialNum.Text;
            model = textBox_model.Text;
        }
    }
}
