using System;

public class AddTwoNumbers{
    public static void Main(string[] args){
        Console.WriteLine("Enter first number:");
        int firstnum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int secondnum = int.Parse(Console.ReadLine());

        int sum = firstnum + secondnum;
        Console.WriteLine($"The sum of {firstnum} and {secondnum} is: {sum}");
    }
}