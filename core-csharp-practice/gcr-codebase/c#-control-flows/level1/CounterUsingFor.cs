using System;
public class CounterUsingFor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to start the countdown:");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Rocket Launched!");
    }
}