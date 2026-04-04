using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AddressBookSystem
{
    internal class AddressBookUtility : IAddressBook
    {
        private AddressBook[] AddressBooks;
        private int AddressBookArrayIndex;

        public AddressBookUtility()
        {
            AddressBooks = AddressBookMain.AddressBooks;
            AddressBookArrayIndex = AddressBookMain.AddressBookArrayIndex;

        }

        public void AddContact()
        {
            Console.WriteLine("\n===========   Contact Add Window   ==============\n");
            Console.Write("Enter address book name (press enter for default): ");
            string addressBookName = Console.ReadLine();

            if (addressBookName == "") addressBookName = "default";

            AddressBook addressBook = FindAddressBookByName(addressBookName);

            if (addressBook == null)
            {
                Console.WriteLine("\nAddress book with this name doesn't exist.\n");
                return;
            }

            int addressBookIndex = addressBook.CurrentIndex;
            int addressBookMaxSize = addressBook.MaxSize;
            Contact[] contacts = addressBook.Contacts;

            if (addressBookIndex >= addressBookMaxSize)
            {
                Console.WriteLine("\nContact array is full.\n");
                return;
            }

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            if (IsDuplicate(firstName, addressBookName))
            {
                Console.WriteLine("\nA contact with same first name already exist.\n");
                return;
            }

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

            contacts[addressBookIndex] = newContact;
            addressBook.CurrentIndex = addressBookIndex + 1;

            Console.WriteLine("\nContact added successfully.\n");
        }

        public void ListAllAddressBooks()
        {
            Console.WriteLine("\nHere is a list of all the address books: \n");
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                Console.WriteLine($"Address Book Name: {AddressBooks[i].AddressBookName}");
            }
        }

        public void CreateAddressBook()
        {
            if (AddressBookArrayIndex >= AddressBooks.Length)
            {
                Console.WriteLine("\nAddress book array is already full. You cannot create any more address books.\n");
                return;
            }

            Console.WriteLine("\n==== Address Book Creation Window ====\n");
            Console.Write("Please enter address book max capacity: ");
            int addressBookMaxCapacity = int.Parse(Console.ReadLine());
            Console.Write("Please enter address book name: ");
            string addressBookName = Console.ReadLine();

            AddressBook NewAddressBook = new AddressBook(addressBookMaxCapacity, addressBookName);

            AddressBooks[AddressBookArrayIndex++] = NewAddressBook;
        }


        public void EditExistingContact()
        {
            if (AddressBookArrayIndex == 0)
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
                Console.WriteLine("\n1. Edit first name.");
                Console.WriteLine("2. Edit last name.");
                Console.WriteLine("3. Edit address.");
                Console.WriteLine("4. Edit city name.");
                Console.WriteLine("5. Edit state name.");
                Console.WriteLine("6. Edit zip code.");
                Console.WriteLine("7. Edit phone number.");
                Console.WriteLine("8. Edit email.");
                Console.WriteLine("0. Cancel Edit");

                Console.Write("\nPlease enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter updated first name: ");
                        contact.FirstName = Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("Please enter updated last name: ");
                        contact.LastName = Console.ReadLine();
                        break;

                    case 3:
                        Console.Write("Please enter updated address: ");
                        contact.Address = Console.ReadLine();
                        break;

                    case 4:
                        Console.Write("Please enter updated city name: ");
                        contact.City = Console.ReadLine();
                        break;

                    case 5:
                        Console.Write("Please enter updated state name: ");
                        contact.State = Console.ReadLine();
                        break;

                    case 6:
                        Console.Write("Please enter updated zip code: ");
                        contact.Zip = Console.ReadLine();
                        break;

                    case 7:
                        Console.Write("Please enter updated phone number: ");
                        contact.PhoneNumber = Console.ReadLine();
                        break;

                    case 8:
                        Console.Write("Please enter updated email: ");
                        contact.Email = Console.ReadLine();
                        break;

                    case 0:
                        Console.WriteLine("Exiting edit mode...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nContact Updated Successfully...\n");
                }

            } while (choice != 0);
        }


        public void DeleteContact()
        {
            Console.WriteLine("==========    Contact Deletion Window    ==============");
            Console.Write("Enter address book name: ");
            string bookName = Console.ReadLine();

            AddressBook addressBook = FindAddressBookByName(bookName);

            if (addressBook == null)
            {
                Console.WriteLine("\nAddress book with this name doesn't exist.\n");
                return;
            }

            if (addressBook.CurrentIndex == 0)
            {
                Console.WriteLine("\nThere are NO contacts in the address book...\n");
                return;
            }

            Console.Write("Enter the first name: ");
            string name = Console.ReadLine();

            int contactIndex = FindContactIndex(name);

            if (contactIndex == -1)
            {
                Console.WriteLine("\nContact with this first name doesn't exist\n");
                return;
            }

            Contact[] contacts = addressBook.Contacts;

            // Deletion Logic:
            // Shift contacts left to overwrite the deleted contact
            for (int i = contactIndex; i < addressBook.CurrentIndex - 1; i++)
            {
                contacts[i] = contacts[i + 1];
            }

            // Update index of that address book
            addressBook.CurrentIndex--;

            Console.WriteLine("\nContact Deleted Successfully...\n");
        }


        public void AddMultipleContacts()
        {
            Console.Write("\nPlease enter address book name: ");
            string bookName = Console.ReadLine();

            AddressBook addressBook = FindAddressBookByName(bookName);

            if (addressBook == null)
            {
                Console.WriteLine("\nAddress book with given name doesn't exist.\n");
                return;
            }

            int remainingSpaces = addressBook.MaxSize - addressBook.CurrentIndex;

            if (remainingSpaces == 0)
            {
                Console.WriteLine("\nContact Array is Full\n");
                return;
            }

            Console.WriteLine("\nYou can add only " + remainingSpaces + " more contacts\n");
            Console.Write("Enter the number of contacts you want to add: ");
            int number = int.Parse(Console.ReadLine());

            if (number > remainingSpaces)
            {
                Console.WriteLine("\nPlease enter a number less than or equal to " + remainingSpaces + "\n");
                return;
            }

            for (int i = 0; i < number; i++)
            {
                AddContact();
            }
        }

        public void SearchContactInCityOrState()
        {
            Console.WriteLine("\n==== Search a contact in a city or state ====\n");
            Console.Write("Enter Contact's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Contact's city or state name: ");
            string cityOrStateName = Console.ReadLine();
            Console.WriteLine("\nHere is the result: \n");

            // Looking for the given contact in the given city or state
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                for (int j = 0; j < AddressBooks[i].CurrentIndex; j++)
                {
                    if (AddressBooks[i].Contacts[j].FirstName.Equals(firstName) && (AddressBooks[i].Contacts[j].City.Equals(cityOrStateName) || AddressBooks[i].Contacts[j].State.Equals(cityOrStateName)))
                    {
                        Console.WriteLine(AddressBooks[i].Contacts[j]);
                    }
                }
            }
        }

        public void CountContactsByCityOrState()
        {
            Console.WriteLine("\n==== Count Contacts By City or State name ====\n");
            Console.Write("Please enter the city or state name: ");
            string searchQuery = Console.ReadLine();
            int contactsCount = 0;

            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                for (int j = 0; j < AddressBooks[i].CurrentIndex; j++)
                {
                    if (AddressBooks[i].Contacts[j].City.Equals(searchQuery) || AddressBooks[i].Contacts[j].State.Equals(searchQuery))
                    {
                        contactsCount++;
                    }
                }
            }

            Console.WriteLine($"\nThe number of contacts residing in {searchQuery} is: {contactsCount}\n");
        }

        public void ListAllContactsInCityOrState()
        {
            Console.WriteLine("\n==== List all contacts in a city or state ====\n");
            Console.Write("Please enter city or state: ");
            string searchQuery = Console.ReadLine();
            Console.WriteLine($"\nHere are all the contacts that reside in {searchQuery}:\n");

            // Looking for cities or states which are equal to searchQuery and displaying all such contacts
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                for (int j = 0; j < AddressBooks[i].CurrentIndex; j++)
                {
                    if (AddressBooks[i].Contacts[j].City.Equals(searchQuery) || AddressBooks[i].Contacts[j].State.Equals(searchQuery))
                    {
                        Console.WriteLine(AddressBooks[i].Contacts[j]);
                    }
                }
            }

            Console.WriteLine("\n");
        }

        public void SortContactsAlphabeticallyByFirstName()
        {
            Console.WriteLine("\n==== Result of sorting contacts.");
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                QuickSort(AddressBooks[i].Contacts, 0, AddressBooks[i].CurrentIndex - 1);
            }
            DisplayAllContacts();
        }

        private void QuickSort(Contact[] contacts, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivotIndex = Partition(contacts, left, right);

            QuickSort(contacts, left, pivotIndex - 1);
            QuickSort(contacts, pivotIndex + 1, right);
        }

        private int Partition(Contact[] contacts, int left, int right)
        {
            Contact pivot = contacts[right];
            int boundary = left - 1;

            for (int i = left; i <= right - 1; i++)
            {
                if (String.Compare(contacts[i].FirstName, pivot.FirstName) < 0)
                {
                    boundary++;
                    // Swapping
                    Contact temp = contacts[i];
                    contacts[i] = contacts[boundary];
                    contacts[boundary] = temp;
                }
            }
            contacts[right] = contacts[boundary + 1];
            contacts[boundary + 1] = pivot;

            return boundary + 1;
        }

        // Helper method for DeleteContact method to find the index of a contact given its first name
        // Returns the contact index if the contact is found in the array
        // Return -1 otherwise
        private int FindContactIndex(string firstName)
        {
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                for (int j = 0; j < AddressBooks[i].CurrentIndex; j++)
                {
                    Console.WriteLine();
                    if (AddressBooks[i].Contacts[j].FirstName.Equals(firstName))
                    {
                        return j;
                    }
                }
            }

            return -1;
        }

        // Helper method for EditExistingContact method to find a contact given its name
        // Returns the contact if the contact is found in the array
        // Returns null otherwise
        private Contact FindContactByName(string firstname)
        {
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                for (int j = 0; j < AddressBooks[i].CurrentIndex; j++)
                {
                    Console.WriteLine();
                    if (AddressBooks[i].Contacts[j].FirstName.Equals(firstname))
                    {
                        return AddressBooks[i].Contacts[j];
                    }
                }
            }

            return null;
        }

        private AddressBook FindAddressBookByName(string addressBookName)
        {
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                if (AddressBooks[i].AddressBookName.Equals(addressBookName))
                {
                    return AddressBooks[i];
                }
            }
            return null;
        }

        private AddressBook FindAddressBookByContactName(string firstName)
        {
            for (int i = 0; i < AddressBookArrayIndex; i++)
            {
                for (int j = 0; j < AddressBooks[i].CurrentIndex; j++)
                {
                    Console.WriteLine();
                    if (AddressBooks[i].Contacts[j].FirstName.Equals(firstName))
                    {
                        return AddressBooks[i];
                    }
                }
            }

            return null;
        }

        public void DisplayAllContacts()
        {
            if(AddressBookArrayIndex == 0)
            {
                Console.WriteLine("\nThere are NO contacts in the address book...\n");
                return;
            }
            Console.WriteLine("All Contacts are :");
            for(int i = 0; i < AddressBookArrayIndex; i++)
            {
                AddressBook addressBook = AddressBooks[i];
                Console.WriteLine($"\nBook Name: {addressBook.AddressBookName}");
                for (int j = 0; j < addressBook.CurrentIndex; j++)
                {
                    Console.WriteLine(addressBook.Contacts[j]);
                }
            }
            Console.WriteLine();
        }

        // Checks if a contact with the same first name alread exists
        // If exists, return true
        // Else returns false;
        private bool IsDuplicate(string firstName, string addressBookName)
        {
            AddressBook addressBook = FindAddressBookByName(addressBookName);

            for (int i = 0; i < addressBook.CurrentIndex; i++)
            {
                if (addressBook.Contacts[i].FirstName.Equals(firstName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
