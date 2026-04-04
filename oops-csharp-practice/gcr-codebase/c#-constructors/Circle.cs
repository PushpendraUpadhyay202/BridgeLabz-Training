using System;
class Circle{
	// Attribute
	private double radius;

	// Default Constructor with constructor chaining
	internal Circle() : this(5){
		Console.WriteLine("\nDefault Constructor Called\n");
	}

	// Parameterized Constructor
	internal Circle(double radius){
		Console.WriteLine("\nParameterized Constructor Called\n");
		this.radius = radius;
	}

	// Method to display radius
	internal void DisplayRadius(){
		Console.WriteLine("\nRadius: " + this.radius);
	}

	static void Main(string[] args){
		// Creating a Circle instance with default constructor
		Circle circle1 = new Circle();
		// Creating a Circle instance with parameterized constructor
		Circle circle2 = new Circle(10);

		// Displaying their radius
		circle1.DisplayRadius();
		circle2.DisplayRadius();
	}
}
