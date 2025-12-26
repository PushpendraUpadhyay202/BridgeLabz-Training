using System;

public class UnitConvertor
{
    static void Main()
    {
        Console.WriteLine("10 km in miles: " + UnitConvertor.ConvertKmToMiles(10));
        Console.WriteLine("5 miles in km: " + UnitConvertor.ConvertMilesToKm(5));
        Console.WriteLine("3 meters in feet: " + UnitConvertor.ConvertMetersToFeet(3));
        Console.WriteLine("10 feet in meters: " + UnitConvertor.ConvertFeetToMeters(10));
    }

    // a. Kilometers to Miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // b. Miles to Kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // c. Meters to Feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // d. Feet to Meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}
