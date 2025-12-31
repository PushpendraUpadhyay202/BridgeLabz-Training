using System;

public class Client
{
    public int accountNumber;
    public int pin;

    public Client(int accNo, int p)
    {
        accountNumber = accNo;
        pin = p;
    }

    public bool Authenticate()
    {
        Account acc = Bank.FindAccount(accountNumber);

        if (acc == null)
            return false;

        return acc.pin == pin;
    }

    public void CheckBalance()
    {
        Account acc = Bank.FindAccount(accountNumber);
        Console.WriteLine("Balance: " + acc.balance);
    }

    public void Deposit()
    {
        Console.Write("Enter deposit amount: ");
        double amt = Convert.ToDouble(Console.ReadLine());

        Account acc = Bank.FindAccount(accountNumber);
        acc.balance += amt;

        Console.WriteLine("Deposit successful!");
    }

    public void Withdraw()
    {
        Console.Write("Enter withdraw amount: ");
        double amt = Convert.ToDouble(Console.ReadLine());

        Account acc = Bank.FindAccount(accountNumber);

        if (acc.balance >= amt)
        {
            acc.balance -= amt;
            Console.WriteLine("Withdrawal successful!");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    // 🔐 NEW FEATURE
    public void ChangePIN()
    {
        Account acc = Bank.FindAccount(accountNumber);

        Console.Write("Enter OLD PIN: ");
        int oldPin = Convert.ToInt32(Console.ReadLine());

        if (acc.pin != oldPin)
        {
            Console.WriteLine("Incorrect OLD PIN!");
            return;
        }

        Console.Write("Enter NEW PIN: ");
        int newPin = Convert.ToInt32(Console.ReadLine());

        acc.pin = newPin;
        pin = newPin; // update session PIN

        Console.WriteLine("PIN changed successfully!");
    }
}
