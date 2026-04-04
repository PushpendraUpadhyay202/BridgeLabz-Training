using System;
using System.Text.RegularExpressions;

class LicensePlateValidation
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.IsMatch(s, @"^[A-Z]{2}\d{4}$") ? "Valid" : "Invalid");
    }
}
