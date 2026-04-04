using System;
using System.Collections.Generic;

class SubsetCheck
{
    static void Main(string[] args)
    {
        HashSet<int> subset = new HashSet<int>(new int[] { 2, 3 });
        HashSet<int> superset = new HashSet<int>(new int[] { 1, 2, 3, 4 });

        bool isSubset = IsSubset(subset, superset);
        Console.WriteLine(isSubset);
    }

    static bool IsSubset(HashSet<int> subset, HashSet<int> superset)
    {
        return subset.IsSubsetOf(superset);
    }
}
