using System;

class LinearAndBinarySearch
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

        int missing = 1;
        bool found;

        while (true)
        {
            found = false;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == missing)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                break;
            }

            missing++;
        }

        Console.WriteLine("First missing positive integer: " + missing);

        Console.Write("Enter target to search: ");
        int target = int.Parse(Console.ReadLine());

        int left = 0;
        int right = n - 1;
        int index = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("Target found at index: " + index);
        }
        else
        {
            Console.WriteLine("Target not found");
        }
    }
}

