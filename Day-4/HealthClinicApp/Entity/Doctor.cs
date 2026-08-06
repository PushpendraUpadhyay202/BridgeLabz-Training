namespace HealthClinicApp.Entity
{
    public class Doctor
    {
        public Doctor(string firstName, string lastName, string speciality, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Speciality = speciality;
            Phone = phone;
        }

        public Doctor(){}

        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Speciality { get; set; }
        public string Phone { get; set; }

    }
}

