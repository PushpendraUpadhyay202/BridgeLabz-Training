using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;

    public int WaitingTime;
    public int TurnAroundTime;

    public ProcessNode Next;

    public ProcessNode(int id, int burst, int priority)
    {
        ProcessId = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        WaitingTime = 0;
        TurnAroundTime = 0;
        Next = null;
    }
}

class CircularRoundRobin
{
    private ProcessNode tail;
    private int count;

    private int totalWaitingTime;
    private int totalTurnAroundTime;
    private int completedCount;

    public CircularRoundRobin()
    {
        tail = null;
        count = 0;
        totalWaitingTime = 0;
        totalTurnAroundTime = 0;
        completedCount = 0;
    }

    public void AddProcess(ProcessNode process)
    {
        if (tail == null)
        {
            tail = process;
            tail.Next = tail;
        }
        else
        {
            process.Next = tail.Next;
            tail.Next = process;
            tail = process;
        }
        count++;
    }

    public void RemoveProcess(int processId)
    {
        if (tail == null)
            return;

        ProcessNode curr = tail.Next;
        ProcessNode prev = tail;

        do
        {
            if (curr.ProcessId == processId)
            {
                if (curr == tail && curr.Next == tail)
                {
                    tail = null;
                }
                else
                {
                    prev.Next = curr.Next;
                    if (curr == tail)
                        tail = prev;
                }
                count--;
                return;
            }
            prev = curr;
            curr = curr.Next;
        } while (curr != tail.Next);
    }

    public void DisplayProcesses()
    {
        if (tail == null)
        {
            Console.WriteLine("No processes in queue");
            return;
        }

        ProcessNode temp = tail.Next;
        do
        {
            Console.WriteLine(
                "PID: " + temp.ProcessId +
                " Burst: " + temp.BurstTime +
                " Remaining: " + temp.RemainingTime +
                " Priority: " + temp.Priority
            );
            temp = temp.Next;
        } while (temp != tail.Next);

        Console.WriteLine("--------------------------");
    }

    public void SimulateRoundRobin(int timeQuantum)
    {
        if (tail == null)
            return;

        int currentTime = 0;
        ProcessNode current = tail.Next;

        while (count > 0)
        {
            DisplayProcesses();

            if (current.RemainingTime > timeQuantum)
            {
                current.RemainingTime -= timeQuantum;
                currentTime += timeQuantum;
                current = current.Next;
            }
            else
            {
                currentTime += current.RemainingTime;
                current.RemainingTime = 0;

                current.TurnAroundTime = currentTime;
                current.WaitingTime = current.TurnAroundTime - current.BurstTime;

                totalWaitingTime += current.WaitingTime;
                totalTurnAroundTime += current.TurnAroundTime;
                completedCount++;

                int finishedPid = current.ProcessId;
                current = current.Next;
                RemoveProcess(finishedPid);
            }
        }

        Console.WriteLine("Average Waiting Time: " + (double)totalWaitingTime / completedCount);
        Console.WriteLine("Average Turn Around Time: " + (double)totalTurnAroundTime / completedCount);
    }
}

class RoundRobinSchedulingAlgo
{
    static void Main(string[] args)
    {
        CircularRoundRobin scheduler = new CircularRoundRobin();

        scheduler.AddProcess(new ProcessNode(1, 8, 2));
        scheduler.AddProcess(new ProcessNode(2, 4, 1));
        scheduler.AddProcess(new ProcessNode(3, 9, 3));
        scheduler.AddProcess(new ProcessNode(4, 5, 2));

        int timeQuantum = 3;

        scheduler.SimulateRoundRobin(timeQuantum);
    }
}

