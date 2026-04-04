using System;
using System.Collections.Generic;

class RotateList
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>(new int[]{10, 20, 30, 40, 50});
        Console.Write("List (before rotation): ");
        PrintList(list);

        ListRotate(list, 10);
        Console.Write("List (after rotation): ");
        PrintList(list);

    }

    static void ListRotate(List<int> list, int position)
    {
        position = position%list.Count;
        list.Reverse(0, position);
        list.Reverse(position, list.Count-position);
        list.Reverse();
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