using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Shelf
{
    internal class Node
    {
        public Book data;
        public Node next;

        public Node(Book data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
