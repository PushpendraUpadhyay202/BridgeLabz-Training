using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static void FindAllZeroSumSubarrays(int[] arr)
    {
        // Dictionary to store cumulative sum and list of indices
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

        int sum = 0;

        // Initialize with sum = 0 at index -1
        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int startIndex in map[sum])
                {
                    Console.WriteLine("Subarray found from index " + (startIndex + 1) + " to " + i);
                }

                map[sum].Add(i);
            }
            else
            {
                map[sum] = new List<int> { i };
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4 };

        ZeroSumSubarrays.FindAllZeroSumSubarrays(arr);
    }
}

