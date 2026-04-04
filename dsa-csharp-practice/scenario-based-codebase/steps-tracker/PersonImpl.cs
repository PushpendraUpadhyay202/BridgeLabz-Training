using System;
using System.Collections.Generic;
using System.Text;

namespace Steps_Tracker
{
    internal class PersonImpl : IPerson
    {
        private Person[] persons;
        private int personIndex;
        public PersonImpl()
        {
            int numberOfPersons = 20;
            persons = new Person[numberOfPersons];
            personIndex = 0;
        }
        public void AddPerson()
        {
            Console.WriteLine("==========   PERSON ADDING WINDOW   ============");
            if(personIndex >= persons.Length)
            {
                Console.WriteLine("\nMaximum Capacity Reached\n");
                return;
            }

            Console.Write("Enter Person Name : ");
            string name  = Console.ReadLine();
            Console.Write("Enter Person Step Count : ");
            int steps = int.Parse(Console.ReadLine());

            Person person = new Person(name, steps);
            persons[personIndex++] = person;

            BubbleSort();
            Console.WriteLine("\nPerson Added Successfully\n");
        }
        public void ShowLeaderBoard()
        {
            Console.WriteLine("\n=============    LEADERBOARD    ================");
            if(personIndex == 0)
            {
                Console.WriteLine("\nNo Person is Added Yet");
                return;
            }
            for(int i=0; i < personIndex; i++)
            {
                Console.WriteLine(persons[i]);
            }
            Console.WriteLine();
        }

        public void UpdateExistingPersonStepCount()
        {
            Console.WriteLine("=============   UPDATE WINDOW FOR STEPS COUNT   =============");
            Console.Write("\nEnter Person Name : ");
            string name = Console.ReadLine();

            Person person = FindPerson(name);

            if(person == null)
            {
                Console.WriteLine("\nNo Person Exists With This Name");
                return;
            }

            Console.Write("Enter Updated Steps Count : ");
            int count = int.Parse(Console.ReadLine());
            person.SetPersonCount(count);

            BubbleSort();
            Console.WriteLine("\nSteps Count Updated\n");

        }

        private Person FindPerson(string name)
        {
            for(int i = 0; i < personIndex; i++)
            {
                if(persons[i].GetPersonName() == name)
                {
                    return persons[i];
                }
            }
            return null;
        }

        private void BubbleSort()
        {
            for(int i=0; i < personIndex - 1; i++)
            {
                for(int j=0; j<personIndex-i-1; j++)
                {
                    if (persons[j].GetPersonStepCount() < persons[j + 1].GetPersonStepCount())
                    {
                        Person temp = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j+1] = temp;
                    }
                }
            }
        }
    }
}
