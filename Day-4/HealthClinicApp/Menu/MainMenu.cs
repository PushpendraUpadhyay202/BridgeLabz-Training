using System;
using HealthClinicApp.Interface;

namespace HealthClinicApp.Menu
{
    public class MainMenu
    {
        public void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Health Clinic App!");
            Console.WriteLine("//\n================Main Menu================\n");
            Console.WriteLine("1. Doctor Menu");
            Console.WriteLine("2. Patient Menu");
            Console.WriteLine("3. Appointment Menu");
            Console.WriteLine("0. Exit");

            Console.WriteLine("\nPlease select an option (0-3):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DoctorMenu doctorMenu = new DoctorMenu();
                    doctorMenu.DisplayDoctorMenu();
                    break;
                case 2:
                    PatientMenu patientMenu = new PatientMenu();
                    patientMenu.DisplayPatientMenu();
                    break;
                case 3:
                    AppointmentMenu appointmentMenu = new AppointmentMenu();
                    appointmentMenu.DisplayAppointmentMenu();
                    break;
                case 0:
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    DisplayMainMenu();
                    break;
            }
        }
    }
}