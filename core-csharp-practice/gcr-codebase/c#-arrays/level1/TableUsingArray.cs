using System;

class TableUsingArray
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int[] table = new int[11]; // index 1 to 10 will be used

        // Store table values
        for (int i = 1; i <= 10; i++)
        {
            table[i] = num * i;
        }

        // Display table
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + table[i]);
        }
    }
}
