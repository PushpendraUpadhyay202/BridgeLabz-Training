using System;

public class NumberChecker
{
    // Method to check if a number is positive
    public static bool IsPositive(int num)
    {
        return num >= 0;
    }

    // Method to check if a positive number is even
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    // Method to compare two numbers
    // Returns 1 if num1 > num2, 0 if num1 == num2, -1 if num1 < num2
    public static int Compare(int num1, int num2)
    {
        if (num1 > num2)
            return 1;
        else if (num1 == num2)
            return 0;
        else
            return -1;
    }

    public static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Take user input
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        // Check each number for positive/negative and even/odd
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.Write("Number " + numbers[i] + " is positive");
                if (IsEven(numbers[i]))
                    Console.WriteLine(" and even.");
                else
                    Console.WriteLine(" and odd.");
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is negative.");
            }
        }

        Console.WriteLine();

        // Compare first and last elements
        int comparison = Compare(numbers[0], numbers[numbers.Length - 1]);

        if (comparison == 1)
            Console.WriteLine("The first number (" + numbers[0] + ") is greater than the last number (" + numbers[numbers.Length - 1] + ").");
        else if (comparison == 0)
            Console.WriteLine("The first number (" + numbers[0] + ") is equal to the last number (" + numbers[numbers.Length - 1] + ").");
        else
            Console.WriteLine("The first number (" + numbers[0] + ") is less than the last number (" + numbers[numbers.Length - 1] + ").");
    }
}
