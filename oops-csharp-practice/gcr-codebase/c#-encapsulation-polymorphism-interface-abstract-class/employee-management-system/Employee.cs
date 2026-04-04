using System;
internal abstract class Employee: IDepartment
{
    private static int id = 0;

    protected int employeeId;
    protected string employeeName;
    protected double baseSalary;
    protected string department;
    public Employee(int employeeId, string employeeName, double baseSalary)
    {
        this.employeeId = employeeId;
        this.employeeName = employeeName;
        this.baseSalary = baseSalary;
    }

    public abstract double CalculateSalary();
    public void DisplayDetails()
    {
        Console.WriteLine("\nHere are the employee details:\n");
        Console.WriteLine("Employee Id: " + employeeId);
        Console.WriteLine("Employee Name: " + employeeName);
        Console.WriteLine("Base Salary: " + baseSalary);
        Console.WriteLine("Department: " + (department != null ? department : "Not Alloted yet"));
    }

    public static int GetId()
    {
        id++;
        return id;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }
    public string GetDepartment()
    {
        return department;
    }
}