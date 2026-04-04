using System;
public class Percentage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter marks for Physics:");
        int physics = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Chemistry:");
        int chemistry = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Maths:");
        int maths = int.Parse(Console.ReadLine());

        // Calculate total and percentage
        int totalMarks = physics + chemistry + maths;
        double percentage = (totalMarks / 300.0) * 100;

        // Determine grade and remarks
        string grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Excellent";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Very Good";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Good";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Average";
        }
        else
        {
            grade = "F";
            remarks = "Fail";
        }

        // Display results
        Console.WriteLine("Average Mark: " + percentage + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }
}