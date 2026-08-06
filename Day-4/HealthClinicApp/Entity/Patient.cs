namespace HealthClinicApp.Entity
{
    public class Patient
    {
        public Patient(string firstName, string lastName, DateTime dob, string gender, string phone, string bloodGroup, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
            Gender = gender;
            Phone = phone;
            BloodGroup = bloodGroup;
            Address = address;
        }

        public Patient() { }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
    }
}