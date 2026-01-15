using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        public static AddressBook FirstAddressBook;

        static AddressBookMain()
        {
            FirstAddressBook = new AddressBook(1);
        }

        public static void Main(string[] args)
        {
            AddressBookMenu addressBookMenu = new AddressBookMenu();
            addressBookMenu.Menu();
        }


    }
}
