using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /):");
        string operation = Console.ReadLine();

        int result = 0;
        bool validOperation = true;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation.");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine("The result is: " + result);
        }
    }
}