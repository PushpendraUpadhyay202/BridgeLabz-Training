using System;
using System.Collections.Generic;
using System.Text;

namespace Parcel_Tracker
{
    class ParcelMain
    {
        static void Main(string[] args)
        {
            ParcelMenu parcleMenu = new ParcelMenu();
            parcleMenu.Menu();
        }
    }
}
