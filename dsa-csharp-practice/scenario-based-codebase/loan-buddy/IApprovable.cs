public interface IApprovable
{
    bool ApproveLoan(Applicant applicant);
    double CalculateEMI(double principal, double annualRate, int termMonths);
}
