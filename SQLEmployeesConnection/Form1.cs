using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLEmployeesConnection.Scripts;

namespace SQLEmployeesConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DBManager.Connect();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            BindingList<Job> jobs = new BindingList<Job>(DBManager.GetJobList());
            dataGridViewJobs.DataSource = jobs;

            dataGridViewJobs.Columns["IdJob"].ReadOnly = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DBManager.Connect();

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            labelConnection.Text = "Opened";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DBManager.Disconnect();

            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            labelConnection.Text = "Closed";
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void dataGridViewJobs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Job job = (Job)dataGridViewJobs.Rows[e.RowIndex].DataBoundItem;
            DBManager.UpdateJob(job);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
