using System;

class FactorsUsingArray
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        // Count factors
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        // Store factors in array
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        // Display factors
        for (int i = 0; i < factors.Length; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }
}
