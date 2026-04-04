using System;

class SumTillZero
{
    static void Main(string[] args)
    {
        double[] numbers = new double[10];
        double total = 0;
        int index = 0;

        while (true)
        {
            double value = double.Parse(Console.ReadLine());

            if (value <= 0)
            {
                break;
            }

            numbers[index] = value;
            total += numbers[index];
            index++;

            if (index == numbers.Length)
            {
                break;
            }
        }

        Console.WriteLine(total);
    }
}
