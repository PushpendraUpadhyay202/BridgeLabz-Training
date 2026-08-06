using System;
using HealthClinicApp.Entity;
using HealthClinicApp.Interface;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Service
{
    public class PatientService : IPatientService
    {
        public void AddPatient(Patient patient)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Patients (firstname, lastname, dob ,gender , phone , blood_group , address) VALUES (@FirstName, @LastName, @Dob, @Gender, @Phone, @BloodGroup, @Address)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@LastName", patient.LastName);
                    command.Parameters.AddWithValue("@Dob", patient.Dob);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@Phone", patient.Phone);
                    command.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);
                    command.Parameters.AddWithValue("@Address", patient.Address);

                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Patient Added Successfully!");
            }
        }

        public void ViewPatients()
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Patients";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["patient_id"]}, FirstName: {reader["firstname"]}, LastName: {reader["lastname"]}, DOB: {reader["dob"]}, Gender: {reader["gender"]}, Phone: {reader["phone"]}, Blood Group: {reader["blood_group"]}, Address: {reader["address"]}");
                        }
                    }
                }
            }
        }

        public void UpdatePatient(Patient patient)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Patients SET firstname = @FirstName, dob = @Dob, address = @Address WHERE patient_id = @PatientId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@Dob", patient.Dob);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@PatientId", patient.PatientId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePatient(int patientId)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Patients WHERE patient_id = @PatientId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}