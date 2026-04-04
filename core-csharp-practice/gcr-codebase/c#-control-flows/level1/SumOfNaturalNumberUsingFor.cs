using System;
public class SumOfNaturalNumberUsingFor
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

        // Compute sum using for loop
        int sumUsingFor = 0;

        for (int i = 1; i <= n; i++)
        {
            sumUsingFor += i;
        }

        // Compute sum using formula
        int sumUsingFormula = n * (n + 1) / 2;

        // Display results
        Console.WriteLine("Sum using for loop: " + sumUsingFor);
        Console.WriteLine("Sum using formula: " + sumUsingFormula);

        // Compare results
        if (sumUsingFor == sumUsingFormula)
        {
            Console.WriteLine("Both computations are correct");
        }
    }
}