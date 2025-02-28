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
    public partial class frmListStates : Form
    {
        public frmListStates()
        {
            InitializeComponent();
        }


        JobApplicationDBEntities db = new JobApplicationDBEntities();
        int idToDeleteOrUpdate;

        private void frmListStates_Load(object sender, EventArgs e)
        {
            listStates();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idToDeleteOrUpdate = Convert.ToInt32(dgvStates.SelectedRows[0].Cells[0].Value);

            frmUpdateState f = new frmUpdateState(idToDeleteOrUpdate);
            f.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                idToDeleteOrUpdate = Convert.ToInt32(dgvStates.SelectedRows[0].Cells[0].Value);
                State stateToDelete = db.States.Find(idToDeleteOrUpdate);
                string stateToDeleteName = stateToDelete.State1;

                DialogResult ds = MessageBox.Show("Do you want to delete '" + stateToDeleteName + "'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds == DialogResult.Yes)
                {
                    // delete the selected row and save changes to DataBase
                    db.States.Remove(stateToDelete);
                    db.SaveChanges();

                    MessageBox.Show("'" + stateToDeleteName + "' is succesfully deleted!");
                    
                    // refresh the DataGridView
                    dgvStates.Columns.Clear();
                    listStates();
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
        /// 
        /// </summary>
        public void listStates()
        {
            var query = from x in db.States
                        select new
                        {
                            Id = x.Id,
                            States = x.State1
                        };

            dgvStates.DataSource = query.ToList();

            // dataGridView settings
            dgvStates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStates.MultiSelect = false;
            dgvStates.Columns[0].Visible = false;

            // add row count in the row header
            CommonMethods.numerateDataGridView(dgvStates);
        }


    }
}
