using System;
using System.Collections.Generic;
using System.Text;

namespace Parcel_Tracker
{
    interface IParcel
    {
        void AddParcel();
        void DisplayAllParcels();
        void ForwardAParcel();
        void GetParcelStatus();
    }
}
