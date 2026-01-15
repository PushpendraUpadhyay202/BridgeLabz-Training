using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal class AddressBookUtility : IAddressBook
    {
        private AddressBook FirstAddressBook;
        private Contact[] Contacts;
        private int AddressBookMaxSize;
        private int AddressBookIndex;

        public AddressBookUtility()
        {
            FirstAddressBook = AddressBookMain.FirstAddressBook;
            AddressBookMaxSize = AddressBookMain.FirstAddressBook.MaxSize;
            AddressBookIndex = AddressBookMain.FirstAddressBook.CurrentIndex;
            Contacts = AddressBookMain.FirstAddressBook.Contacts;

        }
        public void AddContact()
        {
            Console.WriteLine("===========   Contact Add Window   ==============");

            if(AddressBookIndex >= AddressBookMaxSize)
            {
                Console.WriteLine("Contact Array is Full\n");
                
            }
            else
            {
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter city name: ");
                string city = Console.ReadLine();
                Console.Write("Enter state name: ");
                string state = Console.ReadLine();
                Console.Write("Enter Zip code: ");
                string zip = Console.ReadLine();
                Console.Write("Enter Phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);


                Contacts[AddressBookIndex++] = newContact;
                FirstAddressBook.CurrentIndex = AddressBookIndex;

                Console.WriteLine("Contact Added SuccessFully");
            }
        }
        
        public void DisplayAllContacts()
        {
            if(AddressBookIndex  == 0)
            {
                Console.WriteLine("\nThere are NO contacts in the address book...\n");
                return;
            }
            Console.WriteLine("All Contacts are :");
            for(int i = 0; i < AddressBookIndex; i++)
            {
                Console.WriteLine(Contacts[i]);
            }
            Console.WriteLine();
        }
    }
}
