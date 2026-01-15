using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

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

        public void EditExitingContact()
        {
            if(AddressBookIndex == 0)
            {
                Console.WriteLine("\nThere are NO contacts in the address book...\n");
                return;
            }

            Console.WriteLine("============    Edit Contact Window   ===============");
            Console.Write("Enter contact first name: ");
            string name = Console.ReadLine();

            Contact contact = FindContactByName(name);

            if (contact == null)
            {
                Console.WriteLine("\nContact with this first name doesn't exist\n");
                return;
            }

            int choice;
            do
            {
                Console.WriteLine("1. Edit first name.");
                Console.WriteLine("2. Edit last name.");
                Console.WriteLine("3. Edit Address.");
                Console.WriteLine("4. Edit city name.");
                Console.WriteLine("5. Edit state name.");
                Console.WriteLine("6. Edit zip.");
                Console.WriteLine("7. Edit phone number.");
                Console.WriteLine("8. Edit Email.");
                Console.WriteLine("0. Cancel Edit");

                Console.Write("\nPlease enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter updated first name: ");
                        string firstName = Console.ReadLine();
                        contact.FirstName = firstName;
                        break;
                    case 2:
                        Console.Write("Please enter updated last name: ");
                        string lastName = Console.ReadLine();
                        contact.LastName = lastName;
                        break;
                    case 3:
                        Console.Write("Please enter updated address: ");
                        string address = Console.ReadLine();
                        contact.Address = address;
                        break;
                    case 4:
                        Console.Write("Please enter updated city name: ");
                        string cityName = Console.ReadLine();
                        contact.City = cityName;
                        break;
                    case 5:
                        Console.Write("Please enter updated state name: ");
                        string stateName = Console.ReadLine();
                        contact.State = stateName;
                        break;
                    case 6:
                        Console.Write("Please enter updated zip code: ");
                        string zip = Console.ReadLine();
                        contact.Zip = zip;
                        break;
                    case 7:
                        Console.Write("Please enter updated phone number: ");
                        string phoneNumber = Console.ReadLine();
                        contact.PhoneNumber = phoneNumber;
                        break;
                    case 8:
                        Console.Write("Please enter updated email: ");
                        string email = Console.ReadLine();
                        contact.Email= email;
                        break;
                    case 0:
                        Console.WriteLine("Exiting.........");
                        return;
                }

                Console.WriteLine("\nContact Updated Successfully...\n");
            }
            while (choice !=0);
        }

        public void DeleteContact()
        {
            if(AddressBookIndex == 0)
            {
                Console.WriteLine("\nThere are NO contacts in the address book...\n");
                return;
            }

            Console.WriteLine("==========    Contact Deletion Window    ==============");
            Console.Write("Enter the first name: ");
            string name = Console.ReadLine();

            int contactIndex = FindContactIndex(name);

            if(contactIndex == -1)
            {
                Console.WriteLine("\nContact with this first name doesn't exist\n");
                return;
            }

            //Deletion Logic:
            //Shift all contacts after the deleted index one position left.
            //Reduce AddressBookIndex by 1 to remove the duplicate last entry.
            for (int i = contactIndex; i < AddressBookIndex && i < AddressBookMaxSize - 1; i++)
            {
                Contacts[i] = Contacts[i + 1];
            }

            AddressBookIndex--;
            FirstAddressBook.CurrentIndex = AddressBookIndex;

            Console.WriteLine("\nContact Deleted Successfully...\n");
        }

        public void AddMultipleContacts()
        {
            int remainingSpaces = AddressBookMaxSize - AddressBookIndex;
            if(remainingSpaces == 0)
            {
                Console.WriteLine("Contact Array is Full\n");
                return;
            }
            Console.WriteLine("\nYou can add "+ remainingSpaces + " more Only\n");
            Console.Write("Enter the number of Contacts you want to add: \n");
            int number = int.Parse(Console.ReadLine());

            if (number > (remainingSpaces))
            {
                Console.WriteLine("Please Enter a number less than "+ remainingSpaces+"\n");
                return;
            }
            for (int i = 0; i < number; i++)
            {
                AddContact();
            }
        }

        // Helper method for DeleteContact method to find the index of a contact given its first name
        // Returns the contact index if the contact is found in the array
        // Return -1 otherwise
        private int FindContactIndex(string firstName)
        {
            for (int i = 0; i < AddressBookIndex; i++)
            {
                if (Contacts[i].FirstName.Equals(firstName)) return i;
            }

            return -1;
        }

        // Helper method for EditExistingContact method to find a contact given its name
        // Returns the contact if the contact is found in the array
        // Returns null otherwise
        private Contact FindContactByName(string name)
        {
            for (int i = 0; i < AddressBookIndex; i++)
            {
                if (Contacts[i].FirstName.Equals(name)) return Contacts[i];
            }

            return null;
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
