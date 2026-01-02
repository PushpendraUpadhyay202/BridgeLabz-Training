using System;
public class Circle{
	private double radius;

	public Circle(double radius){
		this.radius = radius;
	}

	public void DisplayAreaAndCircumference(){
		double PI = 3.14159;
		double area = PI*this.radius*this.radius;
		double circumference = 2*PI*this.radius;
		Console.WriteLine("\nFollowing are the details of the circle: \n");
		Console.WriteLine("Area: " + area);
		Console.WriteLine("Circumference: " + circumference);
		Console.WriteLine();
	}
}

public class CircleDetailsPresenter{
	public static void Main(string[] args){
		// Creating instances of the Circle class
		Circle circle1 = new Circle(10.34);
		Circle circle2 = new Circle(20.3);


		// Diplaying the details of the circles
		circle1.DisplayAreaAndCircumference();
		circle2.DisplayAreaAndCircumference();
	}
}
