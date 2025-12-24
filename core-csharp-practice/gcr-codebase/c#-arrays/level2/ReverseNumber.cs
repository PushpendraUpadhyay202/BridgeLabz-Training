using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine()); // taking the input
        int temp = number;
        int count = 0; // sizeof the array 

        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];

        for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        Console.Write("Reversed number: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i]);
        }
    }
}
