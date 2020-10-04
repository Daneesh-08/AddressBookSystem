using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome To Address Book Program on Master Branch ");
            Console.WriteLine("\n");
            Console.WriteLine("Add the Contact Details ");
            Console.WriteLine("\n");
            AddressBookSystem addressbook = new AddressBookSystem();           
            Contact contact = new Contact();
            SetDetails(contact);
            addressbook.AddContact(contact); 
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

