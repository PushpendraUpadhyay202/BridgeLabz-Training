using System;
using System.Collections.Generic;

class GenerateBinaryNumbers
{
    static void Main(string[] args)
    {
        int n = 5;

        List<string> binaries = GenerateBinary(n);

        PrintList(binaries);
    }

    static List<string> GenerateBinary(int n)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            result.Add(current);

            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }

        return result;
    }

    static void PrintList(List<string> list)
    {
        foreach (string el in list)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine("\n");
    }
}
