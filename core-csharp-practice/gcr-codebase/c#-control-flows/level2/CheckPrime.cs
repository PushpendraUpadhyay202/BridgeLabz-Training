using System;
public class CheckPrime
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it is a prime number:");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("Please enter a number greater than 1.");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine(number + " is a Prime Number");
        }
        else
        {
            Console.WriteLine(number + " is not a Prime Number");
        }
    }
}