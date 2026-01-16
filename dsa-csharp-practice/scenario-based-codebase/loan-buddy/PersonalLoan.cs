public class PersonalLoan : LoanApplication
{
    public PersonalLoan(int termMonths, double interestRate): base(termMonths, interestRate){}

    public override bool ApproveLoan(Applicant applicant)
    {
        if (applicant.GetCreditScore() >= 650 && applicant.GetIncome() >= 30000)
        {
            SetLoanStatus(true);
            return true;
        }

        return false;
    }
}
