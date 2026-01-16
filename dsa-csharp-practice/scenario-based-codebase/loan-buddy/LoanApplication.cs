public abstract class LoanApplication : IApprovable
{
    protected int termMonths;
    protected double interestRate;
    private bool loanStatus;

    public LoanApplication(int termMonths, double interestRate)
    {
        this.termMonths = termMonths;
        this.interestRate = interestRate;
        loanStatus = false;
    }

    public int GetTermMonths()
    {
        return termMonths;
    }

    public double GetInterestRate()
    {
        return interestRate;
    }

    public abstract bool ApproveLoan(Applicant applicant);

    public virtual double CalculateEMI(double principal, double annualRate, int termMonths)
    {
        double monthlyRate = annualRate / 12 / 100;
        double power = System.Math.Pow(1 + monthlyRate, termMonths);

        return (principal * monthlyRate * power) / (power - 1);
    }

    protected void SetLoanStatus(bool status)
    {
        loanStatus = status;
    }

    public bool GetLoanStatus()
    {
        return loanStatus;
    }
}
