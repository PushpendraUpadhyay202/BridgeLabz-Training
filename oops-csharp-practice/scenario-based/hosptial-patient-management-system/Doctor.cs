using System;
internal class Doctor
{
    private static int id = 1;

    private readonly int doctorId;
    private string doctorName;
    private List<Patient> patientsUnderTreatment;
    public Doctor(string doctorName)
    {
        this.doctorId = id++;
        this.doctorName = doctorName;
        patientsUnderTreatment = new List<Patient>();
    }
    public int GetDoctorId()
    {
        return doctorId;
    }
    public string GetDoctorName()
    {
        return doctorName;
    }
    public List<Patient> GetPatientsUnderTreatment()
    {
        return patientsUnderTreatment;
    }
    public void SetDoctorName(String doctorName)
    {
        this.doctorName = doctorName;
    }
    public override string ToString()
    {
        return $"\nDoctor Id: {doctorId}\nDoctor Name: {doctorName}";   
    }
}
