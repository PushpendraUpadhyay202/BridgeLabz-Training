using System;

class WindChillCalculator
{
    static void Main()
    {
        Console.Write("Enter the temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Enter the wind speed: ");
        double windSpeed = double.Parse(Console.ReadLine());

        double windChill = CalculateWindChill(temp, windSpeed);

        Console.WriteLine("The Wind Chill Temperature is: " + windChill);
    }

    // Method to calculate wind chill temperature
    public static double CalculateWindChill(double temp, double windSpeed)
    {
        double windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);

        return windChill;
    }
}
