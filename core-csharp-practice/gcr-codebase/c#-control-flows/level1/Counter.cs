using System;
public class Counter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to start the countdown:");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }

        Console.WriteLine("Rocket Launched!");
    }
}