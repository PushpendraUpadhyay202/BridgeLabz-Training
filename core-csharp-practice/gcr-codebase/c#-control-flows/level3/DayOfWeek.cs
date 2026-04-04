using System;
public class DayOfWeek
{
    public static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Please provide exactly three arguments: month, day, and year.");
            return;
        }

        int m = int.Parse(args[0]);
        int d = int.Parse(args[1]);
        int y = int.Parse(args[2]);

        // Adjust year and month for January and February
        if (m < 3)
        {
            m += 12;
            y -= 1;
        }

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        Console.WriteLine(d0);
    }
}