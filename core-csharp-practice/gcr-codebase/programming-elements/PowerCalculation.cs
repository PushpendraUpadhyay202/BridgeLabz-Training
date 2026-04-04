using System;

class PowerCalculation{
    static void Main(){
        Console.Write("Enter base: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("Result: " + result);
    }
}