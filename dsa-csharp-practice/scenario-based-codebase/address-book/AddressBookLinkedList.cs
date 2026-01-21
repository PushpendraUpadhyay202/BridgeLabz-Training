internal class AddressBookLinkedList
{
    private ListNode head;
    private ListNode tail;
    private int size;
    private class ListNode
    {
        public AddressBook AddressBookData;
        public ListNode Next;
        public ListNode Prev;

        public ListNode(AddressBook addressBookData)
        {
            AddressBookData = addressBookData;
        }
    }

    public void InsertAtEnd(AddressBook addressBook)
    {
        ListNode node = new ListNode(addressBook);

        if (head == null)
        {
            head = tail = node;
            size++;
            return;
        }

        node.Prev = tail;
        tail.Next = node;
        tail = node;
        size++;
    }

    public AddressBook RemoveFromEnd()
    {
        if (size == 0)
        {
            return null;
        }
        AddressBook removedAddressBook = null;

        // When there's only one node
        if (size == 1)
        {
            removedAddressBook = head.AddressBookData;
            head = tail = null;
            size--;
            return removedAddressBook;
        }

        ListNode oldTail = tail;
        removedAddressBook = oldTail.AddressBookData;
        tail = tail.Prev;
        tail.Next = null;
        oldTail.Prev = null;

        size--;
        return removedAddressBook;
    }

    public AddressBook RemoveFromStart()
    {
        if (size == 0)
        {
            return null;
        }

        AddressBook removedAddressBook = null;

        if (size == 1)
        {
            removedAddressBook = head.AddressBookData;
            head = tail = null;
            size--;
            return removedAddressBook;
        }

        ListNode oldHead = head;
        removedAddressBook = oldHead.AddressBookData;
        head = head.Next;
        head.Prev = null;
        oldHead.Next = null;
        size--;
        return removedAddressBook;
    }

    public AddressBook RemoveAddressBookByName(string addressBookName)
    {
        if (size == 0)
        {
            return null;
        }

        ListNode temp = head;

        while (temp != null && !temp.AddressBookData.GetAddressBookName().Equals(addressBookName))
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            return null;
        }

        if (temp == head)
        {
            return RemoveFromStart();
        }

        if (temp == tail)
        {
            return RemoveFromEnd();
        }

        AddressBook removedContact = temp.AddressBookData;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
        temp.Next = null;
        temp.Prev = null;
        size--;
        return removedContact;
    }

    public void PrintAddressBookList()
    {
        ListNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.AddressBookData.GetAddressBookName());
            Console.WriteLine("=======================================");
            temp.AddressBookData.GetContacts().PrintContactList();
            Console.WriteLine("\n");
            temp = temp.Next;
        }
    }

    public bool IsAddressBookPresent(string addressBookName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.AddressBookData.GetAddressBookName().Equals(addressBookName))
            {
                return true;
            }

            temp = temp.Next;
        }
        return false;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public int Size()
    {
        return size;
    }

    public AddressBook FindAddressBook(string addressBookName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.AddressBookData.GetAddressBookName().Equals(addressBookName))
            {
                return temp.AddressBookData;
            }
            temp = temp.Next;
        }

        return null;
    }

    public Contact FindContactByFirstName(string firstName)
    {
        ListNode temp = head;

        while(temp != null)
        {
            ContactLinkedList contacts = temp.AddressBookData.GetContacts();
            Contact contact = contacts.FindContact(firstName);
            if (contact != null) return contact;

            temp = temp.Next;
        }

        return null;
    }

    public AddressBook FindAddressBookByContactName(string firstName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            ContactLinkedList contacts = temp.AddressBookData.GetContacts();
            if (contacts.IsContactPresent(firstName))
            {
                return temp.AddressBookData;
            }
            temp = temp.Next;
        }

        return null;
    }

    public Contact RemoveContactByFirstName(AddressBook addressBook, string firstName)
    {
        ContactLinkedList contacts = addressBook.GetContacts();
        Contact removedContact = contacts.RemoveByContactFirstName(firstName);
        return removedContact;
    }

    public void ListAllAddressBooksNames()
    {
        ListNode temp = head;
        int count = 1;
        while(temp != null)
        {
            Console.WriteLine($"{count++}. {temp.AddressBookData.GetAddressBookName()}\n");
            temp = temp.Next;
        }
    }
    
    public void ListAllContactsInCityOrState(string searchQuery)
    {
        ListNode temp = head;
        while(temp != null)
        {
            ContactLinkedList contacts = temp.AddressBookData.GetContacts();
            contacts.ListAllContactsInCityOrState(searchQuery);
            temp = temp.Next;
        }
    }

    public void SearchContactInCityOrState(string firstName, string searchQuery)
    {
        ListNode temp = head;
        while(temp != null)
        {
            ContactLinkedList contacts = temp.AddressBookData.GetContacts();
            contacts.SearchContactInCityOrState(firstName, searchQuery);
            temp = temp.Next;
        }
    }

    public int CountContactsByCityOrState(string searchQuery)
    {
        int count = 0;
        ListNode temp = head;
        while(temp != null)
        {
            ContactLinkedList contacts = temp.AddressBookData.GetContacts();
            count += contacts.CountContactsByCityOrState(searchQuery);
            temp = temp.Next;
        }

        return count;
    }

    public void Sort()
    {
        ListNode temp = head;
        while(temp != null)
        {
            ContactLinkedList contacts = temp.AddressBookData.GetContacts();
            contacts.Sort();
            temp = temp.Next;
        }
    }
}