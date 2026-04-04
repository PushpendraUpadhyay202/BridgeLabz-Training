internal class AddressBookMenu
{
    private readonly IAddressBook addressBookUtility = new AddressBookUtility();

    public void ShowMenu()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Edit Existing Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Add Multiple Contacts");
                Console.WriteLine("6. List Address Books");
                Console.WriteLine("7. Create Address Book");
                Console.WriteLine("8. List Contacts by City/State");
                Console.WriteLine("9. Search Contact by City/State");
                Console.WriteLine("10. Count Contacts by City/State");
                Console.WriteLine("11. Sort Contacts Alphabetically");
                Console.WriteLine("0. Exit");
                Console.Write("Please enter your choice number: ");

                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice == 0) break;

                switch (choice)
                {
                    case 1: addressBookUtility.AddContact(); break;
                    case 2: addressBookUtility.DisplayAllContacts(); break;
                    case 3: addressBookUtility.EditExistingContact(); break;
                    case 4: addressBookUtility.DeleteContact(); break;
                    case 5: addressBookUtility.AddMultipleContacts(); break;
                    case 6: addressBookUtility.ListAllAddressBooks(); break;
                    case 7: addressBookUtility.CreateAddressBook(); break;
                    case 8: addressBookUtility.ListAllContactsInCityOrState(); break;
                    case 9: addressBookUtility.SearchContactInCityOrState(); break;
                    case 10: addressBookUtility.CountContactsByCityOrState(); break;
                    case 11: addressBookUtility.SortContactsAlphabeticallyByFirstName(); break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
