using System;
using System.Text.RegularExpressions;

class EmailAddressExtraction
{
    static void Main()
    {
        string s = Console.ReadLine();
        foreach (Match m in Regex.Matches(s, @"[\w.-]+@[\w.-]+\.\w+"))
            Console.WriteLine(m.Value);
    }
}
