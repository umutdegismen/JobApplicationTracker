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
            validateAndSave();
        }



        private void saveApplication()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string query = "INSERT INTO Applications(CompanyName,City,StateId,JobTypeId,SalaryPerHour,SalaryPerYear,ApplicationWebsiteId,StatusId,RequiredAdditionalTools,Notes) VALUES (@company, @city, @state, @jobType, @salaryHour, @salaryYear, @website, @status, @additionalTool, @note);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // textboxes
                        cmd.Parameters.Add("@company", SqlDbType.NVarChar).Value = txtCompanyName.Text;
                        cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtCity.Text;
                        cmd.Parameters.Add("@additionalTool", SqlDbType.NVarChar).Value = txtRequiredTools.Text;
                        cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = txtNotes.Text;
                        
                        // comboboxes
                        cmd.Parameters.Add("@state", SqlDbType.Int).Value = cmbState.SelectedValue ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@jobType", SqlDbType.Int).Value = cmbWorkEnv.SelectedValue ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@website", SqlDbType.Int).Value = cmbApplicationWebSite.SelectedValue ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@status", SqlDbType.Int).Value = cmbStatus.SelectedValue ?? (object)DBNull.Value;

                        // money type 
                        cmd.Parameters.Add("@salaryHour", SqlDbType.Money).Value = string.IsNullOrWhiteSpace(txtSalaryHour.Text) ? (object)DBNull.Value : decimal.Parse(txtSalaryHour.Text);
                        cmd.Parameters.Add("@salaryYear", SqlDbType.Money).Value = string.IsNullOrWhiteSpace(txtSalaryYear.Text) ? (object)DBNull.Value : decimal.Parse(txtSalaryYear.Text);




                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your job application saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
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


        private void validateAndSave()
        {
            var errorMessages = new List<string>();

            if (cmbApplicationWebSite.SelectedIndex == -1)
                errorMessages.Add("Please select a website!");
            if (cmbState.SelectedIndex == -1)
                errorMessages.Add("Please select a state!");
            if (cmbStatus.SelectedIndex == -1)
                errorMessages.Add("Please select the status!");
            if (cmbWorkEnv.SelectedIndex == -1)
                errorMessages.Add("Please select the job type!");
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
                errorMessages.Add("Please enter a company name!");

            if (errorMessages.Count == 0)
            {
                saveApplication();
            }
            else
            {
                MessageBox.Show(string.Join("\n", errorMessages), "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
