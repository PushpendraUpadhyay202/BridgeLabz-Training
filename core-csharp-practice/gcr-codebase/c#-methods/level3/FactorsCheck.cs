using System;

class FactorsCheck
{
    public static void Main()
    {
        // Input number from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Get factors of the number
        int[] factors = GetFactors(number);

        // Display factors
        Console.WriteLine("\nFactors of " + number + ": " + string.Join(", ", factors));

        // Calculate sum and product of factors
        int sum = 0;
        long product = 1; // Use long to avoid overflow
        foreach (int factor in factors)
        {
            sum += factor;
            product *= factor;
        }

        // Display sum and product
        Console.WriteLine("Sum of factors: " + sum);
        Console.WriteLine("Product of factors: " + product);
    }

    // Method to find all factors of a number
    static int[] GetFactors(int n)
    {
        int count = 0;

        // Count number of factors
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) count++;
        }

        // Store factors in an array
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) factors[index++] = i;
        }

        return factors;
    }
}
