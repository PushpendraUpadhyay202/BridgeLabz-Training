using System;
using System.Collections.Generic;
using System.Text;

namespace Rank_Sheet_Generator
{
    internal interface IGenerator
    {
        void AddDistrict();
        void AddStudent();
        void DisplayStudentsOfAllDistricts();
    }
}
