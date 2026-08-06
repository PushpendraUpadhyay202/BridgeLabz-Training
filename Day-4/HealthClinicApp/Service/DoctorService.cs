using System;
using Microsoft.Data.SqlClient;
using HealthClinicApp.Entity;
using HealthClinicApp.Interface;

namespace HealthClinicApp.Service
{
    public class DoctorService : IDoctorService
    {
        public void AddDoctor(Doctor doctor)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Doctors (firstname , lastname , speciality , phone) VALUES (@FirstName, @LastName, @Speciality, @Phone)";
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                command.Parameters.AddWithValue("@LastName", doctor.LastName);
                command.Parameters.AddWithValue("@Speciality", doctor.Speciality);
                command.Parameters.AddWithValue("@Phone", doctor.Phone);

                command.ExecuteNonQuery();

                connection.Close();

                Console.WriteLine("Doctor Added Successfully!");
            }
        }

        public void ViewDoctors()
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Doctors";
                using SqlCommand command = new SqlCommand(query, connection);
                using SqlDataReader reader = command.ExecuteReader();
                    
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["doctor_id"]}, FirstName: {reader["firstname"]}, LastName: {reader["lastname"]}, Specialty: {reader["speciality"]}, Phone: {reader["phone"]}");
                }

                connection.Close();
                
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Doctors SET firstname = @FirstName, phone = @Phone WHERE doctor_id = @DoctorId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                    command.Parameters.AddWithValue("@Phone", doctor.Phone);
                    command.Parameters.AddWithValue("@DoctorId", doctor.DoctorId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteDoctor(int doctorId)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Doctors WHERE doctor_id = @DoctorId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorId", doctorId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}