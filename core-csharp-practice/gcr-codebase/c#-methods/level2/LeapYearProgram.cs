using System;

class LeapYearProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is NOT a Leap Year");
        }
    }

    // Method to check leap year
    static bool IsLeapYear(int year)
    {
        // Condition a: Year must be >= 1582
        if (year < 1582)
        {
            return false;
        }

        // Condition b: Leap year logic
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            return true;
        }

        return false;
    }
}
