using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    static void Main()
    {
        string s = Console.ReadLine();
        foreach (Match m in Regex.Matches(s, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase))
            Console.WriteLine(m.Groups[1].Value);
    }
}
