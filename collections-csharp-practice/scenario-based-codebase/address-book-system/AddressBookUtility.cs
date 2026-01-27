using System;
using System.Collections.Generic;

internal class AddressBookUtility : IAddressBook
{
    private readonly Dictionary<string, AddressBook> addressBooks =
        new Dictionary<string, AddressBook>(StringComparer.OrdinalIgnoreCase);

    public AddressBookUtility()
    {
        addressBooks["default"] = new AddressBook("default");
    }

    public void AddContact()
    {
        try
        {
            Console.Write("Address book name (blank = default): ");
            string bookName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookName))
                bookName = "default";

            if (!addressBooks.ContainsKey(bookName))
                throw new Exception("Address book does not exist.");

            AddressBook book = addressBooks[bookName];

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            foreach (Contact c in book.Contacts)
            {
                if (c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Contact with same first name already exists.");
            }

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip: ");
            string zip = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            book.Contacts.Add(new Contact(firstName, lastName, city, state, zip, phone, email));
            Console.WriteLine("Contact added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void DisplayAllContacts()
    {
        foreach (AddressBook book in addressBooks.Values)
        {
            Console.WriteLine($"\nAddress Book: {book.Name}");
            foreach (Contact contact in book.Contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }

    public void EditExistingContact()
    {
        Console.Write("Enter contact first name: ");
        string firstName = Console.ReadLine();

        Contact found = null;

        foreach (AddressBook book in addressBooks.Values)
        {
            foreach (Contact contact in book.Contacts)
            {
                if (contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    found = contact;
                    break;
                }
            }
            if (found != null) break;
        }

        if (found == null)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        int choice = -1; // ✅ FIX: initialize variable

        do
        {
            Console.WriteLine("\nWhat do you want to edit?");
            Console.WriteLine("1. First Name");
            Console.WriteLine("2. Last Name");
            Console.WriteLine("3. City");
            Console.WriteLine("4. State");
            Console.WriteLine("5. Zip Code");
            Console.WriteLine("6. Phone Number");
            Console.WriteLine("7. Email");
            Console.WriteLine("0. Exit Edit Menu");
            Console.Write("Enter choice: ");

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter new first name: ");
                    found.FirstName = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Enter new last name: ");
                    found.LastName = Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Enter new city: ");
                    found.City = Console.ReadLine();
                    break;
                case 4:
                    Console.Write("Enter new state: ");
                    found.State = Console.ReadLine();
                    break;
                case 5:
                    Console.Write("Enter new zip code: ");
                    found.ZipCode = Console.ReadLine();
                    break;
                case 6:
                    Console.Write("Enter new phone number: ");
                    found.PhoneNumber = Console.ReadLine();
                    break;
                case 7:
                    Console.Write("Enter new email: ");
                    found.Email = Console.ReadLine();
                    break;
                case 0:
                    Console.WriteLine("Exiting edit menu.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice != 0)
                Console.WriteLine("Contact updated successfully.");

        } while (choice != 0);
    }


    public void DeleteContact()
    {
        Console.Write("First name to delete: ");
        string firstName = Console.ReadLine();

        foreach (AddressBook book in addressBooks.Values)
        {
            for (int i = 0; i < book.Contacts.Count; i++)
            {
                if (book.Contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    book.Contacts.RemoveAt(i);
                    Console.WriteLine("Contact deleted.");
                    return;
                }
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void AddMultipleContacts()
    {
        try
        {
            Console.Write("How many contacts? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
                AddContact();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
    }

    public void ListAllAddressBooks()
    {
        foreach (string name in addressBooks.Keys)
        {
            Console.WriteLine(name);
        }
    }

    public void CreateAddressBook()
    {
        try
        {
            Console.Write("New address book name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
                throw new Exception("Address book already exists.");

            addressBooks[name] = new AddressBook(name);
            Console.WriteLine("Address book created.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void ListAllContactsInCityOrState()
    {
        Console.Write("City or State: ");
        string query = Console.ReadLine();

        foreach (AddressBook book in addressBooks.Values)
        {
            foreach (Contact c in book.Contacts)
            {
                if (c.City == query || c.State == query)
                    Console.WriteLine(c);
            }
        }
    }

    public void SearchContactInCityOrState()
    {
        Console.Write("First Name: ");
        string name = Console.ReadLine();
        Console.Write("City/State: ");
        string query = Console.ReadLine();

        foreach (AddressBook book in addressBooks.Values)
        {
            foreach (Contact c in book.Contacts)
            {
                if (c.FirstName == name && (c.City == query || c.State == query))
                {
                    Console.WriteLine(c);
                    return;
                }
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void CountContactsByCityOrState()
    {
        Console.Write("City or State: ");
        string query = Console.ReadLine();

        int count = 0;

        foreach (AddressBook book in addressBooks.Values)
        {
            foreach (Contact c in book.Contacts)
            {
                if (c.City == query || c.State == query)
                    count++;
            }
        }

        Console.WriteLine($"Count: {count}");
    }

    public void SortContactsAlphabeticallyByFirstName()
    {
        foreach (AddressBook book in addressBooks.Values)
        {
            book.Contacts.Sort((a, b) =>
                string.Compare(a.FirstName, b.FirstName, StringComparison.OrdinalIgnoreCase));
        }

        DisplayAllContacts();
    }
}
