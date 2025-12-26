using System;

public class RandomNumbersStats
{
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size)
    {
        int[] numbers = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(1000, 10000); // Generates numbers from 1000 to 9999
        }

        return numbers;
    }

    // Method to find average, min, and max of an array
    public static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;

        return new double[] { average, min, max };
    }

    public static void Main(string[] args)
    {
        int size = 5;
        int[] randomNumbers = Generate4DigitRandomArray(size);

        Console.WriteLine("Generated 4-digit random numbers:");
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.WriteLine(randomNumbers[i]);
        }

        double[] stats = FindAverageMinMax(randomNumbers);

        Console.WriteLine("\nAverage: " + stats[0]);
        Console.WriteLine("Minimum: " + stats[1]);
        Console.WriteLine("Maximum: " + stats[2]);
    }
}
