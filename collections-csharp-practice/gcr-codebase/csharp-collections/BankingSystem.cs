using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main(string[] args)
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        Queue<int> withdrawalQueue = new Queue<int>();

        AddAccount(accounts, 101, 5000);
        AddAccount(accounts, 102, 2000);
        AddAccount(accounts, 103, 8000);

        withdrawalQueue.Enqueue(102);
        withdrawalQueue.Enqueue(101);

        ProcessWithdrawals(accounts, withdrawalQueue, 1000);

        Console.WriteLine("Accounts Sorted by Balance:");
        SortedDictionary<double, List<int>> sorted = SortByBalance(accounts);
        foreach (KeyValuePair<double, List<int>> entry in sorted)
            foreach (int acc in entry.Value)
                Console.WriteLine(acc + " = " + entry.Key);
    }

    static void AddAccount(Dictionary<int, double> accounts, int id, double balance)
    {
        if (!accounts.ContainsKey(id))
            accounts[id] = balance;
    }

    static void ProcessWithdrawals(
        Dictionary<int, double> accounts,
        Queue<int> queue,
        double amount)
    {
        while (queue.Count > 0)
        {
            int acc = queue.Dequeue();

            if (accounts.ContainsKey(acc) && accounts[acc] >= amount)
                accounts[acc] -= amount;
        }
    }

    static SortedDictionary<double, List<int>> SortByBalance(
        Dictionary<int, double> accounts)
    {
        SortedDictionary<double, List<int>> sorted =
            new SortedDictionary<double, List<int>>();

        foreach (KeyValuePair<int, double> entry in accounts)
        {
            if (!sorted.ContainsKey(entry.Value))
                sorted[entry.Value] = new List<int>();

            sorted[entry.Value].Add(entry.Key);
        }

        return sorted;
    }
}
