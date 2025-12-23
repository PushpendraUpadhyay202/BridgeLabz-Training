using System;

public class HarshadNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it is a Harshad number:");
        int number = int.Parse(Console.ReadLine());
        int sumOfDigits = 0;
        int originalNumber = number;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sumOfDigits += digit;
            originalNumber /= 10;
        }

        if (number % sumOfDigits == 0)
        {
            Console.WriteLine(number + " is a Harshad number");
        }
        else
        {
            Console.WriteLine(number + " is not a Harshad number");
        }
    }
}