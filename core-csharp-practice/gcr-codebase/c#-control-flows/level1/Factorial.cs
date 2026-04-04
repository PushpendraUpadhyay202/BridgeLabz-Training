using System;
public class Factorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer to find its factorial:");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        int factorial = 1;
        int count = 1;

        while (count <= number)
        {
            factorial *= count;
            count++;
        }

        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}