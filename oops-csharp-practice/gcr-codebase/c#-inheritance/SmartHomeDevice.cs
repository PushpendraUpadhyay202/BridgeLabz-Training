using System;

class Device{
    protected string deviceId;
    protected string status;

    public Device(string deviceId, string status){
        this.deviceId = deviceId;
        this.status = status;
    }

    public virtual void DisplayStatus(){
        Console.WriteLine("Device ID: " + deviceId);
        Console.WriteLine("Status: " + status);
    }
}

class Thermostat : Device{
    private double temperatureSetting;

    public Thermostat(string deviceId, string status, double temperatureSetting): base(deviceId, status){
        this.temperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus(){
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + temperatureSetting + "°C");
    }
}

class SmartHomeDevice{
    static void Main(){
        Thermostat livingRoomThermostat = new Thermostat("THERMO-101", "ON", 23.5);
        livingRoomThermostat.DisplayStatus();
    }
}
