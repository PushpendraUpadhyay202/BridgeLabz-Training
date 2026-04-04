using System;
using System.Collections.Generic;

class SymmetricDifference
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>(new int[] { 1, 2, 3 });
        HashSet<int> set2 = new HashSet<int>(new int[] { 3, 4, 5 });

        HashSet<int> result = SymmetricDiff(set1, set2);

        Console.Write("Symmetric Difference: ");
        PrintSet(result);
    }

    static HashSet<int> SymmetricDiff(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>(set1);
        result.SymmetricExceptWith(set2);
        return result;
    }

    static void PrintSet(HashSet<int> set)
    {
        foreach (int el in set)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine("\n");
    }
}
