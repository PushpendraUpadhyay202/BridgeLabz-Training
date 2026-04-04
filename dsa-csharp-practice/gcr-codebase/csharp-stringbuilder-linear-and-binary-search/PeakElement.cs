using System;

class PeakElement
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int left = 0;
        int right = n - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        Console.WriteLine("Peak element index: " + left);
        Console.WriteLine("Peak element value: " + arr[left]);
    }
}

