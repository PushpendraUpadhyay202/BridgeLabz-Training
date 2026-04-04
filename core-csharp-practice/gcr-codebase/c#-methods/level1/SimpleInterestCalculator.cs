using System;

class SimpleInterestCalculator
{
    // Method to calculate Simple Interest
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        double simpleInterest = (principal * rate * time) / 100;
        return simpleInterest;
    }

    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter Principal Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calling method
        double interest = CalculateSimpleInterest(principal, rate, time);

        // Output
        Console.WriteLine("The Simple Interest is " + interest +" for Principal " + principal +", Rate of Interest " + rate +" and Time " + time);
    }
}
