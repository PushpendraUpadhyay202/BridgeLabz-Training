using System;

class SearchIn2DArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter element [" + i + "," + j + "]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());

        int left = 0;
        int right = rows * cols - 1;
        bool found = false;
        int foundRow = -1;
        int foundCol = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int r = mid / cols;
            int c = mid % cols;

            if (matrix[r, c] == target)
            {
                found = true;
                foundRow = r;
                foundCol = c;
                break;
            }
            else if (matrix[r, c] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (found)
        {
            Console.WriteLine("Target found at row " + foundRow + ", column " + foundCol);
        }
        else
        {
            Console.WriteLine("Target not found");
        }
    }
}

