using System.Collections.Concurrent;

internal class ContactLinkedList
{
    private ListNode head;
    private ListNode tail;
    private int size;
    private class ListNode
    {
        public Contact ContactData;
        public ListNode Next;
        public ListNode Prev;

        public ListNode(Contact contactData)
        {
            ContactData = contactData;
        }
    }

    public void InsertAtEnd(Contact contact)
    {
        ListNode node = new ListNode(contact);

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

    public Contact RemoveFromEnd()
    {
        if (size == 0)
        {
            return null;
        }
        Contact removedContact = null;

        // When there's only one node
        if (size == 1)
        {
            removedContact = head.ContactData;
            head = tail = null;
            size--;
            return removedContact;
        }

        ListNode oldTail = tail;
        removedContact = oldTail.ContactData;
        tail = tail.Prev;
        tail.Next = null;
        oldTail.Prev = null;

        size--;
        return removedContact;
    }

    public Contact RemoveFromStart()
    {
        if (size == 0)
        {
            return null;
        }

        Contact removedContact = null;

        if (size == 1)
        {
            removedContact = head.ContactData;
            head = tail = null;
            size--;
            return removedContact;
        }

        ListNode oldHead = head;
        removedContact = oldHead.ContactData;
        head = head.Next;
        head.Prev = null;
        oldHead.Next = null;
        size--;
        return removedContact;
    }

    public Contact RemoveByContactFirstName(string contactFirstName)
    {
        if (size == 0)
        {
            return null;
        }

        ListNode temp = head;

        while (temp != null && !temp.ContactData.GetFirstName().Equals(contactFirstName))
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

        Contact removedContact = temp.ContactData;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
        temp.Next = null;
        temp.Prev = null;
        size--;
        return removedContact;
    }

    public void PrintContactList()
    {
        ListNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.ContactData);
            temp = temp.Next;
        }
    }

    public bool IsContactPresent(string contactFirstName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.ContactData.GetFirstName().Equals(contactFirstName))
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

    public Contact FindContact(string contactFirstName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.ContactData.GetFirstName().Equals(contactFirstName))
            {
                return temp.ContactData;
            }
            temp = temp.Next;
        }

        return null;
    }
    
    public void ListAllContactsInCityOrState(string searchQuery)
    {
        ListNode temp = head;
        while(temp != null)
        {
            Contact contact = temp.ContactData;
            if(contact.GetCity().Equals(searchQuery) || contact.GetState().Equals(searchQuery))
            {
                Console.WriteLine(contact);
                Console.WriteLine("\n");
            }

            temp = temp.Next;
        }
    }

    public void SearchContactInCityOrState(string firstName, string searchQuery)
    {
        ListNode temp = head;
        while(temp != null)
        {
            Contact contact = temp.ContactData;
            if(contact.GetFirstName().Equals(firstName) && (contact.GetCity().Equals(searchQuery) || contact.GetState().Equals(searchQuery)))
            {
                Console.WriteLine(contact);
                Console.WriteLine("\n");
            }
            temp = temp.Next;
        }
    }

    public int CountContactsByCityOrState(string searchQuery)
    {
        int count = 0;
        ListNode temp = head;

        while(temp != null)
        {
            Contact contact = temp.ContactData;
            if (contact.GetCity().Equals(searchQuery) || contact.GetState().Equals(searchQuery)) count++;
            temp = temp.Next;
        }

        return count;
    }

    public void Sort()
    {
        QuickSort(head, tail);
    }

    private void QuickSort(ListNode left, ListNode right)
    {
        if (left == null || right == null || left == right || left == right.Next) return;

        ListNode pivotPointer = Partition(left, right);
        QuickSort(left, pivotPointer.Prev);
        QuickSort(pivotPointer.Next, right);
    }

    private ListNode Partition(ListNode left, ListNode right)
    {
        ListNode pivotNode = right;
        ListNode boundary = left.Prev;
        ListNode temp = left;

        while(temp != null && temp != right)
        {
            if(String.Compare(temp.ContactData.GetFirstName(), pivotNode.ContactData.GetFirstName()) <= 0)
            {
                boundary = (boundary == null) ? left : boundary.Next;

                Contact temp1 = boundary.ContactData;
                boundary.ContactData = temp.ContactData;
                temp.ContactData = temp1;
            }
            temp = temp.Next;
        }

        Contact temp3 = pivotNode.ContactData;

        if(boundary == null)
        {
            pivotNode.ContactData = left.ContactData;
            left.ContactData = temp3;
            return left;
        }

        pivotNode.ContactData = boundary.Next.ContactData;
        boundary.Next.ContactData = temp3;
        return boundary.Next;
    }
}