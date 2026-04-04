using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> visited = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (visited.Contains(complement))
                return true;

            visited.Add(arr[i]);
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 8, 4, 1, 6, 2 };
        int target = 10;

        if (PairWithGivenSum.HasPairWithSum(arr, target))
            Console.WriteLine("Pair exists");
        else
            Console.WriteLine("Pair does not exist");
    }
}

