using System;
class CarRental{
	// Attributes
	private string customerName;
	private string carModel;
	private int rentalDays;
	private double perDayCost;

	// Parameterized Constructor
	internal CarRental(string customerName, string carModel, int rentalDays, double perDayCost){
		this.customerName = customerName;
		this.carModel = carModel;
		this.rentalDays = rentalDays;
		this.perDayCost = perDayCost;
	}

	// Method to calculate total cost
	internal void CalculateTotalCost(){
		Console.WriteLine("\nTotal Cost is: " + (this.rentalDays * this.perDayCost));
	}

	static void Main(string[] args){
		CarRental rental1 = new CarRental("Rohit", "Honda Civic", 12, 12);
		rental1.CalculateTotalCost();
	}
}
