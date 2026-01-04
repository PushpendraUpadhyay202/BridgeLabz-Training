using System;

class BankAccount{
    protected int accountNumber;
    protected double balance;

    public BankAccount(int accountNumber, double balance){
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void DisplayBasicInfo(){
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: ₹" + balance);
    }
}

class SavingsAccount : BankAccount{
    private double interestRate;

    public SavingsAccount(int accountNumber, double balance, double interestRate): base(accountNumber, balance){
        this.interestRate = interestRate;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}

class CheckingAccount : BankAccount{
    private double withdrawalLimit;

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit): base(accountNumber, balance){
        this.withdrawalLimit = withdrawalLimit;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine("Withdrawal Limit: ₹" + withdrawalLimit);
    }
}

class FixedDepositAccount : BankAccount{
    private int tenure;

    public FixedDepositAccount(int accountNumber, double balance, int tenure): base(accountNumber, balance){
        this.tenure = tenure;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine("Tenure: " + tenure + " months");
    }
}

class BankAccountType{
    static void Main(string[] args){
        SavingsAccount savings = new SavingsAccount(1001, 50000, 4.5);
        CheckingAccount checking = new CheckingAccount(1002, 20000, 10000);
        FixedDepositAccount fd = new FixedDepositAccount(1003, 100000, 24);

        savings.DisplayBasicInfo();
        savings.DisplayAccountType();

        Console.WriteLine();

        checking.DisplayBasicInfo();
        checking.DisplayAccountType();

        Console.WriteLine();

        fd.DisplayBasicInfo();
        fd.DisplayAccountType();
    }
}

