namespace HealthClinicApp.Entity
{
    public class Appointment
    {
        public Appointment(int patientId, int doctorId, DateOnly appointmentDate, TimeOnly appointmentTime, string status)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;
            Status = status;
        }

        public Appointment() { }
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        public string Status { get; set; }

    }
}