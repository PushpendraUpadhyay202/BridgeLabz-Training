using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class CountWords
{
    static void Main()
    {
        string filePath = "input.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        StreamReader reader = new StreamReader(filePath);
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line
                .ToLower()
                .Split(new char[] { ' ', '\t', ',', '.', ';', ':', '!', '?', '-', '"', '\'' },
                       StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }
        }

        reader.Close();

        var top5 = wordCount
            .OrderByDescending(x => x.Value)
            .Take(5);

        Console.WriteLine("Top 5 most frequent words:");
        foreach (var entry in top5)
        {
            Console.WriteLine(entry.Key + " : " + entry.Value);
        }
    }
}
