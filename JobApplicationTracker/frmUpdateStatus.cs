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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace JobApplicationTracker
{
    public partial class frmUpdateStatus : Form
    {
        int idToUpdateOrDelete;
        ApplicationStatu status;
        string statusBeforeUpdate;
        string updatedStatus;


        JobApplicationDBEntities db = new JobApplicationDBEntities();


        public frmUpdateStatus(int id)
        {
            InitializeComponent();
            idToUpdateOrDelete = id;
        }

        private void frmUpdateStatus_Load(object sender, EventArgs e)
        {
            status = db.ApplicationStatus.Find(idToUpdateOrDelete);
            txtUpdateStatus.Text = status.JobStatus;
            statusBeforeUpdate = txtUpdateStatus.Text;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            updatedStatus = txtUpdateStatus.Text;
            if (statusBeforeUpdate == updatedStatus)
            {
                DialogResult ds = MessageBox.Show("There is no any changes between old and new entered status. \nDo you want to continue ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (ds == DialogResult.OK)
                {
                    save();
                }
            }
            else
            {
                save();
            }

        }

        /// <summary>
        /// This method saves the changes in DataBase
        /// Closes the Update States Form
        /// Refreshes the DataGrodView
        /// 
        /// </summary>
        private void save()
        {
            status.JobStatus = updatedStatus;
            db.SaveChanges();

            MessageBox.Show("'" + statusBeforeUpdate + "' is succesfully updated with '" + updatedStatus + "'");
            this.Close();

            dgvRefresh();

        }

        private void dgvRefresh()
        {
            frmListStatus f = (frmListStatus)System.Windows.Forms.Application.OpenForms["frmListStatus"];
            f.dgvStatus.Columns.Clear();
            f.listStatus();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
