using System;
public class CountOfDigits
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to count its digits:");
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        if (number == 0)
        {
            count = 1; // Special case for 0
        }
        else
        {
            while (number != 0)
            {
                number /= 10;
                count++;
            }
        }

        Console.WriteLine("The number of digits is: " + count);
    }
}