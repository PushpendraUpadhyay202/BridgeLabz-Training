using System;

class Program
{
    public static void Main(string[] args)
    {
        Program game = new Program();
        game.LexicalGame();
    }

    private void LexicalGame()
    {
        Console.Write("Enter First Word : ");
        string firstWord = Console.ReadLine();

        Console.Write("Enter Second Word : ");
        string secondWord = Console.ReadLine();

        string revSecWord = ReverseWord(secondWord);

        if (revSecWord.Equals(firstWord))
        {
            string revFirstWord = ReverseWord(firstWord);
            char[] arr = revFirstWord.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if ("aeiou".Contains(arr[i]))
                {
                    arr[i] = '@';
                }
            }

            Console.WriteLine(new string(arr));
        }
        else
        {
            string word = (firstWord + secondWord).ToUpper();
            int countVowel = 0, countCons = 0;
            string firstTwoVowels = "", firstTwoCons = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if ("AEIOU".Contains(word[i]))
                    {
                        countVowel++;
                        if (!firstTwoVowels.Contains(word[i]) && firstTwoVowels.Length < 2)
                        {
                            firstTwoVowels += word[i];
                        }
                    }
                    else
                    {
                        countCons++;
                        if (!firstTwoCons.Contains(word[i]) && firstTwoCons.Length < 2)
                        {
                            firstTwoCons += word[i];
                        }
                    }

                }
            }

            if (countVowel > countCons)
            {
                Console.WriteLine(firstTwoVowels);
            }
            else if (countCons > countVowel)
            {
                Console.WriteLine(firstTwoCons);
            }
            else
            {
                Console.WriteLine("Vowels and Consonants are equal");
            }
        }
    }

    private string ReverseWord(string word)
    {
        char[] chars = word.ToCharArray();
        int left = 0, right = chars.Length - 1;

        while (left < right)
        {
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            left++;
            right--;
        }

        return new string(chars);
    }
}
