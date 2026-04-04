using System;

class RotationPoint
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

            if (arr[mid] > arr[right])
            {

                left = mid + 1;
            }
            else
            {

                right = mid;
            }
        }

        Console.WriteLine("Rotation point index: " + left);
        Console.WriteLine("Smallest element: " + arr[left]);
    }
}

