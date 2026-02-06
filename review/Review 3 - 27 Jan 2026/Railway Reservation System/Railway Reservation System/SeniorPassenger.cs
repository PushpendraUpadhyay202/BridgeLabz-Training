using System;
using System.Collections.Generic;
using System.Text;

namespace Railway_Reservation_System
{
    internal class SeniorPassenger : Passenger
    {
        public SeniorPassenger(int pnr, string name, int age, double distance): base(pnr, name, age, distance)
        {

        }

        public override double CalculateFare()
        {
            double totalFare = Distance * RatePerKm;
            return totalFare * 0.70; // Senior Citizen should has 30% discount

        }
    }
}
