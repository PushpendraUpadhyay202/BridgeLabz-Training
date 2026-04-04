using System;

class EvenOrOdd
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int[] even = new int[num / 2 + 1];
        int[] odd = new int[num / 2 + 1];

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                even[evenCount] = i;
                evenCount++;
            }
            else
            {
                odd[oddCount] = i;
                oddCount++;
            }
        }

        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenCount; i++)
        {
            Console.WriteLine(even[i]);
        }

        Console.WriteLine("\nOdd numbers:");
        for (int i = 0; i < oddCount; i++)
        {
            Console.WriteLine(odd[i]);
        }
    }
}
