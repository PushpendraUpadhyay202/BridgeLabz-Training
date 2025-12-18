using System;

public class PerimeterOfRectangle{
    public static void Main(string[] args){
        Console.WriteLine("Enter length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }
}

