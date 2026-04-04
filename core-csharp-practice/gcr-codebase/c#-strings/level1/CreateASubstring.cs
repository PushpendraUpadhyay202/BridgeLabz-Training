using System;
class CreateASubstring
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Enter the starting index: ");
        int startingIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end index: ");
        int endingIndex = int.Parse(Console.ReadLine());

        string subString = SubString(str , startingIndex , endingIndex);

        string subStringUsingBuildInFun = str.Substring(startingIndex , endingIndex - startingIndex );

        Console.WriteLine("SubString using str[i] is : " + subString);
        Console.WriteLine("SubString using buildIn Fun is : " + subStringUsingBuildInFun);

        if(string.Equals(subString , subStringUsingBuildInFun))
        {
            Console.WriteLine("Iteration method and Substring() method have same results");
        }
        else
        {
            Console.WriteLine("Results are different");
        }
    }
    static string SubString(string str , int stIdx , int endIdx)
    {
        string result = "";
        for(int i=stIdx ; i<endIdx ; i++)
        {
            result += str[i];
        }

        return result;
    }

}