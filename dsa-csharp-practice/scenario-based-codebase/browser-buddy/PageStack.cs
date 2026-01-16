internal class PageStack
{
    private int size;
    private ListNode head;

    private class ListNode
    {
        public string PageName;
        public ListNode Next;

        public ListNode(string pageName)
        {
            PageName = pageName;
        }
    }

    // Method to push a Page on PageStack
    public void Push(string pageName)
    {
        ListNode node = new ListNode(pageName);

        node.Next = head;
        head = node;
        size++;
    }

    // Method to pop a Page from PageStack
    public string Pop()
    {
        if(head == null)
        {
            return "";
        }

        string poppedPageName = head.PageName;
        head = head.Next;
        size--;
        return poppedPageName;
    }

    // Method to peek a Page from PageStack
    public string Peek()
    {
        if(head == null)
        {
            return "";
        }

        return head.PageName;
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Method to get the stack size
    public int StackSize()
    {
        return size;
    }
    
    // Method to clear the entire stack
    public void Clear()
    {
        head = null;
        size = 0;
    }
}