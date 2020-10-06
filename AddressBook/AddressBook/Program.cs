using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome To Address Book Program on Master Branch ");
            Console.WriteLine("\n");
            AddressBookSystem addressbook = new AddressBookSystem();
            Contact contact = new Contact();
            Console.WriteLine("How many contacts you want to add ?");
            int option = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= option; i++)
            {
                SetDetails(contact);
                addressbook.AddContact(contact);
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

