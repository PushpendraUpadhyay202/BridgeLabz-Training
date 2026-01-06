using System;
internal class AdminImp : IAdmin
{
    private static string adminId = "admin";
    private static string adminPassword = "admin";
    private static List<Doctor> allDoctors;
    private static List<Patient> allPatients;
    private static List<Bill> allBills;
    static AdminImp()
    {
        allDoctors = new List<Doctor>();
        allPatients = new List<Patient>();
        allBills = new List<Bill>();
    }
    public void AdmitPatient()
    {
        Console.WriteLine("\n=== Patient Admission Menu ===\n");
        Console.Write("Please enter patient's name: ");
        string patientName = Console.ReadLine();
        Console.Write("Please enter patient's diagnosis: ");
        string patientDiagnosis = Console.ReadLine();
        Console.Write("Please enter patient assigned doctor's id: ");
        int doctorId = int.Parse(Console.ReadLine());

        Doctor assignedDoctor = FindDoctorWithId(doctorId);
        if (assignedDoctor != null)
        {
            Patient patient = new Patient(patientName, assignedDoctor, patientDiagnosis);
            allPatients.Add(patient);
            Console.WriteLine("Patient Admitted");
        }
        else
        {
            Console.WriteLine("Doctor with the given doctor id doesn't exist.");
        }

    }

    // Helper method for AdmitPatient
    private Doctor FindDoctorWithId(int doctorId)
    {
        foreach (Doctor doctor in allDoctors)
        {
            if (doctor.GetDoctorId() == doctorId)
            {
                return doctor;
            }
        }
        return null;
    }

    public void RecruitDoctor()
    {
        Console.WriteLine("\n=== Doctor Recruitment ===\n");
        Console.Write("Enter doctor's name: ");
        string doctorName = Console.ReadLine();
        Doctor doctor = new Doctor(doctorName);
        allDoctors.Add(doctor);
        Console.WriteLine("Doctor Recruited Successfully");
    }

    public void GenerateBill()
    {
        Console.WriteLine("\n=== Bill Generator ===\n");
        Console.Write("Enter the patient id to generate patient bill: ");
        int patientId = int.Parse(Console.ReadLine());
        Console.Write("Enter bill amount: ");
        int billAmount = int.Parse(Console.ReadLine());

        Patient billedPatient = FindPatientWithId(patientId);
        if (billedPatient != null)
        {
            Bill bill = new Bill(billedPatient, billAmount);
            allBills.Add(bill);
            Console.WriteLine("Bill generated successfully");
        }
        else
        {
            Console.WriteLine("Patient of with patient id doesn't exist.");
        }
    }

    // Helper method for GenerateBill
    private Patient FindPatientWithId(int patientId)
    {
        foreach (Patient patient in allPatients)
        {
            if (patient.GetPatientId() == patientId)
            {
                return patient;
            }
        }
        return null;
    }
    public bool AuthenticateAdmin()
    {
        Console.WriteLine("\n=== Admin Authentication ===\n");
        Console.Write("Enter your admin id: ");
        string id = Console.ReadLine();
        Console.Write("Enter your admin password: ");
        string password = Console.ReadLine();

        if(adminId.Equals(id) && adminPassword.Equals(password))
        {
            Console.WriteLine("Authentication Successfull...");
            return true;
        }
        Console.WriteLine("Authentication Failed...");
        return false;
    }
    public void ShowBill()
    {
        Console.WriteLine("\n=== BILL ===\n");
        Console.Write("Please enter the bill id: ");
        int billId = int.Parse(Console.ReadLine());

        Bill bill = FindBillWithId(billId);

        if(bill != null)
        {
            Console.WriteLine(bill);
        }
        else
        {
            Console.WriteLine("Bill with this bill id doesn't exist");
        }
    }

    // Helper method for ShowBill()
    private Bill FindBillWithId(int billId)
    {
        foreach(Bill bill in allBills)
        {
            if(bill.GetBillId() == billId)
            {
                return bill;
            }
        }

        return null;
    }
    
    public void ShowAllPatients()
    {
        Console.WriteLine("\n=== All Patients ===\n");
        foreach(Patient patient in allPatients)
        {
            Console.WriteLine(patient);
        }
    }
    public void ShowAllDoctors()
    {
        Console.WriteLine("\n=== All Doctors ===\n");
        foreach(Doctor doctor in allDoctors)
        {
            Console.WriteLine(doctor);
        }
    }

    public void ShowAllBills()
    {
        Console.WriteLine("\n=== All Bills ===\n");
        foreach(Bill bill in allBills)
        {
            Console.WriteLine(bill);
        }
    }
}