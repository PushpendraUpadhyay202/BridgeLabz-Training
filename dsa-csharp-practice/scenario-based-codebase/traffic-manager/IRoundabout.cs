using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Manager
{
    internal interface IRoundabout
    {
        void DisplayRoundabout();
        void AddVehicleInRoundabout();
        void RemoveVehicleFromRoundabout();
        void AddVehicleInQueue();
        void RemoveVehicleFromQueue();
    }
}
