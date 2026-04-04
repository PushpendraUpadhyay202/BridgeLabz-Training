using System;
public class SumOfNaturalNumbersUsingWhile
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a natural number to find the sum of first n natural numbers:");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number greater than 0.");
            return;
        }

        // Compute sum using while loop
        int sumUsingWhile = 0;
        int count = 1;

        while (count <= n)
        {
            sumUsingWhile += count;
            count++;
        }

        // Compute sum using formula
        int sumUsingFormula = n * (n + 1) / 2;

        // Display results
        Console.WriteLine("Sum using while loop: " + sumUsingWhile);
        Console.WriteLine("Sum using formula: " + sumUsingFormula);

        // Compare results
        if (sumUsingWhile == sumUsingFormula)
        {
            Console.WriteLine("Both computations are correct");
        }
    }
}