using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            Console.WriteLine("Invalid age entered.");
            return false;
        }
        else if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Main(string[] args)
    {
        StudentVoteChecker checker = new StudentVoteChecker();
        int[] studentAges = new int[10];

        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter age of student "+ (i + 1) +" : ");
            bool validInput = int.TryParse(Console.ReadLine(), out studentAges[i]);

            if (!validInput)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer age.");
                i--; // repeat this iteration
                continue;
            }

            bool canVote = checker.CanStudentVote(studentAges[i]);

            if(canVote)
            {
                Console.WriteLine("Student "+ (i + 1) +" can vote.");
            }
            else
            {
                Console.WriteLine("Student "+ (i + 1) +" cannot vote.");
            }
        }
    }
}
