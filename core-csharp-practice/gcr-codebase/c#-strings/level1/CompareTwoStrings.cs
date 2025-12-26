using System;

public class CompareTwoStrings
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first string: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string: ");
        string str2 = Console.ReadLine();

        bool isEqual = Compare(str1 , str2);

        if (isEqual)
        {
            Console.WriteLine("Both Strings are equal");
        }
        else
        {
            Console.WriteLine("Both Strings are different");
        }

        bool isEqualUsingBuildInFun = str1.Equals(str2);

        if(isEqual == isEqualUsingBuildInFun)
        {
            Console.WriteLine("Iteration method and Equals() method have same results");
        }
        else
        {
            Console.WriteLine("Both have Different results");
        }

    }

    public static bool Compare(string str1 , string str2)
    {
        if(str1.Length != str2.Length)
        {
            return false;
        }

        for(int i=0; i<str1.Length; i++)
        {
            if(str1[i] != str2[i])
            {
                return false;
            }
        }

        return true;
    }
}