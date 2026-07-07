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
    public partial class frmListStatus : Form
    {
        public frmListStatus()
        {
            InitializeComponent();
        }

        JobApplicationDBEntities db = new JobApplicationDBEntities();

        int idToDeleteOrUpdate;

        private void frmListStatus_Load(object sender, EventArgs e)
        {
            listStatus();
        }



        /// <summary>
        /// This method lists the status.
        /// 
        /// </summary>
        public void listStatus()
        {
            var query = from x in db.ApplicationStatus
                        select new
                        {
                            id = x.id,
                            Status = x.JobStatus
                        };

            dgvStatus.DataSource = query.ToList();

            // add row count in the row header
            CommonMethods.numerateDataGridView(dgvStatus);

            // DataGridView Settings
            dgvStatus.Columns[0].Visible = false;
            dgvStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatus.MultiSelect = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                idToDeleteOrUpdate = Convert.ToInt32(dgvStatus.SelectedRows[0].Cells[0].Value);
                frmUpdateStatus f = new frmUpdateStatus(idToDeleteOrUpdate);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a 'Job Status'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idToDeleteOrUpdate = Convert.ToInt32(dgvStatus.SelectedRows[0].Cells[0].Value);
            ApplicationStatu statusToDelete = db.ApplicationStatus.Find(idToDeleteOrUpdate);
            string statusDeleteStr = statusToDelete.JobStatus;

            DialogResult ds = MessageBox.Show("Do you want to delete '" + statusDeleteStr + "' ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ds == DialogResult.Yes)
            {
                try
                {
                    db.ApplicationStatus.Remove(statusToDelete);
                    db.SaveChanges();

                    MessageBox.Show("'" + statusDeleteStr + "' is successfully deleted!");

                    dgvStatus.Columns.Clear();
                    listStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStatus f = new frmAddStatus();
            f.ShowDialog();
        }
    }
}