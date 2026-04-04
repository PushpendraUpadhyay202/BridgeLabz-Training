using System;

public class TestScores
{
    static int size;    // n students
    static int[] scores;   // scores array of n scores
    public static void Main(string[] args)
    {
        GetInput();  // to get input 
        Menu();   // Menu Driven
    }

    // ---------------------------- Function to get Input from the user ------------------------
    private static void GetInput()     
    {
        while (true)
        {
            Console.WriteLine("Enter the number of Students");
            if(int.TryParse(Console.ReadLine() , out size) && size > 0)     // condition to check that size should always be positive
            {
                break;
            }
            Console.WriteLine("Invalid Input! Size must be a positive Integer");  // incase size in not positive number
        }
        
        scores = new int[size];

        for(int i = 0; i < size; i++)
        {
            while (true)
            {
                Console.WriteLine("Enter Score "+ (i+1) + " : ");
                // condition to check that score should always be in between 1 to 100
                if(int.TryParse(Console.ReadLine() , out scores[i]) && scores[i] >= 1 && scores[i] <= 100)
                {
                    break;
                }
                // incase score is out of range
                Console.WriteLine("Invalid Input! Enter a positive Integer between 1 to 100");
            }
        }
    }

    // -------------------------------  MENU ----------------------------------------
    private static void Menu()
    {
        while (true)
        {
            Console.WriteLine("----------------------------MENU-----------------------------");
            Console.WriteLine("1.Calculate and display the average score.");
            Console.WriteLine("2.Find and display the highest and lowest scores.");
            Console.WriteLine("3.Identify and display the scores above the average.");
            Console.WriteLine("4.Exit");

            Console.Write("Choose an Option : ");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Average Score of Given Scores is "+ CalculateAndDisplayAverageScore());
                    break;

                case 2:
                    HighestAndLowestScore();
                    break;

                case 3:
                    IndentifyScoreAboveAverage();
                    break;
                
                case 4:
                    Console.WriteLine("Exiting the Program.......");
                    return;

                default :
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("choose option from 1 to 4 only ");
                    break;
            }
        }
    }

    //------------------------ Function to Calculate and display the average score ---------------
    private static float CalculateAndDisplayAverageScore()
    {
        float total = 0;

        for(int i=0; i<size; i++)
        {
            total += scores[i];
        }

        return total/size;
    }

    // --------------------- Function to  Find and display the highest and lowest scores ------------------
    private static void HighestAndLowestScore()
    {
        int highest = 0;
        int lowest = 100;

        for(int i=0; i<size; i++)
        {
            if(highest < scores[i])
            {
                highest = scores[i];
            }
            if(lowest > scores[i])
            {
                lowest = scores[i];
            }
        }

        Console.WriteLine("Highest Score is "+ highest);
        Console.WriteLine("Lowest Score is "+lowest);
    }

    // ----------------------  Function to  Identify and display the scores above the average---------------------
    private static void IndentifyScoreAboveAverage()
    {
        if(size <= 1)
        {
            Console.WriteLine("There is Only One Element that's why No Element is above Average");
            return;
        }
        float avrg = CalculateAndDisplayAverageScore();

        Console.WriteLine("Scores Above the Average Score are ");
        for(int i=0; i < size; i++)
        {
            if(scores[i] > avrg)
            {
                Console.Write(scores[i]+ " ");
            }
        }
        Console.WriteLine();
    }
}