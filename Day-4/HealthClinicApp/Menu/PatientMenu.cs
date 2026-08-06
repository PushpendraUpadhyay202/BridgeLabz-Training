using System;
using HealthClinicApp.Entity;
using HealthClinicApp.Interface;
using HealthClinicApp.Service;

namespace HealthClinicApp.Menu
{
    public class PatientMenu
    {
        private readonly IPatientService patientService;

        public PatientMenu()
        {
            patientService = new PatientService();
        }

        public void DisplayPatientMenu()
        {
            Console.WriteLine("\n================Patient Menu================\n");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patients");
            Console.WriteLine("3. Update Patient");
            Console.WriteLine("4. Delete Patient");
            Console.WriteLine("0. Back to Main Menu");

            Console.WriteLine("\nPlease select an option (0-4):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddPatient();
                    break;
                case 2:
                    ViewPatients();
                    break;
                case 3:
                    UpdatePatient();
                    break;
                case 4:
                    DeletePatient();
                    break;
                case 0:
                    MainMenu menu = new MainMenu();
                    menu.DisplayMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    DisplayPatientMenu();
                    break;
            }
        }

        private void AddPatient()
        {
            Console.WriteLine("Enter Patient's First Name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Patient's Last Name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Patient's Date of Birth (yyyy-MM-dd):");
            DateTime Dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient's Gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("Enter Patient's Phone Number:");
            string Phone = Console.ReadLine();
            Console.WriteLine("Enter Patient's Blood Group:");
            string BloodGroup = Console.ReadLine();
            Console.WriteLine("Enter Patient's Address:");
            string Address = Console.ReadLine();

            Patient patient = new Patient(FirstName, LastName, Dob, Gender, Phone, BloodGroup, Address);

            patientService.AddPatient(patient);
            DisplayPatientMenu();
        }

        private void ViewPatients()
        {
            patientService.ViewPatients();
            DisplayPatientMenu();
        }

        private void UpdatePatient()
        {
            Patient patient = new Patient();
            Console.WriteLine("Enter Patient's ID to update:");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Patient's First Name:");
            patient.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Patient's Date of Birth (yyyy-mm-dd):");
            patient.Dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient's Address:");
            patient.Address = Console.ReadLine();

            patientService.UpdatePatient(patient);
            DisplayPatientMenu();

        }

        private void DeletePatient()
        {
            Console.WriteLine("Enter Patient's ID to delete:");
            int patientId = Convert.ToInt32(Console.ReadLine());
            patientService.DeletePatient(patientId);
            DisplayPatientMenu();
        }
    }
}