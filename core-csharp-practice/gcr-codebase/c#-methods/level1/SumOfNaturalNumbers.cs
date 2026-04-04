using System;

class SumOfNaturalNumbers
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSum(n);

        Console.WriteLine("Sum of first " + n + " natural numbers is: " + sum);
    }

    // Method to calculate sum using loop
    static int CalculateSum(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}
