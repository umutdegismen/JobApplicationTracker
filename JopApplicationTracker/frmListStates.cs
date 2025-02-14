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
    public partial class frmListStates : Form
    {
        public frmListStates()
        {
            InitializeComponent();
        }


        JobApplicationDBEntities db = new JobApplicationDBEntities();


        private void frmListStates_Load(object sender, EventArgs e)
        {
            listStates(dgvStates, db);
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvStates.SelectedRows[0].Cells[0].Value);

            frmUpdateState f = new frmUpdateState(id);
            f.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idToDelete = Convert.ToInt32(dgvStates.SelectedRows[0].Cells[0].Value);
                State stateToDelete = db.States.Find(idToDelete);
                string stateToDeleteName = stateToDelete.State1;

                DialogResult ds = MessageBox.Show("Do you want to delete '" + stateToDeleteName + "'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds == DialogResult.Yes)
                {
                    // save changes to DataBase
                    db.States.Remove(stateToDelete);
                    db.SaveChanges();

                    MessageBox.Show("'" + stateToDeleteName + "' is succesfully deleted!");
                    
                    // refresh the DataGridView
                    dgvStates.Columns.Clear();
                    listStates(dgvStates, db);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // ------------------------ Methods ------------------------


        /// <summary>
        /// This method lists the states.
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="db"></param>
        public static void listStates(DataGridView dgv, JobApplicationDBEntities db)
        {
            var query = from x in db.States
                        select new
                        {
                            Id = x.Id,
                            States = x.State1
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


    }
}
