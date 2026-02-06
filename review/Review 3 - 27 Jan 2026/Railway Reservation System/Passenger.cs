using System;
using System.Collections.Generic;
using System.Text;

namespace Railway_Reservation_System
{
    public abstract class Passenger
    {
            public int PnrNumber;
            public string Name;
            public int Age;
            public double Distance;   // distance in KM

            protected double RatePerKm = 5.0; // fixed fare per KM

            public Passenger(int pnr, string name, int age, double distance)
            {
                PnrNumber = pnr;
                Name = name;
                Age = age;
                Distance = distance;
            }

            // Abstract mwthod for calculate fare
            public abstract double CalculateFare();

            public void PrintDetails()
            {
                Console.WriteLine("\n===============      Passenger Details      ================");
                Console.WriteLine("PNR Number : " + PnrNumber);
                Console.WriteLine("Name       : " + Name);
                Console.WriteLine("Age        : " + Age);
                Console.WriteLine("Distance   : " + Distance + " km");
                Console.WriteLine("Fare       : " + CalculateFare());
            }
    }
}