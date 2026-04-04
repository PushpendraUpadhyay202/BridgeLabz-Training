using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }

    // Method to check Spring Season
    static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true;
        }

        return false;
    }
}
