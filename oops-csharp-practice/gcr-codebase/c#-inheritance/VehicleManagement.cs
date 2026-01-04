using System;

class Vehicle{
    protected string model;
    protected int maxSpeed;

    public Vehicle(string model, int maxSpeed){
        this.model = model;
        this.maxSpeed = maxSpeed;
    }

    public void DisplayInfo(){
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
    }
}

interface Refuelable{
    void Refuel();
}

class ElectricVehicle : Vehicle{
    public ElectricVehicle(string model, int maxSpeed): base(model, maxSpeed) { }

    public void Charge(){
        Console.WriteLine("Charging the electric vehicle...");
    }
}

class PetrolVehicle : Vehicle, Refuelable{
    public PetrolVehicle(string model, int maxSpeed): base(model, maxSpeed) { }

    public void Refuel(){
        Console.WriteLine("Refueling the petrol vehicle...");
    }
}

class VehicleManagement{
    static void Main(string[] args){
        ElectricVehicle ev = new ElectricVehicle("Tesla Model 3", 250);
        PetrolVehicle pv = new PetrolVehicle("Toyota Corolla", 180);

        Console.WriteLine("Electric Vehicle Info:");
        ev.DisplayInfo();
        ev.Charge();

        Console.WriteLine("\nPetrol Vehicle Info:");
        pv.DisplayInfo();
        pv.Refuel();
    }
}

