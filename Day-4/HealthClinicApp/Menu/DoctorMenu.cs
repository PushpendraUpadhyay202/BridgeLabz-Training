using System;
using HealthClinicApp.Entity;
using HealthClinicApp.Interface;
using HealthClinicApp.Service;
namespace HealthClinicApp.Menu
{
    public class DoctorMenu
    {
        private readonly IDoctorService doctorService;

        public DoctorMenu()
        {
            doctorService = new DoctorService();
        }

        public void DisplayDoctorMenu()
        {
            Console.WriteLine("\n================Doctor Menu================\n");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Update Doctor");
            Console.WriteLine("3. View Doctors");
            Console.WriteLine("4. Delete Doctor");
            Console.WriteLine("0. Back to Main Menu");

            Console.WriteLine("\nPlease select an option (0-4):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddDoctor();
                    break;
                case 2:
                    UpdateDoctor();
                    break;
                case 3:
                    ViewDoctors();
                    break;
                case 4:
                    DeleteDoctor();
                    break;
                case 0:
                    MainMenu menu = new MainMenu();
                    menu.DisplayMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    DisplayDoctorMenu();
                    break;
            }
        }

        private void AddDoctor()
        {
            Console.WriteLine("Enter Doctor's First Name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Doctor's Last Name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Doctor's Specialty:");
            string Speciality = Console.ReadLine();
            Console.WriteLine("Enter Doctor's Phone Number:");
            string Phone = Console.ReadLine();

            Doctor doctor = new Doctor(FirstName, LastName, Speciality, Phone);
            doctorService.AddDoctor(doctor);
            DisplayDoctorMenu();
        }

        private void ViewDoctors()
        {
            doctorService.ViewDoctors();
            DisplayDoctorMenu();
        }

        private void UpdateDoctor()
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Enter Doctor's ID to update:");
            doctor.DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Doctor's First Name:");
            doctor.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Doctor's Phone Number:");
            doctor.Phone = Console.ReadLine();

            doctorService.UpdateDoctor(doctor);
            DisplayDoctorMenu();
        }

        private void DeleteDoctor()
        {
            Console.WriteLine("Enter Doctor's ID to delete:");
            int  doctorId = Convert.ToInt32(Console.ReadLine());
            doctorService.DeleteDoctor(doctorId);
            DisplayDoctorMenu();
        }
    }

}