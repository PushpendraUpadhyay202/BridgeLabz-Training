internal class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(string accountNumber, string holderName, double balance, string pin): base(accountNumber, holderName, balance, pin) { }

    public override double CalculateInterest()
    {
        return balance * 0.04;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for Savings Account.");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 2;
    }
}
