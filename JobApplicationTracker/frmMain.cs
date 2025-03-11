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

namespace JobApplicationTracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        JobApplicationDBEntities db = new JobApplicationDBEntities();

        private void frmMain_Load(object sender, EventArgs e)
        {
            fillDgvJobsWithQuery();
            //fillDgvJobsWithEntityFramework();
        }



        // page load methods
        public void fillDgvJobsWithQuery()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            string query = "SELECT a.CompanyName as 'Company Name' , a.City, s.State, jt.JobType AS 'Job Type', a.SalaryPerHour AS 'Hourly Salary', a.SalaryPerYear AS 'Annual Salary', aw.ApplicationWebsite AS 'Website', appStatus.JobStatus AS 'Status', a.RequiredAdditionalTools AS 'Other Tools', a.ApplicationDate AS 'Application Date', a.Notes FROM Applications a INNER JOIN States s ON a.StateId = s.Id INNER JOIN JobType jt ON a.JobTypeId = jt.Id INNER JOIN ApplicationWebsites aw ON a.ApplicationWebsiteId = aw.Id INNER JOIN ApplicationStatus appStatus ON a.StatusId = appStatus.Id;";

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

            // disable the default last added empty datagridview row
            dgvJobs.AllowUserToAddRows = false;

            // change the format of money type column from '10.00' to '$10'
            /*
                "N0"	3000 (No decimals)
                "N2"	3000.50 (Two decimal places)
                "C"	    $3,000.50 (Currency format, based on system locale)
                "C0"	$3,000 (Currency without decimals)
             */
            dgvJobs.Columns["Annual Salary"].DefaultCellStyle.Format = "C0";
            dgvJobs.Columns["Hourly Salary"].DefaultCellStyle.Format = "C0";

        }

        private void fillDgvJobsWithEntityFramework()
        {
            var query = from a in db.Applications
                        join s in db.States on a.StateId equals s.Id
                        join jt in db.JobTypes on a.JobTypeId equals jt.Id
                        join aw in db.ApplicationWebsites on a.ApplicationWebsiteId equals aw.Id
                        join appStatus in db.ApplicationStatus on a.StatusId equals appStatus.id
                        select new
                        {
                            Company = a.CompanyName,
                            City = a.City,
                            State = s.State1,
                            JobType = jt.JobType1,
                            HourlySalary = a.SalaryPerHour,
                            AnnualSalary = a.SalaryPerYear,
                            Website = aw.ApplicationWebsite1,
                            Status = appStatus.JobStatus,
                            OtherTools = a.RequiredAdditionalTools,
                            ApplicationDate = a.ApplicationDate,
                            Notes = a.Notes
                        };
            dgvJobs.DataSource = query.ToList();

            // datagridview settings
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Alligning the headers to the center
            foreach (DataGridViewColumn header in dgvJobs.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }




        // menu strip click events
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hitch your wagon to a star 🫵🤘 \nVersion 5.2.0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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


        private void newWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddWebsiteForm();
        }


        private void newEnvironmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddJobTypeForm();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddStatusForm();
        }

        private void statesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openListStatesForm();
        }

        private void btnViewStates_Click(object sender, EventArgs e)
        {
            openListStatesForm();
        }

        private void btnViewJobTypes_Click(object sender, EventArgs e)
        {
            openListJobTypesForm();
        }
        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            openListStatusForm();
        }

        private void btnViewWebsites_Click(object sender, EventArgs e)
        {
            openListWebSitesForm();
        }

        private void applicationWebsitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openListWebSitesForm();
        }

        private void workEnvironmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openListJobTypesForm();
        }

        private void seeTheStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openListStatusForm();
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

        private void openListStatesForm()
        {
            frmListStates f = new frmListStates();
            f.ShowDialog();
        }


        private void openListJobTypesForm()
        {
            frmListJobTypes f = new frmListJobTypes();
            f.ShowDialog();
        }

        private void openListStatusForm()
        {
            frmListStatus f = new frmListStatus();
            f.ShowDialog();
        }

        private void openListWebSitesForm()
        {
            frmListWebsites f = new frmListWebsites();
            f.ShowDialog();
        }


    }
}
