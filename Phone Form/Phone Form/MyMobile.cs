using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellPhone;

namespace Phone_Form
{
    class MyMobile : Mobile
    {
        // Contructor, but uses Mobile for information.
        public MyMobile(string model = "Generic Model", string serialnumber = "111111111111", string phoneNumber = "1234567890") :
                         base(model, serialnumber, phoneNumber)
        { }
        // redirects to other addContact method
        public void addContact(Contact c)
        {
            this.addContact(c.number, c.name);
        }
        // addContact accepts Contact information (number, name), and calls the checkFormat method. 
        // It also calls the sortContactList method.
        public void addContact(string num, string name) 
        {
            try
            {
                num = checkFormat(num);
                base.addContact(num, name);
                sortContactList();
            }
            catch (Exception e)
            {
                throw new MobilePhoneExceptionMessage(e.ToString());
            }
            
        }
        //This method will check phone number digits and reformat if able.
        public String checkFormat(String num)
        {
            StringBuilder formated = new StringBuilder();
            int result;
            // remove non-digit numbers
            for (int i = 0; i < num.Length; i++)
            {
                if (formated.Length == 3 || formated.Length == 7)
                {
                    formated.Append('-');
                }
                if (int.TryParse(num.ElementAt(i).ToString(), out result))
                {
                    formated.Append(num.ElementAt(i));
                }
            }
            // check length = 12 digits
            if (formated.Length != 12)
            {
                throw new MobilePhoneExceptionMessage("Invalid Phone Number, Requires 10 digits in any format.");
            }
            return formated.ToString();
        }

        //This method will sort contact list in alphabetical order everytime the addContact method is called.
        private void sortContactList()
        {
            Contact[] cArray = new Contact[contactSize];
            for(int i = 0; i < contactSize; i++)
            {
                cArray[i] = this.contactList[i];
            }
            IEnumerable<Contact> query = cArray.OrderBy(Contact => Contact.name);
            cArray = query.Cast<Contact>().ToArray();
            for (int i = 0; i < contactSize; i++)
            {
                this.contactList[i] = cArray[i];
            }
        }
        //Get method for contactListSize
        public int getContactListSize()
        {
            return this.contactSize;
        }
        //Get method for contactList itself
        public Contact[] getContactList()
        {
            return this.contactList;
        }
        //Console method which allows the viewing of the object's information including contact list.
        public void viewINFO()
        {
            Console.WriteLine("\nContact List:");
            for(int i = 0; i < this.contactSize; i++)
            {
                Console.WriteLine("    Contact {0}: {1}, {2}", i + 1, this.contactList[i].name, this.contactList[i].number);
            }
            Console.WriteLine("Model: {0}\nPhone Num: {1}\nSerial Num: {2}\nSim Num: {3}\n",
                              this.getModel(), this.getphoneNumber(), this.getSerial(), this.getSimInfo());
        }
    }
}
