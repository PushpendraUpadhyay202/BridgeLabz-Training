using System;

class FizzBuzzUsingArray
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Invalid number");
            return;
        }

        string[] result = new string[num + 1];
        int index = 0;

        while (index <= num)
        {
            if (index == 0)
            {
                result[index] = index.ToString();
            }
            else if (index % 3 == 0 && index % 5 == 0)
            {
                result[index] = "FizzBuzz";
            }
            else if (index % 3 == 0)
            {
                result[index] = "Fizz";
            }
            else if (index % 5 == 0)
            {
                result[index] = "Buzz";
            }
            else
            {
                result[index] = index.ToString();
            }

            index++;
        }

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i + " = " + result[i]);
        }
    }
}
