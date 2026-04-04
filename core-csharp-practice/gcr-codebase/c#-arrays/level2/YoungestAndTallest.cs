using System;

public class YoungestAndTallest
{
    public static void Main(string[] args)
    {
        int numberOfFriends = 3;
        string[] names = {"Amar" , "Akbar" , "Anthony"};
        int[] ages = new int[numberOfFriends];
        double []heights = new double[numberOfFriends];


        for(int i = 0; i < numberOfFriends; i++)
        {
            Console.WriteLine("Enter the age of friend "+ (i+1) + " :");
            ages[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of friend "+ (i+1) + " :");
            heights[i] = double.Parse(Console.ReadLine());
        }

        int youngest = 0;
        int tallest = 0;
        for(int i = 1; i < numberOfFriends; i++)
        {
            if(ages[i] < ages[youngest])
            {
                youngest = i;
            }

            if(heights[i] > heights[tallest])
            {
                tallest = i;
            }
        }

        // Display results
        Console.WriteLine("Youngest Friend : " + names[youngest]);
        Console.WriteLine("Tallest Friend  : " + names[tallest]);
    }
}