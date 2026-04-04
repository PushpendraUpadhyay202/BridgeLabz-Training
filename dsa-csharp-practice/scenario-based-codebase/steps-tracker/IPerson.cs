using System;
using System.Collections.Generic;
using System.Text;

namespace Steps_Tracker
{
    internal interface IPerson
    {
        void ShowLeaderBoard();
        void AddPerson();
        void UpdateExistingPersonStepCount();
    }
}