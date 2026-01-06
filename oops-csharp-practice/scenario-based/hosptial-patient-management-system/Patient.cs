using System;
internal class Patient
{
    private static int id = 1;

    private readonly int patientId;
    private string patientName;
    private Doctor assignedDoctor;
    private DateTime admitDate;
    private string diagnosis;

    public Patient(string patientName, Doctor assignedDoctor, string diagnosis)
    {
        this.patientId = id++;
        this.patientName = patientName;
        this.assignedDoctor = assignedDoctor;
        this.admitDate = DateTime.Now;
        this.diagnosis = diagnosis;
    }
    public int GetPatientId()
    {
        return patientId;
    }
    public string GetPatientName()
    {
        return patientName;
    } 
    public Doctor GetAssignedDoctor()
    {
        return assignedDoctor;
    }
    public void SetPatientName(string patientName)
    {
        this.patientName = patientName;
    }
    public void SetAssignedDoctor(Doctor assignedDoctor)
    {
        this.assignedDoctor = assignedDoctor;
    }
    public override string ToString()
    {
        return $"\nPatient Id: {patientId}\nPatient Name: {patientName}\nDiagnosis: {diagnosis}\nAssigned Doctor: {assignedDoctor.GetDoctorName()}\nAdmit Date: {admitDate}";
    }
}