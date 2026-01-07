using System;

class Program
{
    static void Main(string[] args)
    {
        Employee fullTimeEmp = new FullTimeEmployee(50000, "Amit");
        fullTimeEmp.AssignDepartment("IT");

        fullTimeEmp.DisplayDetails();
        Console.WriteLine("Calculated Salary: " + fullTimeEmp.CalculateSalary());

        Employee partTimeEmp = new PartTimeEmployee(80, 500, "Neha");
        partTimeEmp.AssignDepartment("HR");

        partTimeEmp.DisplayDetails();
        Console.WriteLine("Calculated Salary: " + partTimeEmp.CalculateSalary());
    }
}
