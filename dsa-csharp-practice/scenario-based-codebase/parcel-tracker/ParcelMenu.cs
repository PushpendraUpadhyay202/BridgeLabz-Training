using System;
using System.Collections.Generic;
using System.Text;

namespace Parcel_Tracker
{
    class ParcelMenu
    {
        private IParcel parcelUtility;

        public void Menu()
        {
            parcelUtility = new ParcelUtility();
            int choice;

            do
            {
                Console.WriteLine("\n===== PARCEL TRACKER ====\n");
                Console.WriteLine("1. Display all parcels across all stages.");
                Console.WriteLine("2. Add a parcel.");
                Console.WriteLine("3. Forward a parcel to the next stage.");
                Console.WriteLine("4. Get Parcel Status.");
                Console.WriteLine("0. Exit");
                Console.Write("Please enter your choice number: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        parcelUtility.DisplayAllParcels();
                        break;
                    case 2:
                        parcelUtility.AddParcel();
                        break;
                    case 3:
                        parcelUtility.ForwardAParcel();
                        break;
                    case 4:
                        parcelUtility.GetParcelStatus();
                        break;
                }

            } while (choice != 0);
        }
    }
}
