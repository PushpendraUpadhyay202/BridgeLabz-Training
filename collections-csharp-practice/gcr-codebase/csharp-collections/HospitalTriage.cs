using System;
using System.Collections.Generic;

class HospitalTriage
{
    static void Main(string[] args)
    {
        List<Tuple<string, int>> patients = new List<Tuple<string, int>>();

        AddPatient(patients, "John", 3);
        AddPatient(patients, "Alice", 5);
        AddPatient(patients, "Bob", 2);

        TreatPatients(patients);
    }

    static void AddPatient(List<Tuple<string, int>> patients, string name, int severity)
    {
        patients.Add(new Tuple<string, int>(name, severity));
    }

    static void TreatPatients(List<Tuple<string, int>> patients)
    {
        patients.Sort((a, b) => b.Item2.CompareTo(a.Item2));

        foreach (Tuple<string, int> patient in patients)
        {
            Console.WriteLine(patient.Item1);
        }
    }
}
