using System;
class Employee{
	protected string name;
	protected int id;
	protected double salary;

	public Employee(string name, int id, double salary){
		this.name = name;
		this.id = id;
		this.salary = salary;
	}

	public virtual void DisplayDetails(){
		Console.WriteLine("\nFollowing are the employee details:");
		Console.WriteLine("Name: " + name);
		Console.WriteLine("Id: " + id);
		Console.WriteLine("Salary: " + salary);
	}
}

class Manager: Employee{
	private int teamSize;

	public Manager(string name, int id, double salary, int teamSize): base(name, id, salary){
		this.teamSize = teamSize;
	}

	public override void DisplayDetails(){
		base.DisplayDetails();
		Console.WriteLine("Team Size: " + teamSize);
	}
}

class Developer: Employee{
	private string programmingLanguage;

	public Developer(string name, int id, double salary, string programmingLanguage): base(name, id, salary){
		this.programmingLanguage = programmingLanguage;
	}

	public override void DisplayDetails(){
		base.DisplayDetails();
		Console.WriteLine("Programming Language: " + programmingLanguage);
	}
}

class Intern: Employee{
	private string internshipDuration;

	public Intern(string name, int id, double salary, string internshipDuration): base(name, id, salary){
		this.internshipDuration = internshipDuration;
	}

	public override void DisplayDetails(){
		base.DisplayDetails();
		Console.WriteLine("Internship Duration: " + internshipDuration);
	}
}

class EmployeeManagementSystem{
	static void Main(string[] args){
		Employee manager = new Manager("Amit", 2, 25000, 10);
		Employee developer = new Developer("Sumit", 3, 15000, "Python");
		Employee intern = new Intern("Rohit", 4, 5000, "4 Weeks");
		
		manager.DisplayDetails();
		developer.DisplayDetails();
		intern.DisplayDetails();
	}
}
