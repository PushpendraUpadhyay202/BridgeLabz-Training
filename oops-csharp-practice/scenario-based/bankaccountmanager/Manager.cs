using System;

public class Manager
{
    public string username;
    public string password;

    public Manager(string user, string pass)
    {
        username = user;
        password = pass;
    }

    public bool Authenticate(string user, string pass)
    {
        return username == user && password == pass;
    }

    public void CreateAccount()
    {
        Console.Write("Account Number: ");
        int accNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Holder Name: ");
        string name = Console.ReadLine();

        Console.Write("Initial Balance: ");
        double bal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Set PIN: ");
        int pin = Convert.ToInt32(Console.ReadLine());

        Bank.accounts[Bank.accountCount] =
            new Account(accNo, name, bal, pin);

        Bank.accountCount++;

        Console.WriteLine("Account Created Successfully!");
    }

    public void UpdateAccount()
    {
        Console.Write("Enter Account Number: ");
        int accNo = Convert.ToInt32(Console.ReadLine());

        Account acc = Bank.FindAccount(accNo);

        if (acc == null)
        {
            Console.WriteLine("Account not found!");
            return;
        }

        Console.WriteLine("1. Update Holder Name");
        Console.WriteLine("2. Update PIN");
        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("New Name: ");
            acc.holderName = Console.ReadLine();
            Console.WriteLine("Name updated!");
        }
        else if (choice == 2)
        {
            Console.Write("New PIN: ");
            acc.pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PIN updated!");
        }
    }

    public void DeleteAccount()
    {
        Console.Write("Enter Account Number to Delete: ");
        int accNo = Convert.ToInt32(Console.ReadLine());
        Bank.DeleteAccount(accNo);
    }

    public void ViewAllAccounts()
    {
        Console.WriteLine("\n--- All Accounts ---");
        for (int i = 0; i < Bank.accountCount; i++)
        {
            Console.WriteLine(
                "AccNo: " + Bank.accounts[i].accountNumber +
                ", Name: " + Bank.accounts[i].holderName +
                ", Balance: " + Bank.accounts[i].balance
            );
        }
    }
}
