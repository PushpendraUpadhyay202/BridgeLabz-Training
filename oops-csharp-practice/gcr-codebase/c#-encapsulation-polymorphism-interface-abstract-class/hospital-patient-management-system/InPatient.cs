internal class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge): base(patientId, name, age)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public void AddRecord(string diagnosis, string history)
    {
        SetMedicalData(diagnosis, history);
    }

    public void ViewRecords()
    {
        Console.WriteLine(GetMedicalData());
    }
}
