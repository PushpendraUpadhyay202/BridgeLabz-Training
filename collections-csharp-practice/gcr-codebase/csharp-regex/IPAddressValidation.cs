using System;
using System.Text.RegularExpressions;

class IPAddressValidation
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.IsMatch(s, @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$") ? "Valid" : "Invalid");
    }
}
