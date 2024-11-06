using SQLEmployeesConnection.Scripts;
using System;
using System.Windows.Forms;

namespace SQLEmployeesConnection
{
    public partial class NewJobForm : Form
    {
        DALJob DALJob;

        public NewJobForm()
        {
            InitializeComponent();
            DALJob = new DALJob();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Job job = new Job(txtTitle.Text, numMinSalary.Value, numMaxSalary.Value);
            DALJob.Insert(job);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtTitle.Text))
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
    }
}
