using System;
using System.Collections.Generic;

class NthFromEnd
{
    static void Main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });

        int n = 2;

        string result = FindNthFromEnd(list, n);
        Console.WriteLine("Nth element from end: " + result);
    }

    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        if (n <= 0 || list.Count == 0)
        {
            return null;
        }

        LinkedListNode<string> current = list.Last;

        for (int i = 1; i < n && current != null; i++)
        {
            current = current.Previous;
        }

        if (current == null)
        {
            return null;
        }

        return current.Value;
    }
}
