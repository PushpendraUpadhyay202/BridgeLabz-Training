using System;
using HealthClinicApp.Entity;

namespace HealthClinicApp.Interface
{
    public interface IAppointmentService
    {
        void ScheduleAppointment(Appointment appointment);
        void ViewAppointments();
        void UpdateAppointment(Appointment appointment);
        void CancelAppointment(int appointmentId);
    }
}