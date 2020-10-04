using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookSystem
    {
        public List<Contact> ContactList;
        public AddressBookSystem()
        {
            this.ContactList = new List<Contact>();
        }
        public void AddContact(Contact obj)
        {
            this.ContactList.Add(obj);
        }
        public void EditContact(string firstname, string lastname)
        {
            Contact contactedit = null;
            foreach (Contact contact in this.ContactList)
            {
                if (contact.FirstName == firstname && contact.LastName == lastname)
                    contactedit = contact;
            }
            if (contactedit == null)
            {
                Console.WriteLine("Contact does not exist !!");
                return;
            }
            this.Edit(contactedit);
        }
        public void Edit(Contact contactedit)
        {
            Console.WriteLine("Enter the Choice you want to Edit : ");
            while (true)
            {
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Address");
                Console.WriteLine("4. City");
                Console.WriteLine("5. State");
                Console.WriteLine("6. Zip Code");
                Console.WriteLine("7. Phone Number");
                Console.WriteLine("8. Email Id");
                Console.WriteLine("9. Exit");
                Console.WriteLine("\n");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        Console.WriteLine("Enter new First Name");
                        string Fname = Console.ReadLine();
                        contactedit.FirstName = Fname;
                        break;
                    case 2:
                        Console.WriteLine("Enter new Last Name");
                        string Lname = Console.ReadLine();
                        contactedit.LastName = Lname;
                        break;
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        contactedit.Address = address;
                        break;
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        contactedit.City = city;
                        break;
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        contactedit.State = state;
                        break;
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        contactedit.Zip = zip;
                        break;
                    case 7:
                        Console.WriteLine("Enter new PhoneNumber");
                        long Pnumber = long.Parse(Console.ReadLine());
                        contactedit.PhoneNumber = Pnumber;
                        break;
                    case 8:
                        Console.WriteLine("Enter new Email Id");
                        string email = Console.ReadLine();
                        contactedit.Email = email;
                        break;
                    case 9:
                        Console.WriteLine("\n");
                        Console.WriteLine("Contact Details after Editing :");
                        Console.WriteLine("\n");
                        this.Afterediting(contactedit);
                        return;
                }
            }
        }
        public void Afterediting(Contact contact)
        {
            Console.WriteLine("First Name : " + contact.FirstName);
            Console.WriteLine("Last Name : " + contact.LastName);
            Console.WriteLine("Address : " + contact.Address);
            Console.WriteLine("City : " + contact.City);
            Console.WriteLine("State : " + contact.State);
            Console.WriteLine("Zip : " + contact.Zip);
            Console.WriteLine("PhoneNumber : " + contact.PhoneNumber);
            Console.WriteLine("Email id : " + contact.Email);
        }
    }
}
