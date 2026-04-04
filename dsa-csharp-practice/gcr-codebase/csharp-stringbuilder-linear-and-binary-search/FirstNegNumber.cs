using System;

class FirstNegNumber
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

        int index = -1;

        
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("First negative number: " + arr[index]);
            Console.WriteLine("Index: " + index);
        }
        else
        {
            Console.WriteLine("No negative number found.");
        }
    }
}

