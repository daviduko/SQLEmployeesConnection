using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLEmployeesConnection.Scripts
{
    internal class DALJob
    {
        private DBConnect dbConnect;

        public DALJob()
        {
            dbConnect = new DBConnect();
        }

        public void Insert(Job job)
        {
            string sql = @"
                INSERT INTO jobs (job_title, min_salary, max_salary)
                VALUES (@JobTitle, @MinSalary, @MaxSalary)";

            try
            {
                dbConnect.Connect();

                using (SqlCommand cmd = new SqlCommand(sql, dbConnect.Connection))
                {
                    cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
                    cmd.Parameters.AddWithValue("@MinSalary", job.MinSalary ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaxSalary", job.MaxSalary ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }

                dbConnect.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public List<Job> GetList()
        {
            List<Job> jobs = new List<Job>();

            string query = "SELECT * FROM jobs";

            try
            {
                dbConnect.Connect();

                SqlCommand cmd = new SqlCommand(query, dbConnect.Connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                { 
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
                }

                dbConnect.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return jobs;
        }

        public void Update(Job job)
        {
            string query = "UPDATE jobs " +
                "SET job_title = @JobTitle, min_salary = @MinSalary, max_salary = @MaxSalary " +
                "WHERE job_id = @JobId";

            try
            {
                dbConnect.Connect();

                using (SqlCommand cmd = new SqlCommand(query, dbConnect.Connection))
                {
                    cmd.Parameters.AddWithValue("@JobId", job.IdJob);
                    cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
                    cmd.Parameters.AddWithValue("@MinSalary", job.MinSalary ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaxSalary", job.MaxSalary ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }

                dbConnect.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
