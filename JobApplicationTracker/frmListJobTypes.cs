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
    public partial class frmListJobTypes : Form
    {
        public frmListJobTypes()
        {
            InitializeComponent();
        }


        JobApplicationDBEntities db = new JobApplicationDBEntities();
        int idToDeleteOrUpdate;

        private void frmListJopTypes_Load(object sender, EventArgs e)
        {
            listJobTypes();
        }

        public void listJobTypes()
        {
            var query = from x in db.JobTypes
                        select new
                        {
                            id = x.Id,
                            JobType = x.JobType1
                        };

            dgvJobTypes.DataSource = query.ToList();

            // dataGridView settings
            dgvJobTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobTypes.MultiSelect = false;
            dgvJobTypes.Columns[0].Visible = false;

            // add row count in the row header
            CommonMethods.numerateDataGridView(dgvJobTypes);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idToDeleteOrUpdate = Convert.ToInt32(dgvJobTypes.SelectedRows[0].Cells[0].Value);
            frmUpdateJobType f = new frmUpdateJobType(idToDeleteOrUpdate);
            f.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idToDeleteOrUpdate = Convert.ToInt32(dgvJobTypes.SelectedRows[0].Cells[0].Value);

            JobType jobTypeToDelete = db.JobTypes.Find(idToDeleteOrUpdate);
            string jobType = jobTypeToDelete.JobType1;

            DialogResult ds = MessageBox.Show("Do you want to delete '" + jobType + "'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(ds == DialogResult.Yes)
            {
                // delete the selected row and save changes to DataBase
                db.JobTypes.Remove(jobTypeToDelete);
                db.SaveChanges();

                MessageBox.Show("'" + jobType + "' is succesfully deleted!");

                // refresh the DataGridView
                CommonMethods.dgvClear(dgvJobTypes);
                listJobTypes();
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddJobType f = new frmAddJobType();
            f.ShowDialog();
        }
    }
}
