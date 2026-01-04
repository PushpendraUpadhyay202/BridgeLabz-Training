using System;
class Vehicle{
	private static float registrationFee = 5000;

	private string ownerName;
	private string vehicleType;

	internal Vehicle(string ownerName, string vehicleType){
		this.ownerName = ownerName;
		this.vehicleType = vehicleType;
	}

	internal void DisplayVehicleDetails(){
		Console.WriteLine("\nHere are the vehicle details: ");
		Console.WriteLine("Owner Name: " + ownerName);
		Console.WriteLine("Vehicle Type: " + vehicleType);
		Console.WriteLine("Registration Fee: " + registrationFee);
	}

	internal static void UpdateRegistrationFee(float updatedRegistrationFee){
		registrationFee = updatedRegistrationFee;
		Console.WriteLine("Registration Fees Updated");
	}
}

class VehicleRegistration{
	static void Main(string[] args){
		Vehicle vehicle1 = new Vehicle("Amit", "Bike");
		Vehicle vehicle2 = new Vehicle("Sumit", "Car");

		vehicle1.DisplayVehicleDetails();
		vehicle2.DisplayVehicleDetails();

		Vehicle.UpdateRegistrationFee(10000);

		vehicle1.DisplayVehicleDetails();
		vehicle2.DisplayVehicleDetails();
	}
}
