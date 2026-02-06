using System;
using System.Collections.Generic;
using System.Text;

namespace Railway_Reservation_System
{
    internal class NormalPassenger : Passenger
    {
        public NormalPassenger(int pnr, string name, int age, double distance): base(pnr, name, age, distance)
        {

        }

        public override double CalculateFare()
        {
            return Distance * RatePerKm;
        }
    }
}
