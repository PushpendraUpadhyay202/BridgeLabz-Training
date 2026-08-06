using Microsoft.Data.SqlClient;

namespace HealthClinicApp
{
    public static class DBConnectionUtility
    {
        private static readonly string connectionString = "Server=localhost\\SQLEXPRESS;Database=Healthappdb;Trusted_Connection=true;TrustServerCertificate=true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}