using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("SA1001", "Gaurav", 50000, "1234"),
            new CurrentAccount("CA2001", "ABC Corp", 150000, "5678")
        };

        ProcessAccounts(accounts);
    }

    static void ProcessAccounts(List<BankAccount> accounts)
    {
        foreach (BankAccount account in accounts)
        {
            double interest = account.CalculateInterest();

            Console.WriteLine(
                $"Account: {account.GetAccountNumber()} | Holder: {account.GetHolderName()}"
            );
            Console.WriteLine($"Balance: {account.GetBalance()}");
            Console.WriteLine($"Calculated Interest: ₹{interest}");

            if (account is ILoanable loanable)
            {
                loanable.ApplyForLoan();
                Console.WriteLine(
                    $"Loan Eligibility Amount: {loanable.CalculateLoanEligibility()}"
                );
            }
        }
    }
}
