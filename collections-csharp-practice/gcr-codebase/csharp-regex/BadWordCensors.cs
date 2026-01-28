using System;
using System.Text.RegularExpressions;

class BadWordCensors
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.Replace(s, @"\b(damn|stupid)\b", "****", RegexOptions.IgnoreCase));
    }
}
