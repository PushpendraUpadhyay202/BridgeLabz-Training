using System;
public class Sum
{
    public static void Main(string[] args)
    {
        double total = 0.0;
        double userInput;

        Console.WriteLine("Enter numbers to sum them up (enter 0 to stop):");

        while (true)
        {
            userInput = double.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                break;
            }

            total += userInput;
        }

        Console.WriteLine("The total sum is: " + total);
    }
}