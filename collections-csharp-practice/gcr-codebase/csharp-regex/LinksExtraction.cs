using System;
using System.Text.RegularExpressions;

class LinkExtraction
{
    static void Main()
    {
        string s = Console.ReadLine();
        foreach (Match m in Regex.Matches(s, @"https?://\S+"))
            Console.WriteLine(m.Value);
    }
}
