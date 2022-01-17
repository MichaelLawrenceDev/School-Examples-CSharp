using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellPhone;

/*********************************************************************************************************************
 * Name: Michael Lawrence
 * Class: CSC 331 - 002
 * Date: 9/27/2019
 * File Name: Phone Form
 * Description: Utilizing the MyMobile class, which inherits from Mobile, Form1 displays the information stored by
 *              an object of the MyMobile class. This information includes a contact list, serial number, phone
 *              number and model of the MyMobile object. It also creates a front end for the user to enter and remove
 *              contact information, dial phone numbers and set the sim number of the phone. This also utilizes Form2
 *              and Form3 as user inputs during phone creation and entering contact information.
 * 
*********************************************************************************************************************/

namespace Phone_Form
{
    public partial class Form1 : Form
    {
        MyMobile mm;
        Contact[] cArray;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if(f2.ShowDialog() == DialogResult.OK)
            {
                mm = new MyMobile(f2.Model, f2.Serial, f2.Phone);
            }
            else
            {
                mm = new MyMobile();
            }
            f2.Close();
            textBox_model.Text = mm.getModel();
            textBox_phoneNum.Text = mm.getphoneNumber();
            textBox_serialNum.Text = mm.getSerial();
            mm.viewINFO();
            button_removeContact.Enabled = false;
        }
        private void ComboBox_ContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ContactList.SelectedIndex != -1)
            {
                textBox_contactName.Text = cArray[comboBox_ContactList.SelectedIndex].name;
                textBox_contactNumber.Text = cArray[comboBox_ContactList.SelectedIndex].number;
                button_removeContact.Enabled = true;
            }
            else
            {
                button_removeContact.Enabled = false;
            }
        }

        private void comboUpdate()
        {
            comboBox_ContactList.Items.Clear();
            cArray = mm.getContactList();
            for (int i = 0; i < mm.getContactListSize(); i++)
            {
                comboBox_ContactList.Items.Add(cArray[i].name);
            }
            textBox_contactName.Text = "";
            textBox_contactNumber.Text = "";
            comboBox_ContactList.Text = "";
            mm.viewINFO();
        }

        //Add contact
        private void Button_addContact_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            if(f3.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mm.addContact(f3.cNum, f3.cName);
                    comboUpdate();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Contact Phone Number");
                    MessageBox.Show("Invalid phone number, must contain 10 digits.");
                }
            }
            f3.Close();
        }
        
        //Remove contact
        private void Button_removeContact_Click(object sender, EventArgs e)
        {
            mm.removeContact(cArray[comboBox_ContactList.SelectedIndex]);
            comboUpdate();
        }

        private void Button_DialPhone_Click(object sender, EventArgs e)
        {
            try 
            {
                mm.callPerson(mm.checkFormat(textBox_contactNumber.Text));
                MessageBox.Show("called via Console.");
            }
            catch
            {
                MessageBox.Show("Phone number Invalid, requires 10 digits.");
            }
        }

        private void Button_removeSim_Click(object sender, EventArgs e)
        {
            mm.removeSim();
            textBox_simCard.Text = "";
            button_removeSim.Enabled = false;
            button_addSimCard.Enabled = true;
            textBox_simCard.ReadOnly = false;
        }

        private void Button_addSimCard_Click(object sender, EventArgs e)
        {
            mm.addSim(textBox_simCard.Text);
            textBox_simCard.ReadOnly = true;
            button_removeSim.Enabled = true;
            button_addSimCard.Enabled = false;
        }

        // add contact
        // remove a contact
        // view contact list
        // view phone information
        // Add sim card
        // remove sim card
        // dial phone number
        // Call phone number (based on contact name)

    }
}
