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
    public partial class frmUpdateWebsites : Form
    {
        public frmUpdateWebsites(int sentId)
        {
            InitializeComponent();
            idToDeleteUpdate = sentId;
        }


        JobApplicationDBEntities db = new JobApplicationDBEntities();
        int idToDeleteUpdate;
        ApplicationWebsite website;
        string oldWebsiteName;
        string updatedWebsiteName;


        private void frmUpdateWebsites_Load(object sender, EventArgs e)
        {

            website = db.ApplicationWebsites.Find(idToDeleteUpdate);
            txtUpdateWebsite.Text = website.ApplicationWebsite1;
            oldWebsiteName = txtUpdateWebsite.Text;
        }

        private void btnCancelWebsite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateWebsite_Click(object sender, EventArgs e)
        {
            updatedWebsiteName = txtUpdateWebsite.Text;

            if(updatedWebsiteName == oldWebsiteName)
            {
                DialogResult ds = MessageBox.Show("There is no any changes between old and new entered website. \nDo you want to continue ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(ds == DialogResult.OK)
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
        /// This method saves changes in Database
        /// Closes the Update Website form
        /// Refreshes the DataGridView
        /// 
        /// </summary>
        public void save()
        {
            website.ApplicationWebsite1 = updatedWebsiteName;
            db.SaveChanges();

            MessageBox.Show($"'{oldWebsiteName}' is successfully updated with '{updatedWebsiteName}'!");
            this.Close();
            dgvRefresh();
        }

        public void dgvRefresh()
        {
            frmListWebsites f = (frmListWebsites)System.Windows.Forms.Application.OpenForms["frmListWebsites"];
            f.dgvWebsites.Columns.Clear();
            f.listWebsites();
        }
    }
}
