using System;
public class AbundantNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it is an Abundant Number:");
        int number = int.Parse(Console.ReadLine());
        int sumOfDivisors = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sumOfDivisors += i;
            }
        }

        if (sumOfDivisors > number)
        {
            Console.WriteLine(number + " is an Abundant Number");
        }
        else
        {
            Console.WriteLine(number + " is not an Abundant Number");
        }
    }
}