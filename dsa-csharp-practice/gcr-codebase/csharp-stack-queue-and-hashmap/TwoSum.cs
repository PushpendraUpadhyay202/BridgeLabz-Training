using System;
using System.Collections.Generic;

class TwoSum
{
    public static int[] FindTwoSum(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>(); // value -> index

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(arr[i]))
            {
                map.Add(arr[i], i);
            }
        }

        return new int[] { -1, -1 }; 
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum.FindTwoSum(arr, target);

        if (result[0] != -1)
        {
            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
        }
        else
        {
            Console.WriteLine("No valid pair found");
        }
    }
}

