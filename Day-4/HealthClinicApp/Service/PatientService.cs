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
                string procedureName = "sp_AddPatient";
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
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
                string procedureName = "sp_ViewPatient";
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\n================Patient List================\n");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["patient_id"]} , FirstName: {reader["firstname"]}, LastName: {reader["lastname"]}, Dob: {reader["dob"]}, Gender: {reader["gender"]}, Phone: {reader["phone"]}, BloodGroup: {reader["blood_group"]}, Address: {reader["address"]}");
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
                string procedureName = "sp_UpdatePatient";
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientId", patient.PatientId);
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@Dob", patient.Dob);
                    command.Parameters.AddWithValue("@Address", patient.Address);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePatient(int patientId)
        {
            using (SqlConnection connection = DBConnectionUtility.GetConnection())
            {
                connection.Open();
                string procedureName = "sp_DeletePatient";
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}