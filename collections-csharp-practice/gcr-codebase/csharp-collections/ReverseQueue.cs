using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(new int[] { 10, 20, 30 });

        Console.Write("Queue before reverse: ");
        PrintQueue(queue);

        Reverse(queue);

        Console.Write("Queue after reverse: ");
        PrintQueue(queue);
    }

    static void Reverse(Queue<int> queue)
    {
        if (queue.Count == 0)
        {
            return;
        }

        int front = queue.Dequeue();
        Reverse(queue);
        queue.Enqueue(front);
    }

    static void PrintQueue(Queue<int> queue)
    {
        foreach (int el in queue)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine("\n");
    }
}
