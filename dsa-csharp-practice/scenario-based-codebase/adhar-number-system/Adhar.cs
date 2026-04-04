using System;
using System.Collections.Generic;
using System.Text;

namespace Adhar_Number_Sorting
{
    internal class Adhar
    {
        private string adharId;
        private string adharName;

        public Adhar(string id , string name)
        {
            adharId = id;
            adharName = name;
        }

        public string GetAdharId()
        {
            return adharId;
        }

        public string GetAdharName()
        {
            return adharName;
        }

        public override string? ToString()
        {
            return "Adhar Id : "+adharId+" Adhar Name : "+adharName;
        }
    }
}
