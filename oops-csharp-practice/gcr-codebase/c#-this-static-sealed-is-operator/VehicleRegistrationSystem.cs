using System;

class Vehicle{
    public static double registrationFee = 1500;

    public readonly string registrationNumber;
    public string ownerName;
    public string vehicleType;

    public Vehicle(string ownerName, string vehicleType, string regNumber){
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.registrationNumber = regNumber;
    }

    public static void UpdateRegistrationFee(double fee){
        registrationFee = fee;
    }

    public void ShowVehicle(object obj){
        if (obj is Vehicle){
	    Console.WriteLine("Owner Name: " + ownerName);
	    Console.WriteLine("Vehicle Type: " + vehicleType);
	    Console.WriteLine("Registration Number: " + registrationNumber);
        }
    }
}

class VehicleRegistrationSystem{
    static void Main(string[] args){
        Vehicle v = new Vehicle("Suresh", "Bike", "KA01AB1234");
        v.ShowVehicle(v);
    }
}

