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
    }
}
