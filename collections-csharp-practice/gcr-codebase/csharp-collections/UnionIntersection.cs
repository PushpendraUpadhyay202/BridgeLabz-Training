using System;
using System.Collections.Generic;

class UnionIntersection
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>(new int[] { 1, 2, 3 });
        HashSet<int> set2 = new HashSet<int>(new int[] { 3, 4, 5 });

        HashSet<int> union = Union(set1, set2);
        HashSet<int> intersection = Intersection(set1, set2);

        Console.Write("Union: ");
        PrintSet(union);

        Console.Write("Intersection: ");
        PrintSet(intersection);
    }

    static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>(set1);
        result.UnionWith(set2);
        return result;
    }

    static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>(set1);
        result.IntersectWith(set2);
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
