using System;

class DigitFrequency
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine()); //take input

        int[] frequency = new int[10];

        while (number != 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digit "+ i +" : " + frequency[i]);
        }
            
    }
}
