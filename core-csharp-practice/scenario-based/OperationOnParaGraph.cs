using System;

public class OperationOnParaGraph
{
    static string input;   // static input variable because everywhere the input para is shared and 
    // replace function can change it directly

    public static void Main(string[] args)
    {
        input = GetInput();  // function to get input
        Menu();   // Menu function is called
    }

    private static string GetInput()
    {
        Console.WriteLine("Enter the ParaGraph: ");
        string userInput = Console.ReadLine();   // taking the input of paragraph
        return userInput;
    }

    // ------------------------     MENU      -----------------------------------
    private static void Menu()
    {
        while (true)  // MENU will run till infinite till user doesn't exit it manually
        {
            Console.WriteLine("-------------------------MENU-------------------------");
            Console.WriteLine("Choose the Option: ");
            Console.WriteLine("1.Count the number of words in the paragraph");
            Console.WriteLine("2.Find and display the longest word");
            Console.WriteLine("3.Replace all occurrences of a specific word with another word (case-insensitive)");
            Console.WriteLine("4.Print the Paragraph");
            Console.WriteLine("5.Exit");

            int option = int.Parse(Console.ReadLine());  // option input

            switch (option)
            {
                case 1:
                    int numberOfWords = Count();    // Function to count the Number of words 
                    Console.WriteLine("Number of Words in this Paragraph : " + numberOfWords);
                    break;

                case 2:
                    string longestWord = FindLongestWord();  // Function to Find the Longest Word
                    Console.WriteLine("Longest Word of this Paragraph is  " + longestWord + " with length " + longestWord.Length);
                    break;

                case 3:
                    Console.WriteLine("Enter the word to be Replaced : ");
                    string findWord = Console.ReadLine();    // find
                    Console.WriteLine("Enter the word to Replace with : ");
                    string replaceWith = Console.ReadLine();  // replace with
                    Replace(findWord , replaceWith);
                    Console.WriteLine(findWord + " is replaced from " + replaceWith);
                    break;

                case 4:
                    PrintParagraph();     // Printing the Paragraph
                    break;

                case 5:
                    Console.WriteLine("Exiting Program....");   // Option to Exit the Program
                    return;

                default:     // Invalid Input Option
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Enter the Option only from 1 to 3 Only");
                    break;
            }
        }
    }

    // -------------------------- to count the Number of words --------------------------
    private static int Count()
    {
        int count = 0;
        bool inWord = false;

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (Letter(ch))
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return count;
    }

    // -------------------- To Check the char is a Letter or Not------------------------
    private static bool Letter(char ch)
    {
        if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
        {
            return true;
        }
        return false;
    }

    // ----------------------- ---   to Find the Longest Word -------------------------------
    private static string FindLongestWord()
    {
        string curr = "";
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (Letter(ch))
            {
                curr += ch;
            }
            else
            {
                result = LongestUpdate(curr, result);     // function to compare the curr word and last longestword
                curr = "";
            }
        }

        result = LongestUpdate(curr, result);   // if the last word of para is longest

        return result;

    }

    //-------------------------  To compare the curr word and last longestword ------------------------
    private static string LongestUpdate(string curr, string result)
    {
        if (curr.Length > result.Length)
        {
            return curr;
        }
        return result;
    }

    //-------------------------- To print the Paragraph ----------------------------
    private static void PrintParagraph()
    {
        
        Console.WriteLine("Paragraph is ");
        Console.WriteLine(input);
    }

    // ---------------------- To Replace the existing word with new word ---------------------
    private static void Replace(string findWord , string replaceWith)
    {
        string[] words = input.Split(' ');

        for(int i=0; i<words.Length; i++)
        {
            if (words[i].Equals(findWord))
            {
                words[i] = replaceWith;
            }
        }

        input = string.Join(" ",words);
    }
}