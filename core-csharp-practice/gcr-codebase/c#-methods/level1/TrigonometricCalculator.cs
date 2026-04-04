using System;

class TrigonometricCalculator
{
    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        double[] result = calculateTrigonometricFunctions(angle);

        Console.WriteLine("Sine value: " + result[0]);
        Console.WriteLine("Cosine value: " + result[1]);
        Console.WriteLine("Tangent value: " + result[2]);
    }

    // Method to calculate trigonometric functions
    public static double[] calculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;

        double sin = Math.Sin(radians);
        double cos = Math.Cos(radians);
        double tan = Math.Tan(radians);

        return new double[] { sin, cos, tan };
    }
}
