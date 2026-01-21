using System;
using System.Collections.Generic;

class SetsEquality
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>(new int[] { 1, 2, 3 });
        HashSet<int> set2 = new HashSet<int>(new int[] { 3, 2, 1 });

        bool areEqual = AreSetsEqual(set1, set2);
        Console.WriteLine(areEqual);
    }

    static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        if (set1 == null || set2 == null)
        {
            return false;
        }

        return set1.SetEquals(set2);
    }
}
