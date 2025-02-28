using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class frmAddApplication : Form
    {
        public frmAddApplication()
        {
            InitializeComponent();
        }

        JobApplicationDBEntities db = new JobApplicationDBEntities();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            saveApplication();
        }

        private void saveApplication()
        {

        }


        private void frmAddApplication_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
        }

        private void fillComboBoxes()
        {
            var stateQuery = from c in db.States select c;
            cmbState.DataSource = stateQuery.ToList();
            cmbState.DisplayMember = "State1";
            cmbState.ValueMember = "Id";

            var jobTypeQuery = from x in db.JobTypes select x;
            cmbWorkEnv.DataSource = jobTypeQuery.ToList();
            cmbWorkEnv.DisplayMember = "JobType1";
            cmbWorkEnv.ValueMember = "Id";

            var websiteQuery = from x in db.ApplicationWebsites select x;
            cmbApplicationWebSite.DataSource = websiteQuery.ToList();
            cmbApplicationWebSite.DisplayMember = "ApplicationWebsite1";
            cmbApplicationWebSite.ValueMember = "Id";

            var statusQuery = from x in db.ApplicationStatus select x;
            cmbStatus.DataSource = statusQuery.ToList();
            cmbStatus.DisplayMember = "JobStatus";
            cmbStatus.ValueMember = "id";

            // set the default selected item 
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    comboBox.Text = "Please select..";
                }
            }
        }
    }
}
