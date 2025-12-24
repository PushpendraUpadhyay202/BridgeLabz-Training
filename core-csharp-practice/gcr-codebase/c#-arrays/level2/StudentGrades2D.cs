using System;

class StudentGrades2D
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[,] marks = new int[n, 3];  //2 Dimensional Array
        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the marks of student "+(i+1));
            Console.Write("Physics: ");
            marks[i, 0] = int.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            marks[i, 1] = int.Parse(Console.ReadLine());
            Console.Write("Maths: ");
            marks[i, 2] = int.Parse(Console.ReadLine());

            percentage[i] = (marks[i,0] + marks[i,1] + marks[i,2]) / 3.0;

            if (percentage[i] >= 90) grade[i] = 'A';
            else if (percentage[i] >= 75) grade[i] = 'B';
            else if (percentage[i] >= 60) grade[i] = 'C';
            else grade[i] = 'D';
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Percentage: "+ percentage[i] + ", Grade: "+ grade[i]);
        }
    }
}
