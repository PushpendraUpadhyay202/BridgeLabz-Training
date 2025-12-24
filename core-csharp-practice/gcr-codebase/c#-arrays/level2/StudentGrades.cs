using System;

class StudentGrades
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine()); // take number of students

        int[] physics = new int[n]; // physics marks 
        int[] chemistry = new int[n]; // chemistry marks
        int[] maths = new int[n];  // maths marks
        double[] percentage = new double[n];  // percentage array
        char[] grade = new char[n]; // grade array

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the marks of student "+(i+1));
            Console.Write("Physics: ");
            physics[i] = int.Parse(Console.ReadLine());

            Console.Write("Chemistry: ");
            chemistry[i] = int.Parse(Console.ReadLine());

            Console.Write("Maths: ");
            maths[i] = int.Parse(Console.ReadLine());

            percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;

            if (percentage[i] >= 90) grade[i] = 'A';
            else if (percentage[i] >= 75) grade[i] = 'B';
            else if (percentage[i] >= 60) grade[i] = 'C';
            else grade[i] = 'D';
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Percentage: "+ percentage[i] +", Grade: "+ grade[i]);
        }
    }
}
