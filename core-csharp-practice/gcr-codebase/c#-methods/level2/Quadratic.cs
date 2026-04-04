using System;

public class Quadratic
{
    // Method to find roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0) // Two distinct real roots
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0) // One real root
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else // delta < 0, no real roots
        {
            return new double[] { }; // empty array
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 2)
        {
            Console.WriteLine("The equation has two real roots: " + roots[0] + " and " + roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The equation has one real root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("The equation has no real roots.");
        }
    }
}
