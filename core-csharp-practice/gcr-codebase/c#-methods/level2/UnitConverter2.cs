using System;

public class UnitConverter2
{
    static void Main()
    {
        Console.WriteLine("10 yards to feet: " + UnitConverter2.ConvertYardsToFeet(10));
        Console.WriteLine("10 feet to yards: " + UnitConverter2.ConvertFeetToYards(10));
        Console.WriteLine("5 meters to inches: " + UnitConverter2.ConvertMetersToInches(5));
        Console.WriteLine("20 inches to meters: " + UnitConverter2.ConvertInchesToMeters(20));
        Console.WriteLine("15 inches to cm: " + UnitConverter2.ConvertInchesToCentimeters(15));
    }

    // a. Convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3; // 1 yard = 3 feet
        return yards * yards2feet;
    }

    // b. Convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333; // 1 foot = 0.333333 yards
        return feet * feet2yards;
    }

    // c. Convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701; // 1 meter = 39.3701 inches
        return meters * meters2inches;
    }

    // d. Convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254; // 1 inch = 0.0254 meters
        return inches * inches2meters;
    }

    // e. Convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54; // 1 inch = 2.54 cm
        return inches * inches2cm;
    }
}
