using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLEmployeesConnection.Scripts
{
    public class Job
    {
        public int IdJob {  get; set; }
        public string JobTitle { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }

        public Job() { }

        public Job(string jobTitle, decimal? minSalary, decimal? maxSalary)
        {
            JobTitle = jobTitle;
            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }

        public Job(int idJob, string jobTitle, decimal? minSalary, decimal? maxSalary) : this(jobTitle, minSalary, maxSalary)
        {
            IdJob = idJob;
        }
    }
}
