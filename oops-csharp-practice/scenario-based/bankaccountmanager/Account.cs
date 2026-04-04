public class Account
{
    public int accountNumber;
    public string holderName;
    public double balance;
    public int pin;

    public Account(int accNo, string name, double bal, int p)
    {
        accountNumber = accNo;
        holderName = name;
        balance = bal;
        pin = p;
    }
}
