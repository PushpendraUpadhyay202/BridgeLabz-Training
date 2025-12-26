using System;

class SumOfNaturalNumbers
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        // Check for natural number
        if (n <= 0)
        {
            Console.WriteLine("Invalid input! Please enter a natural number.");
            return;
        }

        int recursiveSum = SumUsingRecursion(n);
        int formulaSum = SumUsingFormula(n);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);

        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("Both computations are correct and equal.");
        }
        else
        {
            Console.WriteLine("Results do not match.");
        }
    }

    // Recursive method to find sum
    public static int SumUsingRecursion(int n)
    {
        if (n == 1)
            return 1;

        return n + SumUsingRecursion(n - 1);
    }

    // Formula method to find sum
    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
