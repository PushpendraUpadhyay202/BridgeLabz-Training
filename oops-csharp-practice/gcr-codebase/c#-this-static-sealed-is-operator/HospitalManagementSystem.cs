using System;

class Patient{
    public static string hospitalName = "City Hospital";
    private static int patientCount = 0;

    public readonly int patientID;
    public string name;
    public int age;
    public string ailment;

    public Patient(string name, int age, string ailment, int patientId){
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.patientID = patientId;
        patientCount++;
    }

    public static void GetTotalPatients(){
        Console.WriteLine("Total Patients: " + patientCount);
    }

    public void ShowPatient(object obj){
        if (obj is Patient){
	    Console.WriteLine("Name: " + name);
	    Console.WriteLine("Age: " + age);
	    Console.WriteLine("Ailment: " + ailment);
        }
    }
}

class HospitalManagmentSystem{
    static void Main(string[] args){
        Patient p = new Patient("Amit", 30, "Fever", 9001);
        p.ShowPatient(p);
        Patient.GetTotalPatients();
    }
}
