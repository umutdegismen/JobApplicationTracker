using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class frmUpdateJobType : Form
    {

        JobApplicationDBEntities db = new JobApplicationDBEntities();
        JobType jobTypeToUpdate;
        int selectedId;
        string jobTypeBeforeUpdate;
        string newJobType;


        public frmUpdateJobType(int sentId)
        {
            InitializeComponent();

            // id is coming from DataGridView row selection in frmListJobTypes
            selectedId = sentId;
        }



        private void frmUpdateJobType_Load(object sender, EventArgs e)
        {
            jobTypeToUpdate = db.JobTypes.Find(selectedId);
            txtUpdateJobType.Text = jobTypeToUpdate.JobType1;
            jobTypeBeforeUpdate = txtUpdateJobType.Text;
        }

        private void btnUpdateJobType_Click(object sender, EventArgs e)
        {
            jobTypeToUpdate = db.JobTypes.Find(selectedId);


            newJobType = txtUpdateJobType.Text;

            if (jobTypeBeforeUpdate == newJobType)
            {
                DialogResult questionResult = MessageBox.Show("There is no any changes between old and new Job Type. \nDo you want to continue ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (questionResult == DialogResult.OK)
                {
                    saveChanges();
                }
            }
            else
            {
                saveChanges();
            }
        }

        /// <summary>
        /// This method saves changes to DataBase.
        /// 
        /// </summary>
        private void saveChanges()
        {
            jobTypeToUpdate.JobType1 = newJobType;

            db.SaveChanges();

            MessageBox.Show("'" + jobTypeBeforeUpdate + "' is succesfully updated with '" + newJobType + "'");
            this.Close();

            dgvRefresh();
        }
        /// <summary>
        /// This method refreshes the DataGridView.
        /// 
        /// </summary>
        private void dgvRefresh()
        {
            frmListJobTypes f = (frmListJobTypes)System.Windows.Forms.Application.OpenForms["frmListJobTypes"];
            f.dgvJobTypes.Columns.Clear();
            f.listJobTypes();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Avoid entering numbers.Allow only letters and backspace.
        private void txtUpdateJobType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
