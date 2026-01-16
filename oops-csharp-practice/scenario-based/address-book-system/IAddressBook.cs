using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact();
        void DisplayAllContacts();

        void EditExistingContact();

        void DeleteContact();

        void AddMultipleContacts();

        void ListAllAddressBooks();
        void CreateAddressBook();

        void ListAllContactsInCityOrState();

        void SearchContactInCityOrState();

        void CountContactsByCityOrState();

        void SortContactsAlphabeticallyByFirstName();
    }
}
