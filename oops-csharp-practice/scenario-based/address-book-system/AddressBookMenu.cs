using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal class AddressBookMenu
    {
        private IAddressBook addressBookUtility;

        public AddressBookMenu()
        {
            addressBookUtility = new AddressBookUtility();
        }

        public void Menu()
        {
            Console.WriteLine("=========   Welcome to Address Book   ==============");

            while (true)
            {
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display All Contacts");
                Console.WriteLine("3.Edit Exiting Contact");
                Console.WriteLine("4.Delete a Contact");
                Console.WriteLine("5.Add Multiple Contacts");
                Console.WriteLine("6. List all Address Books");
                Console.WriteLine("7. Create an Address Book.");
                Console.WriteLine("8. List all contacts in a city or state.");
                Console.WriteLine("9.Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBookUtility.AddContact();
                        break;
                    case 2:
                        addressBookUtility.DisplayAllContacts();
                        break;
                    case 3:
                        addressBookUtility.EditExistingContact();
                        break;
                    case 4:
                        addressBookUtility.DeleteContact();
                        break;
                    case 5:
                        addressBookUtility.AddMultipleContacts();
                        break;
                    case 6:
                        addressBookUtility.ListAllAddressBooks();
                        break;
                    case 7:
                        addressBookUtility.CreateAddressBook();
                        break;
                    case 8:
                        addressBookUtility.ListAllContactsInCityOrState();
                        break;
                    case 9:
                        Console.WriteLine("Exiting Program................");
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Enter option from 1 to 5 Only");
                        break;
                }
            }
        }
    }
}
