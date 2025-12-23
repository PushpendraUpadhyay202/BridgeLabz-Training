using System;
public class CalculateBonus
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the employee's salary:");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee's years of service:");
        int yearsOfService = int.Parse(Console.ReadLine());

        double bonus = 0;

        if (yearsOfService > 5)
        {
            bonus = salary * 0.05;
        }

        Console.WriteLine("The bonus amount is: " + bonus);
    }
}