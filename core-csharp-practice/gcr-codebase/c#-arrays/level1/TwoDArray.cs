using System;

class TwoDArray
{
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[,] matrix = new int[row, col];
        int[] result = new int[row * col];

        // Read 2D array elements
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int index = 0;

        // Convert 2D array to 1D array
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                result[index] = matrix[i, j];
                index++;
            }
        }

        Console.WriteLine();

        // Display 1D array
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
