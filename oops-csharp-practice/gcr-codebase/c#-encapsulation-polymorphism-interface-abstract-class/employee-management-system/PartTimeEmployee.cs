using System;
internal class PartTimeEmployee: Employee
{
    private int workHours;
    private int hourlyWage;
    public PartTimeEmployee(int workHours, int hourlyWage, string employeeName) : base(Employee.GetId(), employeeName, hourlyWage)
    {
        this.workHours = workHours;
        this.hourlyWage = hourlyWage;
    }

    public override double CalculateSalary()
    {
        return workHours * hourlyWage;
    }
}