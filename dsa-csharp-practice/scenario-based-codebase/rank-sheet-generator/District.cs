using System;
using System.Collections.Generic;
using System.Text;

namespace Rank_Sheet_Generator
{
    internal class District
    {
        private string districtName;
        private Student[] students;
        private int noOfStudents;

        public District(int noOfStudents , string districtName)
        {
            this.noOfStudents = noOfStudents;
            students = new Student[noOfStudents];
            this.districtName = districtName;
        }

        public string GetDistrictName()
        {
            return districtName;
        }

        public int GetNoOfStudents()
        {
            return noOfStudents;
        }

        public Student[] GetStudents()
        {
            return students;
        }
    }
}
