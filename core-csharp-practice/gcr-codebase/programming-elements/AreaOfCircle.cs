using System;

public class AreaOfCircle{
    public static void Main(string[] args){
        Console.WriteLine("Enter radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine("The area of the circle with radius " + radius + " is: " + area);
    }
}