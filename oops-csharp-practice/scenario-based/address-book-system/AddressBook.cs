using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public Contact[] Contacts { get; }
        public int MaxSize { get; }
        public int CurrentIndex { get; set; }
        public string AddressBookName {  get; set; }

        public AddressBook(int maxSize, string addressBookName)
        {
            this.MaxSize = maxSize;
            Contacts = new Contact[maxSize];
            CurrentIndex = 0;
            AddressBookName = addressBookName;
        }

        public override string? ToString()
        {
            return $"Max Size: {MaxSize} | Current Index: {CurrentIndex}";
        }
    }
}
