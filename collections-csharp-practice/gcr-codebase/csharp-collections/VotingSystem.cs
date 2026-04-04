using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main(string[] args)
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
        List<string> voteOrder = new List<string>();

        CastVote(votes, voteOrder, "Alice");
        CastVote(votes, voteOrder, "Bob");
        CastVote(votes, voteOrder, "Alice");
        CastVote(votes, voteOrder, "Charlie");

        Console.WriteLine("Votes (Insertion Order):");
        foreach (string name in voteOrder)
            Console.WriteLine(name);

        Console.WriteLine("\nVote Count:");
        foreach (KeyValuePair<string, int> entry in votes)
            Console.WriteLine(entry.Key + " = " + entry.Value);

        Console.WriteLine("\nSorted Results:");
        SortedDictionary<string, int> sorted = new SortedDictionary<string, int>(votes);
        foreach (KeyValuePair<string, int> entry in sorted)
            Console.WriteLine(entry.Key + " = " + entry.Value);
    }

    static void CastVote(
        Dictionary<string, int> votes,
        List<string> order,
        string candidate)
    {
        order.Add(candidate);

        if (votes.ContainsKey(candidate))
            votes[candidate]++;
        else
            votes[candidate] = 1;
    }
}
