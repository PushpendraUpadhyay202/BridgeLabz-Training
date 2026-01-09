using System;

class SortExamScores
{
    static void Main()
    {
        int[] scores = { 88, 72, 95, 60, 83 };

        for (int i = 0; i < scores.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < scores.Length; j++)
            {
                if (scores[j] < scores[minIndex])
                    minIndex = j;
            }

            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }

        foreach (int score in scores)
            Console.Write(score + " ");
    }
}

