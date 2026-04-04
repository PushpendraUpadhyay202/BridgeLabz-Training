using System;
public class Table
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find its multiplication table from 6 to 9:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            int result = number * i;
            Console.WriteLine(number + " * " + i + " = " + result);
        }
    }
}