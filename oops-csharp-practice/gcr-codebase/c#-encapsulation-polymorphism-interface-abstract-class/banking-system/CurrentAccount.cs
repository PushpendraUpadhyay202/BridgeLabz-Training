internal class CurrentAccount : BankAccount
{
    public CurrentAccount(string accountNumber, string holderName, double balance, string pin): base(accountNumber, holderName, balance, pin) { }

    public override double CalculateInterest()
    {
        return 0;
    }
}
