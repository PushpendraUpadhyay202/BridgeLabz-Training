using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Cracker_Simulator
{
    internal interface IPasswordCracker
    {
        void SetPassword();
        void CrackPassword();
    }
}
