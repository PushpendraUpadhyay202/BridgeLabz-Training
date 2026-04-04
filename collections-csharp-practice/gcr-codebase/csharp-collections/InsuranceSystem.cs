using System;
using System.Collections.Generic;

class Policy
{
    public int PolicyNumber;
    public string CoverageType;
    public DateTime ExpiryDate;

    public Policy(int number, string coverage, DateTime expiry)
    {
        PolicyNumber = number;
        CoverageType = coverage;
        ExpiryDate = expiry;
    }
}

class InsuranceSystem
{
    static void Main(string[] args)
    {
        HashSet<int> uniquePolicyNumbers = new HashSet<int>();
        List<Policy> insertionOrder = new List<Policy>();
        SortedSet<Policy> sortedByExpiry = new SortedSet<Policy>(new ExpiryComparer());

        AddPolicy(uniquePolicyNumbers, insertionOrder, sortedByExpiry,
            new Policy(101, "Health", DateTime.Now.AddDays(10)));
        AddPolicy(uniquePolicyNumbers, insertionOrder, sortedByExpiry,
            new Policy(102, "Car", DateTime.Now.AddDays(40)));
        AddPolicy(uniquePolicyNumbers, insertionOrder, sortedByExpiry,
            new Policy(101, "Health", DateTime.Now.AddDays(10))); // duplicate

        Console.WriteLine("All Unique Policies:");
        foreach (Policy p in insertionOrder)
            Console.WriteLine(p.PolicyNumber);

        Console.WriteLine("\nExpiring within 30 days:");
        foreach (Policy p in insertionOrder)
            if ((p.ExpiryDate - DateTime.Now).Days <= 30)
                Console.WriteLine(p.PolicyNumber);

        Console.WriteLine("\nCoverage Type: Health");
        foreach (Policy p in insertionOrder)
            if (p.CoverageType == "Health")
                Console.WriteLine(p.PolicyNumber);
    }

    static void AddPolicy(
        HashSet<int> unique,
        List<Policy> order,
        SortedSet<Policy> sorted,
        Policy policy)
    {
        if (unique.Add(policy.PolicyNumber))
        {
            order.Add(policy);
            sorted.Add(policy);
        }
    }
}

class ExpiryComparer : IComparer<Policy>
{
    public int Compare(Policy a, Policy b)
    {
        int cmp = a.ExpiryDate.CompareTo(b.ExpiryDate);
        if (cmp == 0)
            return a.PolicyNumber.CompareTo(b.PolicyNumber);
        return cmp;
    }
}
