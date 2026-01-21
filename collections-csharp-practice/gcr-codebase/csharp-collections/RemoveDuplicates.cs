using System;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>(new int[] {3, 1, 2, 2, 3, 4});
        Console.Write("list (before removig duplicates): ");
        PrintList(list);

        DuplicatesRemoval(list);
        Console.Write("list (after removig duplicates): ");
        PrintList(list);
    }

    static void DuplicatesRemoval(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> duplicatesRemoved = new List<int>();

        foreach(int el in list)
        {
            if (seen.Add(el))
            {
                duplicatesRemoved.Add(el);
            }
        }

        list.Clear();
        list.AddRange(duplicatesRemoved);
    }

    static void PrintList(List<int> list)
    {
        foreach(int el in list)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine("\n");
    }
}