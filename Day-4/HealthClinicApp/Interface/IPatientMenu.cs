using System;
using HealthClinicApp.Entity;

namespace HealthClinicApp.Interface
{
    public interface IPatientService
    {
        void AddPatient(Patient patient);
        void ViewPatients();
        void UpdatePatient(Patient patient);
        void DeletePatient(int patientId);
    }
}