using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int[] table = new int[4];
        int index = 0;

        // Store multiplication results from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            table[index] = num * i;
            index++;
        }

        index = 0;

        // Display the multiplication table
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + table[index]);
            index++;
        }
    }
}
