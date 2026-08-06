using System;
using HealthClinicApp.Entity;
using HealthClinicApp.Interface;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Service
{
    public class AppointmentService : IAppointmentService
    {
        public void ScheduleAppointment(Appointment appointment)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Appointments (patient_id, doctor_id, appointmentdate , appointmenttime , status) VALUES (@PatientId, @DoctorId, @AppointmentDate , @AppointmentTime , @Status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                    command.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
                    command.Parameters.AddWithValue("@Status", appointment.Status);
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Appointment Scheduled Successfully!");
            }
        }

        public void ViewAppointments()
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM appointments";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["appointment_id"]}, Patient ID: {reader["patient_id"]}, Doctor ID: {reader["doctor_id"]}, Date: {reader["appointmentdate"]} , Time: {reader["appointmenttime"]} , Status: {reader["status"]}");
                        }
                    }
                }
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Appointments SET appointmentdate = @AppointmentDate, appointmenttime = @AppointmentTime, status = @Status WHERE appointment_id = @AppointmentId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId);
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
                    command.Parameters.AddWithValue("@Status", appointment.Status);
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Appointment Updated Successfully!");
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Appointments WHERE appointment_id = @AppointmentId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Appointment Canceled Successfully!");
            }
        }
    }
}