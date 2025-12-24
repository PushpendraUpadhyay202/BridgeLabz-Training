using System;

class NumberOperation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 numbers:");
        int[] numbers = new int[5];

        // Read input values
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("Positive even number");
                }
                else
                {
                    Console.WriteLine("Positive odd number");
                }
            }
            else if (numbers[i] == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negative number");
            }
        }

        // Compare first and last elements
        if (numbers[0] == numbers[numbers.Length - 1])
        {
            Console.WriteLine("First number is equal to last number");
        }
        else if (numbers[0] > numbers[numbers.Length - 1])
        {
            Console.WriteLine("First number is greater than last number");
        }
        else
        {
            Console.WriteLine("First number is less than last number");
        }
    }
}
