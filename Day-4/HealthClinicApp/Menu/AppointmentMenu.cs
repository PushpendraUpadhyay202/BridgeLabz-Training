using System;
using HealthClinicApp.Entity;
using HealthClinicApp.Interface;
using HealthClinicApp.Service;

namespace HealthClinicApp.Menu
{
    public class AppointmentMenu
    {
        private readonly IAppointmentService appointmentService;

        public AppointmentMenu()
        {
            appointmentService = new AppointmentService();
        }
        public void DisplayAppointmentMenu()
        {
            Console.WriteLine("\n================Appointment Menu================\n");
            Console.WriteLine("1. Schedule Appointment");
            Console.WriteLine("2. View Appointments");
            Console.WriteLine("3. Update Appointment");
            Console.WriteLine("4. Cancel Appointment");
            Console.WriteLine("0. Back to Main Menu");

            Console.WriteLine("\nPlease select an option (0-4):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ScheduleAppointment();
                    break;
                case 2:
                    ViewAppointments();
                    break;
                case 3:
                    UpdateAppointment();
                    break;
                case 4:
                    CancelAppointment();
                    break;
                case 0:
                    MainMenu menu = new MainMenu();
                    menu.DisplayMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    DisplayAppointmentMenu();
                    break;
            }
        }

        private void ScheduleAppointment()
        {
            Console.WriteLine("Enter Patient ID:");
            int PatientId = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Doctor ID:");
            int DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Appointment Date (yyyy-MM-dd):");
            DateOnly AppointmentDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Appointment Time (HH:mm):");
            TimeOnly AppointmentTime = TimeOnly.Parse(Console.ReadLine());
            string Status = "Scheduled";

            Appointment appointment = new Appointment(PatientId, DoctorId, AppointmentDate, AppointmentTime, Status);
            appointmentService.ScheduleAppointment(appointment);
            DisplayAppointmentMenu();

        }

        private void ViewAppointments()
        {
            appointmentService.ViewAppointments();
            DisplayAppointmentMenu();
        }

        private void UpdateAppointment()
        {
            Appointment appointment = new Appointment();
            Console.WriteLine("Enter Appointment ID to update:");
            appointment.AppointmentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Appointment Date (yyyy-MM-dd):");
            appointment.AppointmentDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Appointment Time (HH:mm):");
            appointment.AppointmentTime = TimeOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Status:");
            appointment.Status = Console.ReadLine();

            appointmentService.UpdateAppointment(appointment);
            DisplayAppointmentMenu();
        }

        private void CancelAppointment()
        {
            Console.WriteLine("Enter Appointment ID to cancel:");
            int appointmentId = Convert.ToInt32(Console.ReadLine());

            appointmentService.CancelAppointment(appointmentId);
            DisplayAppointmentMenu();
        }
    }
}