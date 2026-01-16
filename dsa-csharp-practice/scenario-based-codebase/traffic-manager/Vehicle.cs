using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Manager
{
    internal class Vehicle
    {
        private string vehicleNumber;
        private string vehicleType;
        private string vehicleMake;
        private string vehicleModel;

        public Vehicle(string vehicleNumber, string vehicleType, string vehicleMake, string vehicleModel)
        {
            this.vehicleNumber = vehicleNumber;
            this.vehicleType = vehicleType;
            this.vehicleMake = vehicleMake;
            this.vehicleModel = vehicleModel;
        }

        // Getters and Setters methods
        public string GetVehicleNumber()
        {
            return vehicleNumber;
        }

        public void SetVehicleNumber(string vehicleNumber)
        {
            this.vehicleNumber = vehicleNumber;
        }

        public string GetVehicleType()
        {
            return vehicleType;
        }

        public void SetVehicleType(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string GetVehicleMake()
        {
            return vehicleMake;
        }

        public void SetVehicleMake(string vehicleMake)
        {
            this.vehicleMake = vehicleMake;
        }

        public string GetVehicleModel()
        {
            return vehicleModel;
        }

        public void SetVehicleModel(string vehicleModel)
        {
            this.vehicleModel = vehicleModel;
        }

        public override string ToString()
        {
            return $"\nVehicle Number: {vehicleNumber}\nVehicle Type: {vehicleType}\nVehicle Make: {vehicleMake}\nVehicle Model: {vehicleModel}\n";
        }
    }
}
