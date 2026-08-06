using System;
using HealthClinicApp.Entity;

namespace HealthClinicApp.Interface
{
    public interface IDoctorService
    {
        void AddDoctor(Doctor doctor);
        void ViewDoctors();
        void UpdateDoctor(Doctor doctor);
        void DeleteDoctor(int doctorId);
    }
}