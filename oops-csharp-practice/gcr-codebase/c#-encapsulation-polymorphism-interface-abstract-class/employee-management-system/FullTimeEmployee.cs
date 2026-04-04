using System;
internal class FullTimeEmployee: Employee
{
    private double FixedSalary;

    public FullTimeEmployee(double FixedSalary, string employeeName): base(Employee.GetId(), employeeName, FixedSalary)
    {
        this.FixedSalary = FixedSalary;
    }

    public override double CalculateSalary()
    {
        return FixedSalary;
    }
}