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





        // ------------------------ Methods ------------------------


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
            idToDeleteOrUpdate = Convert.ToInt32(dgvStatus.SelectedRows[0].Cells[0].Value);

            frmUpdateStatus f = new frmUpdateStatus(idToDeleteOrUpdate);
            f.Show();
        }
    }
}
