using System;

public class CalculateSimpleInterest{
    public static void Main(string[] args){
        Console.WriteLine("Enter principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter rate of interest:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter time in years:");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"The simple interest for principal {principal}, rate {rate}%, and time {time} years is: {simpleInterest}");
    }
}