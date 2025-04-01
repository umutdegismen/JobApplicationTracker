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

        private void frmAddApplication_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validateMandatoryFields();
            clearAndCloseAddApplicationForm();
            listDgvJobs();
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

                    // if txtSalaryHour.Text or txtSalaryYear.Text is ONLY an integer!
                    if (decimal.TryParse(txtSalaryHour.Text, out _) || (decimal.TryParse(txtSalaryYear.Text, out _)))
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

                            string salary = txtSalaryHour.Text;

                            // money type 

                            cmd.Parameters.Add("@salaryHour", SqlDbType.Money).Value = string.IsNullOrWhiteSpace(txtSalaryHour.Text) ? (object)DBNull.Value : decimal.Parse(txtSalaryHour.Text);
                            cmd.Parameters.Add("@salaryYear", SqlDbType.Money).Value = string.IsNullOrWhiteSpace(txtSalaryYear.Text) ? (object)DBNull.Value : decimal.Parse(txtSalaryYear.Text);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your job application saved successfully!");

                            listDgvJobs();
                            clearAndCloseAddApplicationForm();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("\"Salary per Hour\" OR \"Salary per Year\" fields can not be strings!");
                    }


                }
            }
        }




        /// <summary>
        /// This method fills the comboboxes
        /// 
        /// </summary>
        private void fillComboBoxes()
        {
            cmbState.DataSource = db.States.ToList();
            cmbState.DisplayMember = "State1";
            cmbState.ValueMember = "Id";

            cmbWorkEnv.DataSource = db.JobTypes.ToList();
            cmbWorkEnv.DisplayMember = "JobType1";
            cmbWorkEnv.ValueMember = "Id";

            cmbApplicationWebSite.DataSource = db.ApplicationWebsites.ToList();
            cmbApplicationWebSite.DisplayMember = "ApplicationWebsite1";
            cmbApplicationWebSite.ValueMember = "Id";

            cmbStatus.DataSource = db.ApplicationStatus.ToList();
            cmbStatus.DisplayMember = "JobStatus";
            cmbStatus.ValueMember = "id";

            // set the default selected item 
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    comboBox.Text = "Please select...";
                }
            }
        }


        /// <summary>
        /// This method checks the controls on the form and creates a list of messages for unselected/null mandatory comboboxes and textboxes.
        /// Warns tthe user not to leave the mandatory fields unselected.
        /// 
        /// </summary>
        private void validateMandatoryFields()
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


        /// <summary>
        /// This method refreshes and lists the datagridview (dgvJobs) elements on the frmMain
        /// 
        /// </summary>
        public void listDgvJobs()
        {
            frmMain f = (frmMain)System.Windows.Forms.Application.OpenForms["frmMain"];
            f.dgvJobsListWithAdoNet();
        }


        /// <summary>
        /// This method checks every Control on the windows form and returns it to default.
        /// 
        /// </summary>
        public void clearAndCloseAddApplicationForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.Clear();
                }
                if (c is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                    cmb.Text = "Please select..";
                }
            }

            this.Close();
        }
    }
}
