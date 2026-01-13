using System;
using System.Text;

class StringConcatenation
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of strings: ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string " + (i + 1) + ": ");
            words[i] = Console.ReadLine();
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            result.Append(words[i]);
        }

        Console.WriteLine("Concatenated string: " + result.ToString());
    }
}

