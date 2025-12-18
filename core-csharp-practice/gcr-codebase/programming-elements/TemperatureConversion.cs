using System;

public class TemperatureConversion
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheitResult = (celsius * 9 / 5) + 32;
        Console.WriteLine("The " + celsius + " celsius is " + fahrenheitResult + " fahrenheit");
    }
}