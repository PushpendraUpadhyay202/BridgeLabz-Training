using System;

class Calendar
{
    public static void Main()
    {
        // Input month and year from the user
        Console.Write("Enter month number (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        // Month names array (index 1-12)
        string[] monthNames = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun","Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        // Number of days in each month (index 1-12)
        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Adjust February for leap year
        if (IsLeapYear(year))
            daysInMonth[2] = 29;

        // Display month, year, and number of days
        Console.WriteLine("Month: " + monthNames[month]);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Number of Days: " + daysInMonth[month]);
    }

    // Method to check if a year is a leap year
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
