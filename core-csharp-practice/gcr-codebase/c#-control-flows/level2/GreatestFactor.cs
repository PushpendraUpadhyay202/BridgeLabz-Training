using System;

class GreatestFactor
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int greatestFactor = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                greatestFactor = Math.Max(greatestFactor, i);
            }
        }

        Console.WriteLine(greatestFactor);
    }
}
