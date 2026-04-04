using System;

class AthleteRun
{
    static void Main()
    {
        Console.Write("Enter side 1 of the triangle (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2 of the triangle (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3 of the triangle (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        double rounds = CalculateRounds(side1, side2, side3);

        Console.WriteLine("Number of rounds needed to complete 5 km run: " + rounds);
    }

    // Method to calculate number of rounds
    static double CalculateRounds(double s1, double s2, double s3)
    {
        double perimeter = s1 + s2 + s3;
        double totalDistance = 5000; // meters

        return totalDistance / perimeter;
    }
}
