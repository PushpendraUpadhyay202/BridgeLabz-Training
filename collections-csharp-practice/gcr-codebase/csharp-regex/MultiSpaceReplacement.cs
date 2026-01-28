using System;
using System.Text.RegularExpressions;

class MultiSpaceReplacement
{
    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Regex.Replace(s, @"\s+", " "));
    }
}
