using System;
using System.Collections.Generic;

class FrequencyOfElements
{
    static void Main(string[] args)
    {
        string[] fruits = {"apple", "banana", "apple", "orange"};
        Dictionary<string, int> frequency = CountFrequency(fruits);

        foreach(KeyValuePair<string, int> entry in frequency)
        {
            Console.WriteLine(entry.Key + " " + entry.Value);
        }
    }

    static Dictionary<string, int> CountFrequency(string[] fruits)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach(string fruit in fruits)
        {
            if (frequency.ContainsKey(fruit))
            {
                frequency[fruit]++;
            }
            else
            {
                frequency[fruit] = 1;
            }
        }

        return frequency;
    }
}