using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n=== LoanBuddy – Loan Approval System ===");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Credit Score: ");
        int creditScore = int.Parse(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        double income = double.Parse(Console.ReadLine());

        Console.Write("Enter Loan Amount: ");
        double loanAmount = double.Parse(Console.ReadLine());

        Applicant applicant = new Applicant(name, creditScore, income, loanAmount);

        Console.WriteLine("\nChoose Loan Type:");
        Console.WriteLine("1. Personal Loan");
        Console.WriteLine("2. Home Loan");
        Console.WriteLine("3. Auto Loan");
        Console.Write("Choice: ");

        int choice = int.Parse(Console.ReadLine());

        LoanApplication loan = null;

        if (choice == 1)
            loan = new PersonalLoan(36, 12);
        else if (choice == 2)
            loan = new HomeLoan(240, 8);
        else if (choice == 3)
            loan = new AutoLoan(60, 10);
        else
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        bool approved = loan.ApproveLoan(applicant);

        if (approved)
        {
            double emi = loan.CalculateEMI(applicant.GetLoanAmount(), loan.GetInterestRate(), loan.GetTermMonths());

            Console.WriteLine("\nLoan Approved");
            Console.WriteLine("Monthly EMI: " + emi.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("\nLoan Rejected");
        }
    }
}
