using System;

class LargestSecondLargest
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine()); // take input of the number

        int maxDigit = 10; // mostly for the int limit
        int[] digits = new int[maxDigit]; // arr to store the digits of above number
        int index = 0;

        while (number != 0 && index < maxDigit)
        {
            digits[index] = number % 10;  // getting the last digit of the number
            number /= 10; // delete the ones digit
            index++;  // increment the idx
        }

        int largest = 0, secondLargest = 0;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second Largest digit: " + secondLargest);
    }
}
