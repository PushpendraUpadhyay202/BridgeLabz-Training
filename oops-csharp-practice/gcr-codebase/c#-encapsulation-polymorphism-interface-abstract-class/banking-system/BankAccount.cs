using System;

internal abstract class BankAccount
{
    protected string accountNumber;
    protected string holderName;
    protected double balance;

    private string pin;

    protected BankAccount(string accountNumber, string holderName, double balance, string pin)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
        this.pin = pin;
    }

    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public string GetHolderName()
    {
        return holderName;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }

    protected bool ValidatePin(string enteredPin)
    {
        return pin == enteredPin;
    }

    public abstract double CalculateInterest();
}
