using System;
using System.Text.RegularExpressions;

class DatesExtraction
{
    static void Main()
    {
        string s = Console.ReadLine();
        foreach (Match m in Regex.Matches(s, @"\b\d{2}/\d{2}/\d{4}\b"))
            Console.WriteLine(m.Value);
    }
}
