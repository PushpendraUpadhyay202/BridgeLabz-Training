using System;
public class LeapYearUsingSingleIf
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a year to check if it is a Leap Year:");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year");
        }
    }
}