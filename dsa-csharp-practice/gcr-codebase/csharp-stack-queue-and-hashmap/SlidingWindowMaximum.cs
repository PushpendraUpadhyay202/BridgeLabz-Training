using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] arr, int k)
    {
        if (arr == null || arr.Length == 0 || k <= 0)
            return new int[0];

        int n = arr.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            
            if (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            
            while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            
            if (i >= k - 1)
            {
                result[i - k + 1] = arr[deque.First.Value];
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        int[] result = SlidingWindowMaximum.MaxSlidingWindow(arr, k);

        foreach (int val in result)
        {
            Console.WriteLine(val);
        }
    }
}

