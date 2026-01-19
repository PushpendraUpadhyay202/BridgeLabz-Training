using System;
using System.Collections.Generic;
using System.Text;

namespace Parcel_Tracker
{
    class ParcelUtility : IParcel
    {
        private static Stage[] stages;
        private static int stagesIndex;

        static ParcelUtility()
        {
            stagesIndex = 4;
            stages = new Stage[stagesIndex];
            stages[0] = new Stage("Packed");
            stages[1] = new Stage("Shipped");
            stages[2] = new Stage("In Transit");
            stages[3] = new Stage("Delivered");
        }

        public void AddParcel()
        {
            Console.WriteLine("\n==== PARCEL ADDING WINDOW ====\n");
            Console.Write("Enter parcel name: ");
            string parcelName = Console.ReadLine();
            Console.Write("Enter parcel delivery address: ");
            string parcelDeliveryAddress = Console.ReadLine();
            Console.WriteLine("\n");

            Parcel parcel = new Parcel(parcelName, parcelDeliveryAddress);

            // When a new parcel is added, it it added in the Packed stage
            stages[0].GetParcels().InsertAtEnd(parcel);
            Console.WriteLine("\nParcel added successfully to the Packed stage.\n");
        }

        public void DisplayAllParcels()
        {
            Console.WriteLine("\n==== PARCELS ACCROSS ALL STAGES ====\n");
            for (int i = 0; i < stagesIndex; i++)
            {
                Console.WriteLine(stages[i].GetStageName());
                Console.WriteLine("=========================================\n");
                stages[i].GetParcels().PrintList();
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }

        public void ForwardAParcel()
        {
            Console.WriteLine("\n==== PARCEL FORWARD WINDOW ====\n");
            Console.Write("Enter parcel id: ");
            int parcelId = int.Parse(Console.ReadLine());

            int parcelStageIndex = ParcelStageIndex(parcelId);

            if (parcelStageIndex == -1)
            {
                Console.WriteLine("\nParcel with this parcel id doesn't exist.\n");
                return;
            }

            if (parcelStageIndex == stagesIndex - 1)
            {
                Console.WriteLine("\nParcel already deliverd\n");
                return;
            }

            // Extracting parcel
            Parcel parcel = stages[parcelStageIndex].GetParcels().FindParcelById(parcelId);
            // Removing parcel from the current stage
            stages[parcelStageIndex].GetParcels().RemoveByParcelId(parcelId);

            // Forwarding parcel to next stage.
            stages[parcelStageIndex + 1].GetParcels().InsertAtEnd(parcel);

            Console.Write("\nForwarded parcel to");
            if (parcelStageIndex == 0) Console.WriteLine(" Shipped Stage.\n");
            else if (parcelStageIndex == 1) Console.WriteLine(" In Transit Stage.\n");
            else Console.WriteLine(" Delivered Stage.\n");
        }

        public void GetParcelStatus()
        {
            Console.WriteLine("\n==== PARCEL STATUS WINDOW ====\n");
            Console.Write("Enter parcel id: ");
            int parcelId = int.Parse(Console.ReadLine());

            int parcelStageIndex = ParcelStageIndex(parcelId);

            if (parcelStageIndex == -1)
            {
                Console.WriteLine("\nParcel with this parcel id doesn't exist.\n");
                return;
            }

            Console.Write("\nThe parcel is currently in");
            if (parcelStageIndex == 0) Console.WriteLine(" Packed Stage.\n");
            else if (parcelStageIndex == 1) Console.WriteLine(" Shipped Stage.\n");
            else if (parcelStageIndex == 2) Console.WriteLine(" In Transit Stage.\n");
            else Console.WriteLine(" Delivered Stage.\n");
        }

        private int ParcelStageIndex(int parcelId)
        {
            for (int i = 0; i < stagesIndex; i++)
            {
                if (stages[i].GetParcels().IsParcelPresent(parcelId)) return i;
            }
            return -1;
        }
    }
}
