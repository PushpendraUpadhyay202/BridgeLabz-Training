using System;
using System.Text.RegularExpressions;

class CreditCardValidation
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.IsMatch(s, @"^(4\d{15}|5\d{15})$") ? "Valid" : "Invalid");
    }
}
