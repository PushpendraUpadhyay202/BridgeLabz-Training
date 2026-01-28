using System;
using System.Text.RegularExpressions;

class UserNameValidation
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.IsMatch(s, @"^[A-Za-z][A-Za-z0-9_]{4,14}") ? "Valid" : "Invalid");
    }
}
