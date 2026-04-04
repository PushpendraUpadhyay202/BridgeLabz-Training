using System;
using System.Collections.Generic;

class InvertDictionary
{
    static void Main(string[] args)
    {
        Dictionary<string, int> input = new Dictionary<string, int>();
        input["A"] = 1;
        input["B"] = 2;
        input["C"] = 1;

        Dictionary<int, List<string>> inverted = Invert(input);

        foreach (KeyValuePair<int, List<string>> entry in inverted)
        {
            Console.Write(entry.Key + " = ");
            PrintList(entry.Value);
        }
    }

    static Dictionary<int, List<string>> Invert(Dictionary<string, int> map)
    {
        Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();

        foreach (KeyValuePair<string, int> entry in map)
        {
            int value = entry.Value;
            string key = entry.Key;

            if (!result.ContainsKey(value))
            {
                result[value] = new List<string>();
            }

            result[value].Add(key);
        }

        return result;
    }

    static void PrintList(List<string> list)
    {
        Console.Write("[");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
            if (i < list.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
