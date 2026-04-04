using System;
using System.Collections.Generic;

class WordFrequencyCounter
{
    static void Main(string[] args)
    {
        string text = "Hello world, hello Java!";

        Dictionary<string, int> frequency = CountWords(text);

        foreach (KeyValuePair<string, int> entry in frequency)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }

    static Dictionary<string, int> CountWords(string text)
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        text = text.ToLower();

        char[] separators = new char[]
        {
            ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t'
        };

        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (map.ContainsKey(word))
            {
                map[word]++;
            }
            else
            {
                map[word] = 1;
            }
        }

        return map;
    }
}
