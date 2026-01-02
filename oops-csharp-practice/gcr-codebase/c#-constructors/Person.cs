using System;
class Person{
	// Attributes
	private string name;
	private int age;
	private string nationality;
	
	// Default Constructor with constructor chaining
	internal Person() : this("Default Human", 0, "No Nationality"){
		Console.WriteLine("\nDefault Constructor called");
	}

	// Parameterized Constructor called
	internal Person(string name, int age, string nationality){
		Console.WriteLine("\nParameterized Constructor Called");
		this.name = name;
		this.age = age;
		this.nationality = nationality;
	}

	// Copy Constructor to clone another person's attributes
	internal Person(Person person){
		Console.WriteLine("\nCopy Constructor Called");
		this.name = person.name;
		this.age = person.age;
		this.nationality = person.nationality;
	}

	// Method to display person details
	internal void DisplayPersonDetails(){
		Console.WriteLine("\nPerson Details: ");
		Console.WriteLine("Name: " + this.name);
		Console.WriteLine("Age: " + this.age);
		Console.WriteLine("Nationality: " + this.nationality);
	}

	// Method to change person's name
	internal void SetName(string name){
		this.name = name;
	}

	static void Main(string[] args){
		// Creating a Person instance with parameterized constructor
		Person person1 = new Person("Vineet", 23, "Indian");
		
		// Creating a clone of person1 with copy constructor
		Person person2 = new Person(person1);
		
		// Displaying their details
		person1.DisplayPersonDetails();
		person2.DisplayPersonDetails();

		// Changing person2's attributes (value types) won't change person1's attributes
		person2.SetName("Amit");

		// Again displaying their details to prove the point
		person1.DisplayPersonDetails();
		person2.DisplayPersonDetails();
	}
}
