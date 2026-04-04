using System;

class ReturnAllChars
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the String: ");
        string str = Console.ReadLine();

        char[] manual = WithoutUsingFun(str);
        char[] buildIn = str.ToCharArray();

        Console.WriteLine("\nCharacters without ToCharArray():");
        foreach(char c in manual)
        {
            Console.Write(c+" ");
        }

        Console.WriteLine("\nCharacters Using ToCharArray():");
        foreach(char c in buildIn)
        {
            Console.Write(c+" ");
        }

        bool areEqual = true;
        for(int i = 0; i < str.Length; i++)
        {
            if(manual[i] != buildIn[i])
            {
                areEqual = false;
                break;
            }
        }

        
        Console.WriteLine("\nAre Both results are same? "+ areEqual);

    }

    static char[] WithoutUsingFun(string str)
    {
        char[] result = new char[str.Length];

        for(int i = 0; i < str.Length; i++)
        {
            result[i] = str[i];
        }
        return result;
    }
}