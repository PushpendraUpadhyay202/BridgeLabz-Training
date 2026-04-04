using System;
using System.Text;

class StringBuilderPerformance
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of concatenations: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nRunning string concatenation...");
        string normalString = "";
        for (int i = 0; i < n; i++)
        {
            normalString = normalString + "a";
        }
        Console.WriteLine("Final length (string): " + normalString.Length);

        Console.WriteLine("\nRunning StringBuilder concatenation...");
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }
        Console.WriteLine("Final length (StringBuilder): " + sb.Length);

        Console.WriteLine("\nDone.");
    }
}

