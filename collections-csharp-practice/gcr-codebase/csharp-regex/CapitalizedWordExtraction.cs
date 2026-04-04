using System;
using System.Text.RegularExpressions;

class CapitalizedWordExtraction
{
    static void Main()
    {
        string s = Console.ReadLine();
        foreach (Match m in Regex.Matches(s, @"\b[A-Z][a-z]*\b"))
            Console.WriteLine(m.Value);
    }
}
