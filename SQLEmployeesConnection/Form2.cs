using SQLEmployeesConnection.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLEmployeesConnection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Job job = new Job(txtTitle.Text, numMinSalary.Value, numMaxSalary.Value);
            DBManager.InsertJob(job);
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
