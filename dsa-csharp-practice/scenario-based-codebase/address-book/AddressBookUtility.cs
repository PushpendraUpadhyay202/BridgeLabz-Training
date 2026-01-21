using System;
internal class AddressBookUtility : IAddressBook
{
    private AddressBookLinkedList _addressBooks;

    public AddressBookUtility()
    {
        _addressBooks = new AddressBookLinkedList();
        // Providing a default Address Book named "default" to get the user started
        _addressBooks.InsertAtEnd(new AddressBook("default"));
    }
    public void AddContact()
    {
        Console.WriteLine("\n==== Contact Adding Window ====\n");
        Console.Write("Enter address book name (press enter for default): ");
        string addressBookName = Console.ReadLine();
        Console.WriteLine("\n");

        if (addressBookName == "") addressBookName = "default";

        AddressBook addressBook = _addressBooks.FindAddressBook(addressBookName);

        if (addressBook == null)
        {
            Console.WriteLine("\nAddress book with this name doesn't exist.\n");
            return;
        }

        ContactLinkedList contacts = addressBook.GetContacts();

        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        if (contacts.IsContactPresent(firstName))
        {
            Console.WriteLine("\nA contact with same first name already exist.\n");
            return;
        }

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter city name: ");
        string city = Console.ReadLine();
        Console.Write("Enter state name: ");
        string state = Console.ReadLine();
        Console.Write("Enter Zip code: ");
        string zipCode = Console.ReadLine();
        Console.Write("Enter Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Contact newContact = new Contact(firstName, lastName, city, state, zipCode, phoneNumber, email);

        contacts.InsertAtEnd(newContact);
        Console.WriteLine("\nContact added successfully.\n");
    }

    public void DisplayAllContacts()
    {
        Console.WriteLine("\nHere are all the contacts across all the address books\n");
        _addressBooks.PrintAddressBookList();
        Console.WriteLine("\n");
    }

    public void EditExistingContact()
    {
        Console.WriteLine("\n==== Editing Existing Contact Window ====\n");
        Console.Write("Enter contact first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("\n");
        Contact contact = _addressBooks.FindContactByFirstName(firstName);

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
            Console.WriteLine("3. Edit city name.");
            Console.WriteLine("4. Edit state name.");
            Console.WriteLine("5. Edit zip code.");
            Console.WriteLine("6. Edit phone number.");
            Console.WriteLine("7. Edit Email.");
            Console.WriteLine("0. Cancel Edit");
            Console.Write("\nPlease enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter updated first name: ");
                    string updatedFirstName = Console.ReadLine();
                    contact.SetFirstName(updatedFirstName);
                    break;
                case 2:
                    Console.Write("Please enter updated last name: ");
                    string lastName = Console.ReadLine();
                    contact.SetLastName(lastName);
                    break;
                case 3:
                    Console.Write("Please enter updated city name: ");
                    string cityName = Console.ReadLine();
                    contact.SetCity(cityName);
                    break;
                case 4:
                    Console.Write("Please enter updated state name: ");
                    string stateName = Console.ReadLine();
                    contact.SetState(stateName);
                    break;
                case 5:
                    Console.Write("Please enter updated zip code: ");
                    string zipCode = Console.ReadLine();
                    contact.SetZipCode(zipCode);
                    break;
                case 6:
                    Console.Write("Please enter updated phone number: ");
                    string phoneNumber = Console.ReadLine();
                    contact.SetPhoneNumber(phoneNumber);
                    break;
                case 7:
                    Console.Write("Please enter updated email: ");
                    string email = Console.ReadLine();
                    contact.SetEmail(email);
                    break;
            }

            Console.WriteLine("\nContact Updated Successfully...\n");
        } while (choice != 0);
    }

    public void DeleteContact()
    {
        Console.WriteLine("\n==== Contact Deletion Windows ====\n");
        Console.Write("Please enter the first name of the contact to delete: ");
        string firstName = Console.ReadLine();
        AddressBook addressBook = _addressBooks.FindAddressBookByContactName(firstName);
        

        if (addressBook == null)
        {
            Console.WriteLine("\nContact with this first name doesn't exist\n");
            return;
        }

        _addressBooks.RemoveContactByFirstName(addressBook, firstName);

        Console.WriteLine("\nContact Deleted Successfully...\n");
    }


    public void AddMultipleContacts()
    {
        Console.Write("\nPlease enter address book name: ");
        string bookName = Console.ReadLine();

        AddressBook addressBook = _addressBooks.FindAddressBook(bookName);

        if (addressBook == null)
        {
            Console.WriteLine("\nAddress book with given name doesn't exist.\n");
            return;
        }

        Console.Write("Please enter the number of contacts to you want to add: ");
        int numberOfContacts = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < numberOfContacts; i++)
        {
            AddContact();
        }
    }

    public void ListAllAddressBooks()
    {
        Console.WriteLine("\nHere is a list of all the address books: \n");
        _addressBooks.ListAllAddressBooksNames();
        Console.WriteLine("\n");
    }

    public void CreateAddressBook()
    {
        Console.WriteLine("\n==== Address Book Creation Window ====\n");
        Console.Write("Please enter address book name: ");
        string addressBookName = Console.ReadLine();

        AddressBook newAddressBook = new AddressBook(addressBookName);

        _addressBooks.InsertAtEnd(newAddressBook);
    }

    public void ListAllContactsInCityOrState()
    {
        Console.WriteLine("\n==== List all contacts in a city or state ====\n");
        Console.Write("Please enter city or state: ");
        string searchQuery = Console.ReadLine();
        Console.WriteLine($"\nHere are all the contacts that reside in {searchQuery}:\n");

        _addressBooks.ListAllContactsInCityOrState(searchQuery);

        Console.WriteLine("\n");
    }

    public void SearchContactInCityOrState()
    {
        Console.WriteLine("\n==== Search a contact in a city or state ====\n");
        Console.Write("Enter Contact's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Contact's city or state name: ");
        string cityOrStateName = Console.ReadLine();
        Console.WriteLine("\nHere is the result: \n");

        _addressBooks.SearchContactInCityOrState(firstName, cityOrStateName);
    }

    public void CountContactsByCityOrState()
    {
        Console.WriteLine("\n==== Count Contacts By City or State name ====\n");
        Console.Write("Please enter the city or state name: ");
        string searchQuery = Console.ReadLine();
        int contactsCount = _addressBooks.CountContactsByCityOrState(searchQuery);

        Console.WriteLine($"\nThe number of contacts residing in {searchQuery} is: {contactsCount}\n");
    }

    public void SortContactsAlphabeticallyByFirstName()
    {
        Console.WriteLine("\n==== Result of sorting contacts.");
        _addressBooks.Sort();
        DisplayAllContacts();
    }
}