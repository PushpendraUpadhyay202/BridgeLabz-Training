using System;
public class EvenOdd
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a natural number to print odd and even numbers up to that number:");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a valid natural number greater than 0.");
            return;
        }

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is an Even number");
            }
            else
            {
                Console.WriteLine(i + " is an Odd number");
            }
        }
    }
}