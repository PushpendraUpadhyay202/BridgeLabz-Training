using System;

class ChocolateDistribution
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        if (numberOfChildren == 0)
        {
            Console.WriteLine("Number of children cannot be zero.");
            return;
        }

        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        Console.WriteLine("Each child will get: " + result[0] + " chocolates");
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }

    // Method to find chocolates per child and remaining chocolates
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;   // chocolates per child
        int remainder = number % divisor;  // remaining chocolates

        return new int[] { quotient, remainder };
    }
}
