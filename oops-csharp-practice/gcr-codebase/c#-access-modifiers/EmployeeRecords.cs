using System;

class Employee{
    public int employeeID;
    protected string department;
    private float salary;

    internal Employee(int employeeID, string department, float salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public float GetSalary(){
        return salary;
    }

    public void SetSalary(float salary){
        this.salary = salary;
        Console.WriteLine("\nSalary Updated");
    }

    internal void DisplayEmployeeDetails(){
        Console.WriteLine("\nGiven below are the employee details:");
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + salary);
    }
}

class Manager : Employee{
    private string level;

    internal Manager(int employeeID, string department, float salary, string level): base(employeeID, department, salary){
        this.level = level;
    }

    internal void DisplayManagerDetails(){
        Console.WriteLine("\nGiven below are the manager details:");
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Level: " + level);
    }
}

class EmployeeRecords{
    static void Main(string[] args){
        Employee employee1 = new Employee(201, "IT", 45000.0f);
        Manager manager1 = new Manager(301, "HR", 65000.0f, "Senior");

        employee1.DisplayEmployeeDetails();
        manager1.DisplayManagerDetails();

        employee1.SetSalary(50000.0f);
        Console.WriteLine("\nCurrent Salary: " + employee1.GetSalary());
    }
}

