using System;
public class LeapYear
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a year to check if it is a leap year:");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Please enter a year greater than or equal to 1582.");
        }
        else if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }   
    }
}