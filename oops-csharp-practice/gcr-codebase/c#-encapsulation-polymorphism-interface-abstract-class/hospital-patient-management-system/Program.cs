using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient(1, "Ramesh", 45, 5, 3000),
            new OutPatient(2, "Sita", 30, 800)
        };

        ProcessPatients(patients);
    }

    static void ProcessPatients(List<Patient> patients)
    {
        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();

            if (patient is IMedicalRecord record)
            {
                record.AddRecord("General Checkup", "No major issues");
                record.ViewRecords();
            }

            double billAmount = patient.CalculateBill();
            Console.WriteLine("Total Bill: " + billAmount);
        }
    }
}
