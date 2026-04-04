using System;
using System.Text.RegularExpressions;

class CurrencyExtraction
{
    static void Main()
    {
        string s = Console.ReadLine();
        foreach (Match m in Regex.Matches(s, @"\$?\s?\d+\.\d{2}"))
            Console.WriteLine(m.Value.Trim());
    }
}
