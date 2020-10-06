using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome To Address Book Program on Master Branch ");
            Console.WriteLine("\n");
            Dictionary<string, AddressBookSystem> dictionary = new Dictionary<string, AddressBookSystem>();
            Contact contact = new Contact();
            AddressBookSystem addressbook = new AddressBookSystem();
            Console.WriteLine("How many Address Book you want to Add ?");
            int numaddressbook = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int count = 1; count <= numaddressbook; count++)
            {
                Console.WriteLine("Address Book " + count + ": ");
                string nameaddressbook = Console.ReadLine();
                dictionary.Add(nameaddressbook, addressbook);
                Console.WriteLine("\n");
            }
            Console.WriteLine("Enter the Address Book where you want to Add Contacts");
            string addcontact = Console.ReadLine();
            Console.WriteLine("How many contacts you want to Add ?");
            int numcontact = Convert.ToInt32(Console.ReadLine());
            for (int count = 1; count <= numcontact; count++)
            {
                AddressBookSystem AddressBook = dictionary[addcontact];
                SetDetails(contact);
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the First Name of Contact you want to edit :");
            string Firstnameedit = Console.ReadLine();
            Console.WriteLine("Enter Last Name of Contact you want to edit :");
            string Lastnameedit = Console.ReadLine();
            Console.WriteLine("\n");
            addressbook.EditContact(Firstnameedit, Lastnameedit);
            Console.WriteLine("\n");
            Console.WriteLine("Enter the First Name of Contact you want to delete :");
            string Firstnamedelete = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of Contact you want to delete :");
            string Lastnamedelete = Console.ReadLine();
            Console.WriteLine("\n");
            addressbook.DeleteContact(Firstnamedelete, Lastnamedelete);
        }
        public static void SetDetails(Contact contact)
        {
            Console.WriteLine("First Name : ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name :");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Address :");
            contact.Address = Console.ReadLine();
            Console.WriteLine("City :");
            contact.City = Console.ReadLine();
            Console.WriteLine("State :");
            contact.State = Console.ReadLine();
            Console.WriteLine("Zip Code :");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phone Number :");
            contact.PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Email Address :");
            contact.Email = Console.ReadLine();
        }
    }
    
}

