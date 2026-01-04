using System;

class BankAccount{
    public int accountNumber;
    protected string accountHolder;
    private float balance;

    internal BankAccount(int accountNumber, string accountHolder, float balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public float GetBalance(){
        return balance;
    }

    public void SetBalance(float balance){
        this.balance = balance;
        Console.WriteLine("\nBalance Updated");
    }

    internal void DisplayAccountDetails(){
        Console.WriteLine("\nGiven below are the bank account details:");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : BankAccount{
    private float interestRate;

    internal SavingsAccount(int accountNumber, string accountHolder, float balance, float interestRate): base(accountNumber, accountHolder, balance){
        this.interestRate = interestRate;
    }

    internal void DisplaySavingsAccountDetails(){
        Console.WriteLine("\nGiven below are the savings account details:");
        Console.WriteLine("Account Number: " + accountNumber);   // public
        Console.WriteLine("Account Holder: " + accountHolder);   // protected
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}

class BankAccountManagement{
    static void Main(string[] args){
        BankAccount account1 = new BankAccount(101, "Amit", 5000.0f);
        SavingsAccount savingsAccount1 = new SavingsAccount(102, "Rohit", 8000.0f, 4.5f);

        account1.DisplayAccountDetails();
        savingsAccount1.DisplaySavingsAccountDetails();

        account1.SetBalance(6000.0f);
        Console.WriteLine("\nCurrent Balance: " + account1.GetBalance());
    }
}
 
