using System;
using System.Text;

class RemoveDuplicates
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            bool alreadyExists = false;

            for (int j = 0; j < result.Length; j++)
            {
                if (result[j] == currentChar)
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
            {
                result.Append(currentChar);
            }
        }

        Console.WriteLine("String after removing duplicates: " + result.ToString());
    }
}

