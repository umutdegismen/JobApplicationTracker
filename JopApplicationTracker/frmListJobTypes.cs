using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JopApplicationTracker
{
    public partial class frmListJobTypes : Form
    {
        public frmListJobTypes()
        {
            InitializeComponent();
        }


        JobApplicationDBEntities db = new JobApplicationDBEntities();

        private void frmListJopTypes_Load(object sender, EventArgs e)
        {
            listJobTypes(dgvJobTypes, db);
        }

        private static void listJobTypes(DataGridView dgv, JobApplicationDBEntities db)
        {
            var query = from x in db.JobTypes
                        select new
                        {
                            id = x.Id,
                            JobType = x.JobType1
                        };

            dgv.DataSource = query.ToList();

            // dataGridView settings
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.Columns[0].Visible = false;

            // add row count in the row header
            CommonMethods.numerateDataGridView(dgv);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idToUpdate = Convert.ToInt32(dgvJobTypes.SelectedRows[0].Cells[0]);
            frmUpdateJobType f = new frmUpdateJobType(idToUpdate);
            f.Show();
        }
    }
}
