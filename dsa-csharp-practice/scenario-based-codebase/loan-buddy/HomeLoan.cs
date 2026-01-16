public class HomeLoan : LoanApplication
{
    public HomeLoan(int termMonths, double interestRate) : base(termMonths, interestRate){}

    public override bool ApproveLoan(Applicant applicant)
    {
        if (applicant.GetCreditScore() >= 600)
        {
            SetLoanStatus(true);
            return true;
        }

        return false;
    }
}
