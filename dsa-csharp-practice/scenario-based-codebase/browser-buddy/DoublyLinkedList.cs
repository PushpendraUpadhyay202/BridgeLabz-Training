using Microsoft.VisualBasic.FileIO;

internal class DoublyLinkedList
{
    private ListNode head;
    private ListNode tail;
    private int size;

    private class ListNode
    {
        public Tab BrowserTab;
        public ListNode Next;
        public ListNode Prev;

        public ListNode(Tab browserTab)
        {
            BrowserTab = browserTab;
        }
    }

    // Method to insert a node at the end
    public void InsertAtEnd(Tab browserTab)
    {
        ListNode node = new ListNode(browserTab);

        if(head == null)
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
    
    // Method to remove a node from the end
    public Tab RemoveFromEnd()
    {
        if(size == 0)
        {
            return null;
        }
        Tab removedTab = null;

        // When there's only one node
        if(size == 1)
        {
            removedTab = head.BrowserTab;
            head = tail = null;
            size--;
            return removedTab;
        }

        ListNode oldTail = tail;
        removedTab = oldTail.BrowserTab;
        tail = tail.Prev;
        tail.Next = null;
        oldTail.Prev = null;

        size--;
        return removedTab;
    }

    // Method to remove a from the start
    public Tab RemoveFromStart()
    {
        if(size == 0)
        {
            return null;
        }

        Tab removedTab = null;

        if(size == 1)
        {
            removedTab = head.BrowserTab;
            head = tail = null;
            size--;
            return removedTab;
        }

        ListNode oldHead = head;
        removedTab = oldHead.BrowserTab;
        head = head.Next;
        head.Prev = null;
        oldHead.Next = null;
        size--;
        return removedTab;
    }

    // Method to remove a node by its tab name
    public Tab RemoveByTabName(string tabName)
    {
        if(size == 0)
        {
            return null;
        }

        ListNode temp = head;
        
        while(temp != null && !temp.BrowserTab.GetTabName().Equals(tabName))
        {
            temp = temp.Next;
        }

        if(temp == null)
        {
            return null;
        }

        if(temp == head)
        {
            return RemoveFromStart();
        }

        if (temp == tail)
        {
            return RemoveFromEnd();
        }

        Tab removedTab = temp.BrowserTab;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
        temp.Next = null;
        temp.Prev = null;
        size--;
        return removedTab;
    }

    // Method to print the doubly linked list
    public void PrintList()
    {

        ListNode temp = head;
        while(temp != null)
        {
            Console.WriteLine(temp.BrowserTab.GetTabName());
            temp = temp.Next;
        }
    }

    // Method to check if  a given tab is present
    public bool IsTabPresent(string tabName)
    {
        ListNode temp = head;
        while(temp != null)
        {
            if (temp.BrowserTab.GetTabName().Equals(tabName))
            {
                return true;
            }

            temp = temp.Next;
        }
        return false;
    }

    // Method to check if list is empty
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Method to get size of the linked list.
    public int Size()
    {
        return size;
    }

    // Method to find a tab by given name
    public Tab FindTab(string tabName)
    {
        ListNode temp = head;
        while(temp != null)
        {
            if (temp.BrowserTab.GetTabName().Equals(tabName))
            {
                return temp.BrowserTab;
            }
            temp = temp.Next;
        }

        return null;
    }
}