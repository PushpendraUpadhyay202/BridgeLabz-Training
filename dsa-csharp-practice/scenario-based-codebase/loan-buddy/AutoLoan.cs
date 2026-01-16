public class AutoLoan : LoanApplication
{
    public AutoLoan(int termMonths, double interestRate) : base(termMonths, interestRate){}

    public override bool ApproveLoan(Applicant applicant)
    {
        if (applicant.GetCreditScore() >= 620 && applicant.GetIncome() >= 25000)
        {
            SetLoanStatus(true);
            return true;
        }

        return false;
    }
}
