using System;
public class Employee{
	private int id;
	private string name;
	private double salary;

	public Employee(int id, string name, double salary){
		this.id = id;
		this.name = name;
		this.salary = salary;
	}

	public void DisplayDetails(){
		Console.WriteLine("\nFollowing are the details of the employee: \n");
		Console.WriteLine("Name: " + this.name);
		Console.WriteLine("Id: " + this.id);
		Console.WriteLine("Salary: " + this.salary);
		Console.WriteLine("\n");
	}
}

public class EmployeeDetailsPresenter{
	public static void Main(string[] args){
		// Creating and instance of the Employee class
        	Employee employee1 = new Employee(1, "Amit", 25000);
        	Employee employee2 = new Employee(2, "Sumit", 40000);

        	// Displaying employee details
        	employee1.DisplayDetails();
        	employee2.DisplayDetails();
	}
}
