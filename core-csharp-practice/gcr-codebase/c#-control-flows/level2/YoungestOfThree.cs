using System;

class YoungestOfThree
{
    static void Main(string[] args)
    {
        int amarAge = int.Parse(Console.ReadLine());
        int akbarAge = int.Parse(Console.ReadLine());
        int anthonyAge = int.Parse(Console.ReadLine());

        int amarHeight = int.Parse(Console.ReadLine());
        int akbarHeight = int.Parse(Console.ReadLine());
        int anthonyHeight = int.Parse(Console.ReadLine());

        // Find youngest
        if (amarAge < akbarAge && amarAge < anthonyAge)
        {
            Console.WriteLine("Youngest : Amar");
        }
        else if (akbarAge < amarAge && akbarAge < anthonyAge)
        {
            Console.WriteLine("Youngest : Akbar");
        }
        else
        {
            Console.WriteLine("Youngest : Anthony");
        }

        // Find tallest
        if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
        {
            Console.WriteLine("Tallest : Amar");
        }
        else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight)
        {
            Console.WriteLine("Tallest : Akbar");
        }
        else
        {
            Console.WriteLine("Tallest : Anthony");
        }
    }
}
