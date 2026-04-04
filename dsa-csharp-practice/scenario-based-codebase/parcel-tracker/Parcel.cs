using System;
using System.Collections.Generic;
using System.Text;

namespace Parcel_Tracker
{
    class Parcel
    {
        private static int _idCounter = 0;
        private readonly int _parcelId;
        private string _parcelName;
        private string _parcelDeliveryAddress;

        public Parcel(string parcelName, string parcelDeliveryAddress)
        {
            _parcelId = ++_idCounter;
            _parcelName = parcelName;
            _parcelDeliveryAddress = parcelDeliveryAddress;
        }

        public int GetParcelId()
        {
            return _parcelId;
        }

        public string GetParcelName()
        {
            return _parcelName;
        }

        public string GetParcelDeliveryAddress()
        {
            return _parcelDeliveryAddress;
        }

        public void SetParcelName(string parcelName)
        {
            this._parcelName = parcelName;
        }

        public void SetParcelDeliveryAddress(string parcelDeliveryAddress)
        {
            this._parcelDeliveryAddress = parcelDeliveryAddress;
        }

        public override string ToString()
        {
            return $"\nParcel Id: {_parcelId}\t|\tParcel Name: {_parcelName}\t|\tParcel Delivery Address: {_parcelDeliveryAddress}\n";
        }
    }
}
