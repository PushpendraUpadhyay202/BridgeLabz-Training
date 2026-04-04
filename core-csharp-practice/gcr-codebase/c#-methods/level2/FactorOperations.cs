using System;

class FactorOperations
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors of " + number + ":");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        int sum = FindSumOfFactors(factors);
        long product = FindProductOfFactors(factors);
        double sumOfSquares = FindSumOfSquaresOfFactors(factors);

        Console.WriteLine("Sum of factors: " + sum);
        Console.WriteLine("Product of factors: " + product);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }

    // Method to find factors and return as array
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop: count factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        // Second loop: store factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to find sum of factors
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find product of factors
    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find sum of squares of factors
    public static double FindSumOfSquaresOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
}
