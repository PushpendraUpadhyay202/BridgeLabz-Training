using System;

public class FriendsChecker
{
    // Method to find the youngest friend
    public static string FindYoungest(string[] names, int[] ages)
    {
        int minAge = ages[0];
        string youngest = names[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                youngest = names[i];
            }
        }

        return youngest;
    }

    // Method to find the tallest friend
    public static string FindTallest(string[] names, double[] heights)
    {
        double maxHeight = heights[0];
        string tallest = names[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                tallest = names[i];
            }
        }

        return tallest;
    }

    public static void Main(string[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input age and height for each friend
        for (int i = 0; i < friends.Length; i++)
        {
            Console.Write("Enter age of " + friends[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + friends[i] + " in cm: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find youngest and tallest
        string youngest = FindYoungest(friends, ages);
        string tallest = FindTallest(friends, heights);

        // Display results
        Console.WriteLine("\nThe youngest friend is: " + youngest);
        Console.WriteLine("The tallest friend is: " + tallest);
    }
}
