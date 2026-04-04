using System;
using System.Collections.Generic;
using System.Text;

namespace Parcel_Tracker
{
    internal class Stage
    {
        private readonly string stageName;
        private ParcelLinkedList parcels;

        public Stage(string stageName)
        {
            stageName = stageName;
            parcels = new ParcelLinkedList();
        }

        public string GetStageName()
        {
            return stageName;
        }

        public ParcelLinkedList GetParcels()
        {
            return parcels;
        }
    }
}
