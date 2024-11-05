using SQLEmployeesConnection.Scripts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLEmployeesConnection
{
    internal static class DBManager
    {
        private static string connectionString =
            "Data Source=85.208.21.117,54321;" +
            "Initial Catalog=DavidSanzEmployees;" +
            "User ID=sa;" +
            "Password=Sql#123456789";

        private static SqlConnection connection;

        public static void Connect()
        {
            if(connection == null)
                connection = new SqlConnection(connectionString);

            connection.Open();
        }

        public static void Disconnect()
        {
            connection.Close();
        }

        public static void InsertJob(Job job)
        {
            string sql = @"
                INSERT INTO jobs (job_title, min_salary, max_salary)
                VALUES (@JobTitle, @MinSalary, @MaxSalary)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
                    cmd.Parameters.AddWithValue("@MinSalary", job.MinSalary ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaxSalary", job.MaxSalary ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                throw;
            }
        }

        public static List<Job> GetJobList()
        {
            List<Job> jobs = new List<Job>();

            string query = "SELECT * FROM jobs";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int jobId = reader.GetInt32(reader.GetOrdinal("job_id"));
                string jobName = reader.GetString(reader.GetOrdinal("job_title"));
                decimal? minSalary = reader.IsDBNull(reader.GetOrdinal("min_salary"))
                    ? (decimal?)null
                    : reader.GetDecimal(reader.GetOrdinal("min_salary"));
                decimal? maxSalary = reader.IsDBNull(reader.GetOrdinal("max_salary"))
                    ? (decimal?)null
                    : reader.GetDecimal(reader.GetOrdinal("max_salary"));

                Job job = new Job(jobId, jobName, minSalary, maxSalary);

                jobs.Add(job);
            }

            reader.Close();

            return jobs;
        }

        public static void UpdateJob()
        {

        }
    }
}
