using System;
class Vehicle{
	private int maxSpeed;
	private string fuelType;

	public Vehicle(int maxSpeed, string fuelType){
		this.maxSpeed = maxSpeed;
		this.fuelType = fuelType;
	}

	public virtual void DisplayInfo(){
		Console.WriteLine("\nHere's the vehicle info:");
		Console.WriteLine("Max Speed: " + maxSpeed);
		Console.WriteLine("Fuel Type: " + fuelType);
	}
}

class Car: Vehicle{
	private int seatCapacity;

	public Car(int maxSpeed, string fuelType, int seatCapacity): base(maxSpeed, fuelType){
		this.seatCapacity = seatCapacity;
	}

	public override void DisplayInfo(){
		base.DisplayInfo();
		Console.WriteLine("Seat Capacity: " + seatCapacity);
	}
}

class Truck: Vehicle{
	private int payloadCapacity;

	public Truck(int maxSpeed, string fuelType, int payloadCapacity): base(maxSpeed, fuelType){
		this.payloadCapacity = payloadCapacity;
	}

	public override void DisplayInfo(){
		base.DisplayInfo();
		Console.WriteLine("Payload Capacity: " + payloadCapacity + " kg");
	}
}

class Motorcycle: Vehicle{
	private bool hasSideCar;

	public Motorcycle(int maxSpeed, string fuelType, bool hasSideCar): base(maxSpeed, fuelType){
		this.hasSideCar = hasSideCar;
	}

	public override void DisplayInfo(){
		base.DisplayInfo();
		Console.WriteLine("Has Side Car?: " + hasSideCar);
	}
}

class VehicleHierarchy{
	static void Main(string[] args){
		Vehicle car = new Car(200, "diesel", 6);
		Vehicle truck = new Truck(150, "diesel", 5000);
		Vehicle motorcycle = new Motorcycle(350, "petrol", true);

		car.DisplayInfo();
		truck.DisplayInfo();
		motorcycle.DisplayInfo();
	}
}	
