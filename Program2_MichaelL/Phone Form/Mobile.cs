using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhone
{
    class MobilePhoneExceptionMessage : Exception
    {
        private string message;
        public string MESSAGE { get { return this.message; } set { this.message = value; } }

        public MobilePhoneExceptionMessage(string message)
        {
            this.message = message;
        }

        public new string ToString()
        {
            return this.message;
        }
    }

    struct Contact
    {
        public string number;
        public string name;
    }
        

    //Class for the phone device
    class Mobile
    {
         //Constuctor
        public Mobile(string model = "Generic Model", string serialnumber = "111111111111", string phoneNumber = "1234567890")
        {
            this.model = model;
            this.serialnumber = serialnumber;
            this.phoneNumber = phoneNumber;
            this.hasSim = false;
            this.contactSize = 0;
            this.simNum = "";
            this.contactList = new Contact[CONTACT_CAPACITY];
            for (int i = 0; i < CONTACT_CAPACITY; i++)
                this.contactList[i] = new Contact();
            Console.WriteLine("New phone initialized.\n");
        }
        
        //Add contact to list
        public void addContact(Contact c)
        {
            //If the contact list is full, throw an exception;
            if (this.contactSize >= CONTACT_CAPACITY)
                throw new MobilePhoneExceptionMessage("Cannot add another contact.  List is full.");
            else
            {
                //Check if number is valid format. if not throw exception.
                int valid = this.checkNum(c.number);
                if (valid == -1)
                    throw new MobilePhoneExceptionMessage("Number is in incorrect format.  Please enter it in XXX-XXX-XXXX format.");
                else
                {
                    this.contactList[this.contactSize] = c;
                    this.contactSize++;
                }
            }
        }
        public void addContact(string num, string name)
        {
            Contact temp;
            temp.name = name;
            temp.number = num;
            this.addContact(temp);
        }
        //Add a sim card
        public void addSim(string sim)
        {
            this.simNum = sim;
            this.hasSim = false;
        }
        //Remove a sim card
        public void removeSim()
        {
            this.simNum = "";
            this.hasSim = false;
        }
        //Get simcard info
        public string getSimInfo()
        {
            return this.simNum;
        }
        //Print the contacts list
        public void printContacts()
        {
            for (int i = 0; i < this.contactSize; i++)
            {
                Console.WriteLine("Contact {0}: {1}, {2}", i, this.contactList[i].name, this.contactList[i].number);
            }
        }
        //Call a particular person
        public void callPerson(string num)
        {
            //check that number entered is valid or throw exception
            int valid = this.checkNum(num);
            if (valid == -1)
                throw new MobilePhoneExceptionMessage("Cannot dial number.  Not in valid format.  Please enter number in XXX-XXX-XXXX format.");
            else
            {
                bool isInList = false;
                int person = 0;

                //Look through the contacts list for the number.  If number is found, retrieve user name.
                for (int i = 0; i < this.contactSize; i++)
                {
                    if (this.contactList[i].number == num)
                    {
                        isInList = true;
                        person = i;
                        break;
                    }
                }
                //If user exists in contact list, calls the person by name.
                if (isInList)
                {
                    Console.WriteLine("Calling: {0}",this.contactList[person].name);
                }
                //If not in the list, just call the number
                else
                {
                    Console.WriteLine("Calling: {0}", num);
                }
            }
        }
        public void callPerson(Contact c)
        {
            this.callPerson(c.name);
        }
        //Getters for info
        public string getModel()
        {
            return this.model;
        }
        public string getSerial()
        {
            return this.serialnumber;
        }
        public string getphoneNumber()
        {
            return this.phoneNumber;
        }
        //Remove a contact from list
        public void removeContact(string name)
        {
            bool found = false;
            //Look through entire list
            for (int i = 0; i < this.contactSize; i++)
            {
                if (this.contactList[i].name == name)
                {
                    found = true;
                }
                if (found)
                {
                    if (i < this.contactSize - 1)
                    {
                        this.contactList[i] = this.contactList[i + 1];
                    }
                }
            }
            if (found)
                this.contactSize--;
            else
                throw new MobilePhoneExceptionMessage("Cannot remove contact from list, non existent.");
        }
        public void removeContact(Contact c)
        {
            this.removeContact(c.name);
        }
        //returns all of the phone's information as a string
        public new string ToString()
        {
            return "Model: " + this.model + "\nSerial Number: " + this.serialnumber + "\nPhone's number: " + this.phoneNumber + "\nSim: " + this.simNum;
        }
        //Method to check the number is in a valid format
        int checkNum(string num)
        {
            if (num.Length < 12)
                return -1;

            bool valid = true;
            for (byte i = 0; i < num.Length; i++)
            {
                switch (i)
                {
                    //Check if the number in the digits spots are between 0 and 9
                    case 0:
                    case 1:
                    case 2:
                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        if (num[i] < 48 || num[i] > 57)
                            valid = false;
                        break;
                    //Check if the other characters are -
                    case 3:
                    case 7:
                        if (num[i] != '-')
                            valid = false;
                        break;
                    default:
                        break;

                }
                if (valid == false)
                    return -1;
            }
            return 0;
        }
        
        //Strings for phone informaiton
        private string model, serialnumber, simNum, phoneNumber;
        private bool hasSim;
        //array for the contact list
        protected Contact []contactList;
        //Number of contacts
        protected int contactSize;
        //max size of contact list
        private const int CONTACT_CAPACITY = 255;
    
    }
}
