using System;

class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius of the cylinder:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter height of the cylinder:");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * radius * radius * height;

        Console.WriteLine("The volume of the cylinder with radius " 
            + radius + " and height " + height + " is: " + volume);
    }
}
