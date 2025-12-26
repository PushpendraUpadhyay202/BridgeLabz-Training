using System;

class Marks
{
    public static void Main()
    {
        // Ask user for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        Random random = new Random();

        Console.WriteLine("\nStudent Marks, Total, and Average:\n");
        Console.WriteLine("Physics\tChemistry\tMaths\tTotal\tAverage");

        for (int i = 0; i < numberOfStudents; i++)
        {
            // Generate random marks between 10 and 99 for each subject
            int physics = random.Next(10, 100);   // 100 is exclusive
            int chemistry = random.Next(10, 100);
            int maths = random.Next(10, 100);

            // Calculate total and average
            int total = physics + chemistry + maths;
            double average = total / 3.0;

            // Display results rounded to 2 decimal places
            Console.WriteLine(physics + "\t" + chemistry + "\t\t" + maths + "\t" + total + "\t" + Math.Round(average, 2));
        }
    }
}
