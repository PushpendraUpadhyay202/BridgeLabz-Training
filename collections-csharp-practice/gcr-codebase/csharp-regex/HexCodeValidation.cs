using System;
using System.Text.RegularExpressions;

class HexCodeValidation
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.IsMatch(s, @"^#[0-9a-fA-F]{6}$") ? "Valid" : "Invalid");
    }
}
