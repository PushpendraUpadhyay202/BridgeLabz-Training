using System;

public class SentenceFormatter
{
    public static void Main(string[] args)
    {
        string input = GetInput();   //  function take input return in input variable
        string formattedText = CorrectText(input);  // function to format the text
        PrintFormattedText(formattedText);  // function to print the output
    }

    //--------------------Take Input -----------------------------//
    private static string GetInput()
    {
        Console.WriteLine("Enter a paragraph to be formatted: ");
        string input = Console.ReadLine();
        return input;
    }

    //--------------------Format the Input Text -----------------------------//
    private static string CorrectText(string input)
    {
        string result = "";  // formatted text is stored in result varible
        bool wantSpace = false; // if space is want after a char , 
        // initially first char doesn't want any space that's why it is false initially
        bool wantCapital = true;  // if capitaliation needed , first char of every sentence is always capital

        for(int i=0; i<input.Length; i++)
        {
            char ch = input[i];

            if (Letter(ch))    // if the char is letter then this condition will execute
            {
                result = result + FormatLetter(ch , wantCapital);
                wantCapital = false;
                wantSpace = true;
            }
            else if (Punctuation(ch))   // if the char is punctuation then this condition will execute
            {
                //most important condition : if the result string has more than zero char and the last char of result
                // string is space and after that any punctuation mark come and
                //  remove that last space and add mark then add space
                if(result.Length > 0 && result[result.Length - 1] == ' ')
                {
                    result = result.Substring(0, result.Length - 1);
                }
                result = result + ch + " ";
                wantSpace = false;

                if(EndOfSentence(ch))
                {
                    wantCapital = true;
                }

            }
            else if (Space(ch))     // if the char is space then this condition will execute
            {
                if (wantSpace)
                {
                    result = result + " ";
                    wantSpace = false;
                }
            }
        }

        return result;
    }

    // -------------------- To Check the char is a Letter or Not------------------------
    private static bool Letter(char ch)
    {
        if((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
        {
            return true;
        }
        return false;
    }

    //------------------------To Capitalizing the char if capital needed-----------------------
    private static char FormatLetter(char ch , bool wantCapital)
    {
        if (wantCapital)
        {
            return char.ToUpper(ch);
        }

        return char.ToLower(ch);
    }

    //-------------------------To check the is a Punctuation or Not-------------------
    private static bool Punctuation(char ch)
    {
        if((ch == '.') || (ch == '?') || (ch == '!') || (ch == ','))
        {
            return true;
        }
        return false;
    }

    //----------------------To check is there the End of Sentence----------------------
    private static bool EndOfSentence(char ch)
    {
        if((ch == '?') || (ch == '!') || (ch == '.'))
        {
            return true;
        }
        return false;
    }

    //---------------------------To Add space after any Punctuation---------------------------
    private static bool Space(char ch)
    {
        if(ch == ' ')
        {
            return true;
        }
        return false;
    }
    // ---------------------To print the Output-----------------------------------------------
    private static void PrintFormattedText(string formattedText)
    {
        Console.WriteLine("Formatted Text : ");
        Console.WriteLine(formattedText);
    }
}