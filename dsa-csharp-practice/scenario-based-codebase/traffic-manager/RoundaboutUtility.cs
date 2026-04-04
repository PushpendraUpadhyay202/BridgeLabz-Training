using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Manager
{
    internal class RoundaboutUtility : IRoundabout
    {
        CircularLinkedList roundabout;
        Queue vehicleQueue;

        public RoundaboutUtility()
        {
            roundabout = new CircularLinkedList();
            vehicleQueue = new Queue();
        }

        public void DisplayRoundabout()
        {
            Console.WriteLine("\n==== ROUNDABOUT STATE ====\n");
            if (roundabout.IsEmpty())
            {
                Console.WriteLine("\nRoundabout is currently empty.\n");
            }
            else
            {
                roundabout.PrintList();
                Console.WriteLine("\n");
            }
        }

        public void AddVehicleInRoundabout()
        {
            Console.WriteLine("\n==== ROUNDABOUT VEHICLE MANAGER ====\n");
            Console.Write("Enter vehicle Number: ");
            string vehicleNumber = Console.ReadLine();
            Console.Write("Enter vehicle type: ");
            string vehicleType = Console.ReadLine();
            Console.Write("Enter vehicle make: ");
            string vehicleMake = Console.ReadLine();
            Console.Write("Enter vehicle model: ");
            string vehicleModel = Console.ReadLine();
            Console.WriteLine("\n");

            Vehicle vehicle = new Vehicle(vehicleNumber, vehicleType, vehicleMake, vehicleModel);

            roundabout.InsertAtTail(vehicle);
            Console.WriteLine("\nVehicle added to the roundabout.");
            Console.WriteLine("\nHere's the new roundabout state: ");
            DisplayRoundabout();
        }

        public void RemoveVehicleFromRoundabout()
        {
            Console.WriteLine("\n==== ROUNDABOUT VEHICLE MANAGER ====\n");
            if (roundabout.IsEmpty())
            {
                Console.WriteLine("\nRoundabout is empty right now.\n");
            }
            else
            {
                Vehicle removedVehicle = roundabout.DeleteFromHead();
                Console.WriteLine("\nHere's the vehicle removed from roundabout:");
                Console.WriteLine(removedVehicle);
                Console.WriteLine("\nHere's the new state of the roundabout:");
                DisplayRoundabout();
            }
        }

        public void AddVehicleInQueue()
        {
            Console.WriteLine("\n==== QUEUE VEHICLE MANAGER ====\n");
            Console.Write("Enter vehicle Number: ");
            string vehicleNumber = Console.ReadLine();
            Console.Write("Enter vehicle type: ");
            string vehicleType = Console.ReadLine();
            Console.Write("Enter vehicle make: ");
            string vehicleMake = Console.ReadLine();
            Console.Write("Enter vehicle model: ");
            string vehicleModel = Console.ReadLine();
            Console.WriteLine("\n");

            Vehicle vehicle = new Vehicle(vehicleNumber, vehicleType, vehicleMake, vehicleModel);
            vehicleQueue.Enqueue(vehicle);
            Console.WriteLine("\nVehicle added to the queue....");
        }

        public void RemoveVehicleFromQueue()
        {
            if (vehicleQueue.IsEmpty())
            {
                Console.WriteLine("\nThere are no vehicles in the queue right now.\n");
            }
            else
            {
                Vehicle removedVehicle = vehicleQueue.Dequeue();
                roundabout.InsertAtTail(removedVehicle);

                Console.WriteLine("\nVehicle removed from the queue: ");
                Console.WriteLine(removedVehicle);

                Console.WriteLine("\nVehicle removed from the queue and added to the roundabout.");
                Console.WriteLine("\nHere's the new roundabout state: ");
                DisplayRoundabout();
            }
        }
    }
}
