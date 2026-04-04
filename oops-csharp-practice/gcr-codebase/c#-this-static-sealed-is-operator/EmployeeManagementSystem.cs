using System;

class Employee{
    public static string companyName = "TechNova";
    private static int employeeCount = 0;

    public readonly int id;
    public string name;
    public string designation;

    public Employee(string name, int id, string designation){
        this.name = name;
        this.id = id;
        this.designation = designation;
        employeeCount++;
    }

    public static void DisplayTotalEmployees(){
        Console.WriteLine("Total Employees: " + employeeCount);
    }

    public void PrintDetails(object obj){
        if (obj is Employee){
	    Console.WriteLine("Name: " + name);
	    Console.WriteLine("Designation: " + designation);
	    Console.WriteLine("Company Name: " + companyName);
        }
    }
}

class EmployeeManagementSystem{
    static void Main(string[] args){
        Employee e = new Employee("Ankit", 1, "Developer");
        e.PrintDetails(e);
        Employee.DisplayTotalEmployees();
    }
}
