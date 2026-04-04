using System;
using System.Text.RegularExpressions;

class SsnCheck
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.IsMatch(s, @"^\d{3}-\d{2}-\d{4}$") ? "Valid" : "Invalid");
    }
}
