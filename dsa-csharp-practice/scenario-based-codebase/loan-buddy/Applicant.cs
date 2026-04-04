public class Applicant
{
    private string name;
    private int creditScore;
    private double income;
    private double loanAmount;

    public Applicant(string name, int creditScore, double income, double loanAmount)
    {
        this.name = name;
        this.creditScore = creditScore;
        this.income = income;
        this.loanAmount = loanAmount;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetCreditScore()
    {
        return creditScore;
    }

    public void SetCreditScore(int creditScore)
    {
        this.creditScore = creditScore;
    }

    public double GetIncome()
    {
        return income;
    }

    public void SetIncome(double income)
    {
        this.income = income;
    }

    public double GetLoanAmount()
    {
        return loanAmount;
    }

    public void SetLoanAmount(double loanAmount)
    {
        this.loanAmount = loanAmount;
    }
}
