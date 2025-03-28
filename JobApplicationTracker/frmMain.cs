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


        // variables
        JobApplicationDBEntities db = new JobApplicationDBEntities();
        int idToDeleteOrUpdate;
        

        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvJobsListWithAdoNet();
            //dgvJobsListWithEntityFramework();
        }

        


        /// <summary>
        /// This method fills the datagridview using ADO.net Connected Approach (Using SqlCommand and SqlDataReader)
        /// This method is efficient for reading large amounts of data because it reads one row at a time.
        /// 
        /// </summary>
        public void dgvJobsListWithAdoNet()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            string query = "SELECT a.Id, a.CompanyName AS 'Company Name', a.City, s.State, jt.JobType AS 'Job Type', a.SalaryPerHour AS 'Hourly Salary', a.SalaryPerYear AS 'Annual Salary', aw.ApplicationWebsite AS 'Website', appStatus.JobStatus AS 'Status', a.RequiredAdditionalTools AS 'Required Other Tools', a.ApplicationDate AS 'Application Date', a.Notes FROM Applications a LEFT JOIN States s ON a.StateId = s.Id LEFT JOIN JobType jt ON a.JobTypeId = jt.Id LEFT JOIN ApplicationWebsites aw ON a.ApplicationWebsiteId = aw.Id LEFT JOIN ApplicationStatus appStatus ON a.StatusId = appStatus.Id;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvJobs.DataSource = dt;
                }
            }
            
            // numarating thr first column of the datagridview
            CommonMethods.numerateDataGridView(dgvJobs);


            // Alligning the headers to the center
            foreach (DataGridViewColumn header in dgvJobs.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            

            // setting up the datagridview
            dgvJobs.Columns[0].Visible = false;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.MultiSelect = false;
            // disable the default last added empty datagridview row
            dgvJobs.AllowUserToAddRows = false;


            // declare the salary format (decimal or whole number)
            // change the format of money type column from '10.00' to '$10'
            /*
                "N0"	3000 (No decimals)
                "N2"	3000.50 (Two decimal places)
                "C"	    $3,000.50 (Currency format, based on system locale)
                "C0"	$3,000 (Currency without decimals)
             */
            dgvJobs.Columns["Annual Salary"].DefaultCellStyle.Format = "C0";
            dgvJobs.Columns["Hourly Salary"].DefaultCellStyle.Format = "C";
        }



        /// <summary>
        /// This method fills the datagridview using Entity Framework using LINQ queries
        ///
        /// </summary>
        public void dgvJobsListWithEntityFramework()
        {
            var query = from a in db.Applications
                        join s in db.States on a.StateId equals s.Id
                        join jt in db.JobTypes on a.JobTypeId equals jt.Id
                        join aw in db.ApplicationWebsites on a.ApplicationWebsiteId equals aw.Id
                        join appStatus in db.ApplicationStatus on a.StatusId equals appStatus.id
                        select new
                        {
                            Id = a.Id,
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
            dgvJobs.Columns[0].Visible = false;
            dgvJobs.MultiSelect = false;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Alligning the headers to the center
            foreach (DataGridViewColumn header in dgvJobs.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /// <summary>
        /// This method deletes the selected row from the datagridview
        /// 
        /// </summary>
        public void deleteSelectedRow()
        {
            idToDeleteOrUpdate = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells[0].Value);
            Application applicationToDelete = db.Applications.Find(idToDeleteOrUpdate);
            string applicationToDeleteName = applicationToDelete.CompanyName;

            DialogResult ds = MessageBox.Show($"Do you want to delete this job application with the company name '{applicationToDeleteName}' ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ds == DialogResult.Yes)
            {
                db.Applications.Remove(applicationToDelete);
                db.SaveChanges();
                MessageBox.Show($"'{applicationToDeleteName}' is successfully deleted!");

                dgvJobs.Columns.Clear();
                dgvJobsListWithAdoNet();
            }

        }


        // menu strip click events
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hitch your wagon to a star 🫵🤘 \r\n\r\nVersion 1.0.0 \r\nDeveloped by Umut Degismen", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteSelectedRow();
        }




        // Open form methods

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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddApplicationForm();
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions f = new frmOptions();
            f.ShowDialog();
        }
    }
}
