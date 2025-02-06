using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Migrations.Model;

namespace JopApplicationTracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            fillUpDgvJobs();
        }







        // menu strip click events
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hitch your wagon to a star 🫵🤘 \nVersion 5.2.0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddApplicationForm();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            openAddApplicationForm();
        }

        private void newStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddStateForm();
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            openAddStateForm();
        }

        private void newWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddWebsiteForm();
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            openAddWebsiteForm();
        }

        private void newEnvironmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddJobTypeForm();
        }

        private void btnAddJobType_Click(object sender, EventArgs e)
        {
            openAddJobTypeForm();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddStatusForm();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            openAddStatusForm();
        }



        // form openning methods

        private void openAddApplicationForm()
        {
            frmAddApplication f = new frmAddApplication();
            f.ShowDialog();
        }

        private void openAddJobTypeForm()
        {
            frmAddJobType f = new frmAddJobType();
            f.ShowDialog();
        }
        private void openAddWebsiteForm()
        {
            frmAddWebsite f = new frmAddWebsite();
            f.ShowDialog();
        }
        private void openAddStateForm()
        {
            frmAddState f = new frmAddState();
            f.ShowDialog();
        }

        private void openAddStatusForm()
        {
            frmAddStatus f = new frmAddStatus();
            f.ShowDialog();
        }



        // page load methods
        public void fillUpDgvJobs()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            string query = "SELECT a.CompanyName as 'Company Name' , a.City, a.StateId AS 'State', a. JobTypeId AS 'Job Type', a.SalaryPerHour AS 'Hourly Salary', a.SalaryPerYear AS 'Annual Salary', a.ApplicationWebsiteId AS 'Website', a.StatusId AS 'Status', a.RequiredAdditionalTools AS 'Other Tools', a.ApplicationDate AS 'Application Date', a.Notes FROM Applications a INNER JOIN States s ON a.StateId = s.Id INNER JOIN JobType jt ON a.JobTypeId = jt.Id INNER JOIN ApplicationWebsites aw ON a.ApplicationWebsiteId = aw.Id INNER JOIN ApplicationStatus appStatus ON a.StatusId = appStatus.Id;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvJobs.DataSource = dt;

            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Alligning the headers to the center
            foreach (DataGridViewColumn header in dgvJobs.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


    }
}
