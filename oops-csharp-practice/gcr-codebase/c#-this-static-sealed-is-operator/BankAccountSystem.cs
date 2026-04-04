using System;

class BankAccount{
    public static string bankName = "Campus Bank";
    private static int totalAccounts = 0;

    public readonly int accountNumber;
    public string accountHolderName;

    public BankAccount(string accountHolderName, int accountNumber){
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        totalAccounts++;
    }

    public static void GetTotalAccounts(){
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    public void ShowDetails(object obj){
        if (obj is BankAccount){
	    Console.WriteLine("\nHere are your bank account details:");	
            Console.WriteLine("Account Holder Name: " + accountHolderName);
	    Console.WriteLine("Account Number: " + accountNumber);
	    Console.WriteLine("Bank Name: " + bankName);
        }
    }
}

class Program{
    static void Main(){
        BankAccount acc = new BankAccount("Rahul", 101);
        acc.ShowDetails(acc);
        BankAccount.GetTotalAccounts();
    }
}

