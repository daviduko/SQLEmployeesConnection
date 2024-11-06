using System;
using System.ComponentModel;
using System.Windows.Forms;
using SQLEmployeesConnection.Scripts;

namespace SQLEmployeesConnection
{
    public partial class MainForm : Form
    {
        DALJob DALJob;
        DBConnect dbConnect;

        public MainForm()
        {
            InitializeComponent();
            DALJob = new DALJob();
            dbConnect = new DBConnect();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            BindingList<Job> jobs = new BindingList<Job>(DALJob.GetListOf());
            dataGridViewJobs.DataSource = jobs;

            dataGridViewJobs.Columns["IdJob"].ReadOnly = true;
        }
        private void btnNewJob_Click(object sender, EventArgs e)
        {
            Form form = new NewJobForm();
            form.Show();
        }

        private void dataGridViewJobs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Job job = (Job)dataGridViewJobs.Rows[e.RowIndex].DataBoundItem;
            DALJob.Update(job);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            dbConnect.Connect();

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            labelConnection.Text = "Opened";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            dbConnect.Disconnect();

            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            labelConnection.Text = "Closed";
        }

    }
}
