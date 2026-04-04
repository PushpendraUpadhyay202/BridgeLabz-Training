using System;

class SpecificWord
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of sentences: ");
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter sentence " + (i + 1) + ": ");
            sentences[i] = Console.ReadLine();
        }

        Console.Write("Enter word to search: ");
        string word = Console.ReadLine();

        int index = -1;


        for (int i = 0; i < n; i++)
        {
            if (sentences[i].Contains(word))
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("First matching sentence found at index " + index + ":");
            Console.WriteLine(sentences[index]);
        }
        else
        {
            Console.WriteLine("No sentence contains the given word.");
        }
    }
}

