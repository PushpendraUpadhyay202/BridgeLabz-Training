using System;
using System.Collections.Generic;

class SetToSortedList
{
    static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>(new int[] { 5, 3, 9, 1 });

        List<int> sortedList = ConvertToSortedList(set);

        Console.Write("Sorted List: ");
        PrintList(sortedList);
    }

    static List<int> ConvertToSortedList(HashSet<int> set)
    {
        List<int> list = new List<int>(set);
        list.Sort();
        return list;
    }

    static void PrintList(List<int> list)
    {
        foreach (int el in list)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine("\n");
    }
}
