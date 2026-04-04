using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Railway_Reservation_System
{
    internal class RailwayReservationMain
    {
        public static void Main(string[] args)
        {
            PassengerMenu menu = new PassengerMenu();
            menu.Menu();
        }
    }
}
