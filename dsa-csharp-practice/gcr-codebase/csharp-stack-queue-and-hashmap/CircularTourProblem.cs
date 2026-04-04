using System;
using System.Collections.Generic;

class CircularTour
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        Queue<int> queue = new Queue<int>();

        int start = 0;
        int end = 0;
        int surplus = 0;

        while (queue.Count < n)
        {
            surplus += petrol[end] - distance[end];
            queue.Enqueue(end);

            
            while (surplus < 0 && queue.Count > 0)
            {
                int removed = queue.Dequeue();
                surplus -= petrol[removed] - distance[removed];
                start = removed + 1;
            }

            end = (end + 1) % n;

            
            if (end == 0 && surplus < 0)
                return -1;
        }

        return start;
    }
}

class Program
{
    static void Main()
    {
        int[] petrol = { 6, 3, 7 };
        int[] distance = { 4, 6, 3 };

        int startPoint = CircularTour.FindStartingPoint(petrol, distance);

        if (startPoint == -1)
            Console.WriteLine("No possible circular tour");
        else
            Console.WriteLine("Start at petrol pump index: " + startPoint);
    }
}

