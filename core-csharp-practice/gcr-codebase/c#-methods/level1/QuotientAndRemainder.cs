using System;

class QuotientAndRemainder
{
    static void Main()
    {
        Console.Write("Enter the number (dividend): ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return;
        }

        int[] result = FindRemainderAndQuotient(number, divisor);

        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }

    // Method to find quotient and remainder
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }
}
