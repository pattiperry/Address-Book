using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        //collection of all the contacts(dictionary of contacts)
        //dictionary has key/value pairs (string, contact) in this example
        private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();

        //using the add method to add contacts to the _contactList(dictionary)
        //add a try/catch to handle exceptions
        public void AddContact(Contact contact)
        {
            try
            {
                _contactList.Add(contact.Email, contact);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This contact already exist.");
            }
            
        }

        //method that searches the contacts for an email and returns and email that matches 
        public Contact GetByEmail(string email)
        {
           
                return _contactList[email];
            
        }

    
    }
}