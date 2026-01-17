using System;
using System.Collections.Generic;
using System.Text;

namespace Steps_Tracker
{
    internal class Person
    {
        private string personName;
        private int personStepCount;

        public Person(string personName, int personStepCount)
        {
            this.personName = personName;
            this.personStepCount = personStepCount;
        }

        public string GetPersonName()
        {
            return personName;
        }

        public int GetPersonStepCount()
        {
            return personStepCount;
        }

        public void SetPersonCount(int count)
        {
            personStepCount = count;
        }

        public override string? ToString()
        {
            return "\nPerson Name : " + personName +
                   "\nPerson Step Count : " + personStepCount;
        }
    }
}
