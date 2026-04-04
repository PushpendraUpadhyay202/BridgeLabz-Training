
using System;
class Geometry
{
    public static void Main()
    {
        double x1=double.Parse(Console.ReadLine());
        double y1=double.Parse(Console.ReadLine());
        double x2=double.Parse(Console.ReadLine());
        double y2=double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)));
    }
}
