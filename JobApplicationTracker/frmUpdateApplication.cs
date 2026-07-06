using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class frmUpdateApplication : Form
    {
        // instance variables
        int idToUpdate;
        JobApplicationDBEntities db = new JobApplicationDBEntities();
        Application applicationToUpdate;
        State stateToUpdate;
        ApplicationStatu statusToUpdate;
        JobType jobtypeToUpdate;
        ApplicationWebsite websiteToUpdate;


        string newCompanyName;
        string newCity;
        string newSalaryHour;
        string newSalaryYear;
        string newRequiredTools;
        string newNotes;
        string newState;
        string newStatus;
        string newApplicationWebsite;
        string newJobType;
        DateTime dateTime;
        


        public frmUpdateApplication(int id)
        {
            InitializeComponent();
            idToUpdate = id;
        }

        private void frmUpdateApplication_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            fillFrmUpdateApplication();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateChanges();
            closeUpdatePage();
            refreshFormMainDgv();
        }

        private void closeUpdatePage()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Text = "";
                }

                if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                    cmb.Text = "Please select...";
                }
            }
            this.Close();
        }

        /// <summary>
        /// This method cleans the DataGridView in Main Form and re-lists the data.
        /// Basically, refreshes the main form.
        /// 
        /// </summary>
        private void refreshFormMainDgv()
        {
            frmMain f = (frmMain)System.Windows.Forms.Application.OpenForms["frmMain"];
            f.dgvJobs.Columns.Clear();
            f.dgvJobsListWithAdoNet();
        }

        /// <summary>
        /// This method fills the fields with the selected values based on the selected row on DataGridView.
        /// 
        /// </summary>
        private void fillFrmUpdateApplication()
        {
            try
            {
                applicationToUpdate = db.Applications.Find(idToUpdate);

                txtCompanyName.Text = applicationToUpdate.CompanyName;
                txtCity.Text = applicationToUpdate.City;

                // if the salary textboxes have value, format it 'C0'. If not, do nothing.
                txtSalaryHour.Text = applicationToUpdate.SalaryPerHour.HasValue ? applicationToUpdate.SalaryPerHour.Value.ToString("c0") : "";
                txtSalaryYear.Text = applicationToUpdate.SalaryPerYear.HasValue ? applicationToUpdate.SalaryPerYear.Value.ToString("c0") : "";
                txtRequiredTools.Text = applicationToUpdate.RequiredAdditionalTools;
                txtNotes.Text = applicationToUpdate.Notes;
                cmbState.SelectedValue = applicationToUpdate.StateId;
                cmbStatus.SelectedValue = applicationToUpdate.StatusId;
                cmbApplicationWebSite.SelectedValue = applicationToUpdate.ApplicationWebsiteId;
                cmbWorkEnv.SelectedValue = applicationToUpdate.JobTypeId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }


        }

        /// <summary>
        /// This method loads the data to comboxes before we load the form.
        /// 
        /// </summary>
        private void LoadComboBoxData()
        {
            cmbState.DataSource = db.States.ToList();
            cmbState.DisplayMember = "State1";
            cmbState.ValueMember = "Id";

            cmbStatus.DataSource = db.ApplicationStatus.ToList();
            cmbStatus.DisplayMember = "JobStatus";
            cmbStatus.ValueMember = "id";

            cmbWorkEnv.DataSource = db.JobTypes.ToList();
            cmbWorkEnv.DisplayMember = "JobType1";
            cmbWorkEnv.ValueMember = "Id";

            cmbApplicationWebSite.DataSource = db.ApplicationWebsites.ToList();
            cmbApplicationWebSite.DisplayMember = "ApplicationWebsite1";
            cmbApplicationWebSite.ValueMember = "Id";
        }


        /// <summary>
        /// This method gets the changes and replaces the existing entries.
        /// Saves the changes to the database.
        /// </summary>
        private void updateChanges()
        {
            if (db == null)
            {
                MessageBox.Show("Database context is null.");
                return;
            }

            if (idToUpdate <= 0)
            {
                MessageBox.Show("Invalid idToUpdate value.");
                return;
            }

            // Get the changes from UI
            newCompanyName = txtCompanyName.Text;
            newCity = txtCity.Text;
            newRequiredTools = txtRequiredTools.Text;
            newNotes = txtNotes.Text;
            newSalaryHour = txtSalaryHour.Text;
            newSalaryYear = txtSalaryYear.Text;
            newState = cmbState.SelectedValue?.ToString();
            newStatus = cmbStatus.SelectedValue?.ToString();
            newApplicationWebsite = cmbApplicationWebSite.SelectedValue?.ToString();
            newJobType = cmbWorkEnv.SelectedValue?.ToString();

            // Find and update APPLICATION
            applicationToUpdate = db.Applications.Find(idToUpdate);
            if (applicationToUpdate != null)
            {
                applicationToUpdate.CompanyName = newCompanyName;
                applicationToUpdate.City = newCity;
                applicationToUpdate.RequiredAdditionalTools = newRequiredTools;
                applicationToUpdate.Notes = newNotes;
                if (decimal.TryParse(newSalaryHour, out decimal salaryHour))
                {
                    applicationToUpdate.SalaryPerHour = salaryHour;
                }

                if (decimal.TryParse(newSalaryYear, out decimal salaryYear))
                {
                    applicationToUpdate.SalaryPerYear = salaryYear;
                }
            }


            // Find and update STATE
            stateToUpdate = db.States.Find(idToUpdate);
            if (stateToUpdate != null)
            {
                stateToUpdate.State1 = newState;
            }


            // Find and update STATUS
            statusToUpdate = db.ApplicationStatus.Find(idToUpdate);
            if (statusToUpdate != null)
            {
                statusToUpdate.JobStatus = newStatus;
            }


            // Find and update WEBSITE
            websiteToUpdate = db.ApplicationWebsites.Find(idToUpdate);
            if (websiteToUpdate != null)
            {
                websiteToUpdate.ApplicationWebsite1 = newApplicationWebsite;
            }


            // Find and update JOB TYPE
            jobtypeToUpdate = db.JobTypes.Find(idToUpdate);
            if (jobtypeToUpdate != null)
            {
                jobtypeToUpdate.JobType1 = newJobType;
            }


            // Save changes if at least one update was successful
            try
            {
                db.SaveChanges();
                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }
    }
}