using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using SQLEmployeesConnection;

namespace SQLEmployeesConnection.Scripts
{
    internal class DALJob : DAL<Job>
    {
        private EmployeesDataClassesDataContext db;

        public DALJob() : base()
        {
            db = new EmployeesDataClassesDataContext();
        }

        public override void Insert(Job job)
        {
            #region NormalQuery

            //string sql = @"
            //    INSERT INTO jobs (job_title, min_salary, max_salary)
            //    VALUES (@JobTitle, @MinSalary, @MaxSalary);
            //    SELECT SCOPE_IDENTITY();";

            //try
            //{
            //    dbConnect.Connect();

            //    using (SqlCommand cmd = new SqlCommand(sql, dbConnect.Connection))
            //    {
            //        cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
            //        cmd.Parameters.AddWithValue("@MinSalary", job.MinSalary ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@MaxSalary", job.MaxSalary ?? (object)DBNull.Value);

            //        cmd.ExecuteNonQuery();

            //        ////if we want to store id from job selected
            //        //job.IdJob = (int)cmd.ExecuteScalar();
            //    }

            //    dbConnect.Disconnect();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

            #endregion

            #region LinQ

            try
            {
                var newJob = new jobs
                {
                    job_title = job.JobTitle,
                    min_salary = job.MinSalary,
                    max_salary = job.MaxSalary
                };

                db.jobs.InsertOnSubmit(newJob);
                db.SubmitChanges();

                // if we want to store id from job selected
                job.IdJob = newJob.job_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            #endregion
        }

        public override void Update(Job job)
        {
            #region NormalQuery

            //string query = "UPDATE jobs " +
            //    "SET job_title = @JobTitle, min_salary = @MinSalary, max_salary = @MaxSalary " +
            //    "WHERE job_id = @JobId";

            //try
            //{
            //    dbConnect.Connect();

            //    using (SqlCommand cmd = new SqlCommand(query, dbConnect.Connection))
            //    {
            //        cmd.Parameters.AddWithValue("@JobId", job.IdJob);
            //        cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
            //        cmd.Parameters.AddWithValue("@MinSalary", job.MinSalary ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@MaxSalary", job.MaxSalary ?? (object)DBNull.Value);

            //        cmd.ExecuteNonQuery();
            //    }

            //    dbConnect.Disconnect();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

            #endregion

            #region LinQ

            try
            {
                var existingJob = db.jobs.FirstOrDefault(j => j.job_id == job.IdJob);
                if (existingJob != null)
                {
                    existingJob.job_title = job.JobTitle;
                    existingJob.min_salary = job.MinSalary;
                    existingJob.max_salary = job.MaxSalary;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            #endregion
        }

        public override List<Job> GetListOf()
        {
            List<Job> jobs = new List<Job>();

            #region NormalQuery

            //string query = "SELECT * FROM jobs";

            //try
            //{
            //    dbConnect.Connect();

            //    SqlCommand cmd = new SqlCommand(query, dbConnect.Connection);

            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    { 
            //        while (reader.Read())
            //        {
            //            int jobId = reader.GetInt32(reader.GetOrdinal("job_id"));
            //            string jobName = reader.GetString(reader.GetOrdinal("job_title"));

            //            decimal? minSalary = reader.IsDBNull(reader.GetOrdinal("min_salary"))
            //                ? (decimal?)null
            //                : reader.GetDecimal(reader.GetOrdinal("min_salary"));
            //            decimal? maxSalary = reader.IsDBNull(reader.GetOrdinal("max_salary"))
            //                ? (decimal?)null
            //                : reader.GetDecimal(reader.GetOrdinal("max_salary"));

            //            Job job = new Job(jobId, jobName, minSalary, maxSalary);

            //            jobs.Add(job);
            //        }
            //    }

            //    dbConnect.Disconnect();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

            #endregion

            #region LinQ

            try
            {
                var jobList = db.jobs.ToList();
                foreach (var j in jobList)
                {
                    Job job = new Job(j.job_id, j.job_title, j.min_salary, j.max_salary);
                    jobs.Add(job);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            #endregion

            return jobs;
        }
    }
}
