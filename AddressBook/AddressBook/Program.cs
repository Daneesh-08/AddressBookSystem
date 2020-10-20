using System;
using System.Collections.Generic;
using System.Globalization;

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
            Console.WriteLine("How many Address Books you want to Add ?");
            int numaddressbook = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int count = 1; count <= numaddressbook; count++)
            {
                Console.WriteLine("Address Book Name " + count + ": ");
                string nameaddressbook = Console.ReadLine();
                AddressBookSystem addressbook = new AddressBookSystem();
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
                SetDetails(AddressBook);
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter Address Book name where you want to edit contact");
            string editcontact = Console.ReadLine();
            Console.WriteLine("Enter the First Name of Contact you want to edit :");
            string Firstnameedit = Console.ReadLine();
            Console.WriteLine("Enter Last Name of Contact you want to edit :");
            string Lastnameedit = Console.ReadLine();
            Console.WriteLine("\n");
            dictionary[editcontact].EditContact(Firstnameedit, Lastnameedit);
            Console.WriteLine("\n");
            Console.WriteLine("Enter Address Book name where you want to delete contact");
            string deletecontact = Console.ReadLine();
            Console.WriteLine("Enter the First Name of Contact you want to delete :");
            string Firstnamedelete = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of Contact you want to delete :");
            string Lastnamedelete = Console.ReadLine();
            Console.WriteLine("\n");
            dictionary[deletecontact].DeleteContact(Firstnamedelete, Lastnamedelete);            
            Console.WriteLine("Press c for city or s for state");
            string place = Console.ReadLine();
            place = place.ToLower();
            Console.WriteLine("Enter name of place");
            String findPlace = Console.ReadLine();
            Dictionary<string, List<string>> dictionaryCity = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> dictionaryState = new Dictionary<string, List<string>>();
            foreach (var element in dictionary)
            {
                List<String> listOfPersonsinPlace = new List<string>();
                if (place.Equals("c"))
                {
                    listOfPersonsinPlace = element.Value.PersonsInCity(findPlace);
                    foreach (var name in listOfPersonsinPlace)
                    {
                        if (!dictionaryCity.ContainsKey(findPlace))
                        {
                            List<string> list = new List<string>();
                            list.Add(name);
                            dictionaryCity.Add(findPlace, list);
                        }
                        else
                            dictionaryCity[findPlace].Add(name);
                    }
                }
                else
                {
                    listOfPersonsinPlace = element.Value.PersonsInState(findPlace);
                    foreach (var name in listOfPersonsinPlace)
                    {
                        if (!dictionaryState.ContainsKey(findPlace))
                        {
                            List<string> list = new List<string>();
                            list.Add(name);
                            dictionaryState.Add(findPlace, list);
                        }
                        else
                            dictionaryState[findPlace].Add(name);
                    }
                }
            }
            if (dictionaryCity.Count != 0)
            {
                Console.WriteLine("Persons in the city :-");
                foreach (var mapElement in dictionaryCity)
                {
                    foreach (var listElement in mapElement.Value)
                        Console.WriteLine(listElement);
                }
            }
            else
            {
                Console.WriteLine("Persons in the state :-");
                foreach (var mapElement in dictionaryState)
                {
                    foreach (var listElement in mapElement.Value)
                        Console.WriteLine(listElement);
                }

            }
        }
        public static void SetDetails(AddressBookSystem obj)
        {
            Console.WriteLine("First Name : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Last Name :");
            string LastName = Console.ReadLine();
            Console.WriteLine("Address :");
            string Address = Console.ReadLine();
            Console.WriteLine("City :");
            string City = Console.ReadLine();
            Console.WriteLine("State :");
            string State = Console.ReadLine();
            Console.WriteLine("Zip Code :");
            int Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phone Number :");
            long PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Email Address :");
            string Email = Console.ReadLine();
            obj.addContacts(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
        }        
    }    
}

