using System;

internal abstract class Patient
{
    protected int patientId;
    protected string name;
    protected int age;

    private string diagnosis;
    private string medicalHistory;

    protected Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public int GetPatientId()
    {
        return patientId;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    protected void SetMedicalData(string diagnosis, string history)
    {
        this.diagnosis = diagnosis;
        this.medicalHistory = history;
    }

    protected string GetMedicalData()
    {
        if (diagnosis == null)
            return "No medical records available";

        return "Diagnosis: " + diagnosis + " | History: " + medicalHistory;
    }

    public void GetPatientDetails()
    {
        Console.WriteLine(
            $"ID: {patientId} | Name: {name} | Age: {age}"
        );
    }

    public abstract double CalculateBill();
}
