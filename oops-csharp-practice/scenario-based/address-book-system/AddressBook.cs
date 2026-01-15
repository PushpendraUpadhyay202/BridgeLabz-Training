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

        public AddressBook(int maxSize)
        {
            this.MaxSize = maxSize;
            Contacts = new Contact[maxSize];
            CurrentIndex = 0;
        }

        public override string? ToString()
        {
            return $"Max Size: {MaxSize} | Current Index: {CurrentIndex}";
        }
    }
}
