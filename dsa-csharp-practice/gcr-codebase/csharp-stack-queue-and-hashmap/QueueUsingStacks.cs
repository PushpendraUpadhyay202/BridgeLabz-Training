using System;
using System.Collections.Generic;

class QueueUsingTwoStacks
{
    private Stack<int> stackEnqueue = new Stack<int>();
    private Stack<int> stackDequeue = new Stack<int>();

    public void Enqueue(int item)
    {
        stackEnqueue.Push(item);
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        if (stackDequeue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }

        return stackDequeue.Pop();
    }

    public bool IsEmpty()
    {
        return stackEnqueue.Count == 0 && stackDequeue.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        QueueUsingTwoStacks queue = new QueueUsingTwoStacks();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 

        queue.Enqueue(40);

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }
}

