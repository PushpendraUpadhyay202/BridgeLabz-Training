using System;

class Matrix
{
    public static void Main()
    {
        // Define a 2x2 matrix
        int[,] matrix = 
        {
            { 1, 2 },
            { 3, 4 }
        };

        // Calculate the determinant: det = ad - bc
        int determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        // Display the matrix
        Console.WriteLine("Matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Display the determinant
        Console.WriteLine("\nDeterminant of the matrix: " + determinant);
    }
}
