using System;
using System.Text.RegularExpressions;

class LanguagesExtraction
{
    static void Main()
    {
        string s = Console.ReadLine();
        foreach (Match m in Regex.Matches(s, @"\b(Java|Python|JavaScript|Go)\b"))
            Console.WriteLine(m.Value);
    }
}
