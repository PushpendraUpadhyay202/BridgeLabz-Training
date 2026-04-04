internal class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(int patientId, string name, int age, double consultationFee): base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
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
