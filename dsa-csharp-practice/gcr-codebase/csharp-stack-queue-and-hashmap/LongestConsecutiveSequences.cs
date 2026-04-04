using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    public static int FindLongestConsecutive(int[] arr)
    {
        if (arr.Length == 0)
            return 0;

        HashSet<int> set = new HashSet<int>();
        int longest = 0;

        // Store all elements in the set
        for (int i = 0; i < arr.Length; i++)
        {
            set.Add(arr[i]);
        }

        // Check for the start of a sequence
        for (int i = 0; i < arr.Length; i++)
        {
            if (!set.Contains(arr[i] - 1))
            {
                int currentNum = arr[i];
                int currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                if (currentStreak > longest)
                    longest = currentStreak;
            }
        }

        return longest;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };

        int result = LongestConsecutiveSequence.FindLongestConsecutive(arr);

        Console.WriteLine("Length of longest consecutive sequence: " + result);
    }
}

