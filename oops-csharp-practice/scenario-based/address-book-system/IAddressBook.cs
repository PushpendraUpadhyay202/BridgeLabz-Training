using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact();
        void DisplayAllContacts();

        void EditExitingContact();

        void DeleteContact();

        void AddMultipleContacts();
    }
}
