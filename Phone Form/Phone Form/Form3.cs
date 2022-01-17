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
    public partial class Form3 : Form
    {
        private string cname;
        private string cnum;
        public string cName
        {
            get { return cname; }
            set { cname = value; }
        }
        public string cNum
        {
            get { return cnum; }
            set { cnum = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        // Stores information in string variables for later collecting.
        private void Button_createContact_Click(object sender, EventArgs e)
        {
            cName = textBox_Name.Text;
            cNum = textBox_PhoneNumber.Text;
        }
    }
}
