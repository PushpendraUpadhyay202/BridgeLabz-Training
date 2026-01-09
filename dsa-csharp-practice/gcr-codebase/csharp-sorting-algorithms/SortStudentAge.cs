using System;

class SortStudentAge
{
    static void Main()
    {
        int[] ages = { 12, 15, 10, 18, 14, 12, 16, 10, 13 };
        int min = 10;
        int max = 18;

        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++)
            count[ages[i] - min]++;

        for (int i = 1; i < count.Length; i++)
            count[i] += count[i - 1];

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            int age = ages[i];
            output[count[age - min] - 1] = age;
            count[age - min]--;
        }

        foreach (int age in output)
            Console.Write(age + " ");
    }
}

