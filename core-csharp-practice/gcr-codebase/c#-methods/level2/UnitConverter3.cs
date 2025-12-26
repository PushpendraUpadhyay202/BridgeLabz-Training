using System;

public static class UnitConverter3
{
    public static void Main()
    {
        Console.WriteLine("100 Fahrenheit to Celsius: " + UnitConverter3.ConvertFahrenheitToCelsius(100));
        Console.WriteLine("0 Celsius to Fahrenheit: " + UnitConverter3.ConvertCelsiusToFahrenheit(0));
        Console.WriteLine("150 pounds to kilograms: " + UnitConverter3.ConvertPoundsToKilograms(150));
        Console.WriteLine("70 kilograms to pounds: " + UnitConverter3.ConvertKilogramsToPounds(70));
        Console.WriteLine("5 gallons to liters: " + UnitConverter3.ConvertGallonsToLiters(5));
        Console.WriteLine("10 liters to gallons: " + UnitConverter3.ConvertLitersToGallons(10));
    }

    // a. Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    // b. Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    // c. Pounds to Kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = pounds * 0.453592;
        return pounds2kilograms;
    }

    // d. Kilograms to Pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = kilograms * 2.20462;
        return kilograms2pounds;
    }

    // e. Gallons to Liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = gallons * 3.78541;
        return gallons2liters;
    }

    // f. Liters to Gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = liters * 0.264172;
        return liters2gallons;
    }
}
