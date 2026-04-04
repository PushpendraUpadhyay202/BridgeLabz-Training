using System;

class HeightsStats
{
    public static void Main()
    {
        // Number of people
        int numberOfPeople = 11;

        // Array to store heights in cm
        int[] heights = new int[numberOfPeople];

        // Random object to generate random heights
        Random random = new Random();

        // Generate random heights between 150 cm and 250 cm
        for (int i = 0; i < numberOfPeople; i++)
        {
            heights[i] = random.Next(150, 251); // 251 because upper bound is exclusive
        }

        // Display the generated heights
        Console.WriteLine("Generated Heights (in cm):");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine("\n");

        // Find and display the shortest height
        int shortestHeight = FindShortest(heights);
        Console.WriteLine("Shortest Height: " + shortestHeight + " cm");

        // Find and display the tallest height
        int tallestHeight = FindTallest(heights);
        Console.WriteLine("Tallest Height: " + tallestHeight + " cm");

        // Find and display the mean (average) height
        double meanHeight = CalculateMean(heights);
        Console.WriteLine("Average Height: " + meanHeight + " cm");
    }

    // Method to find the shortest height in an array
    static int FindShortest(int[] heights)
    {
        int minHeight = heights[0];
        foreach (int height in heights)
        {
            minHeight = Math.Min(minHeight, height);
        }
        return minHeight;
    }

    // Method to find the tallest height in an array
    static int FindTallest(int[] heights)
    {
        int maxHeight = heights[0];
        foreach (int height in heights)
        {
            maxHeight = Math.Max(maxHeight, height);
        }
        return maxHeight;
    }

    // Method to calculate the mean (average) height
    static double CalculateMean(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return (double)sum / heights.Length;
    }
}
