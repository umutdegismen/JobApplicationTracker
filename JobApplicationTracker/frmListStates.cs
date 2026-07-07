using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
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
            try
            {
                idToDeleteOrUpdate = Convert.ToInt32(dgvStates.SelectedRows[0].Cells[0].Value);

                frmUpdateState f = new frmUpdateState(idToDeleteOrUpdate);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a 'State'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                MessageBox.Show("Please select a 'State'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        // ------------------------ Methods ------------------------


        /// <summary>
        /// This method lists the states using Entity Framework (LINQ to Entities).
        /// 
        /// (Can be slower for large data sets)
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

        /// <summary>
        /// This method lists the states using SqlConnection ADO.NET Approach (Disconnected Data Access)
        /// 
        /// (Can be faster for large data sets)
        /// 
        /// </summary>
        public void listStates_AdoNet()
        {
            string connectionString = Constants.CONNECTION_STRING;

            string query = "SELECT * FROM States";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvStates.DataSource = dt;

                    // DataGriidView settings
                    dgvStates.Columns[0].Visible = false;
                    dgvStates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvStates.MultiSelect = false;

                    // add row count in the row header
                    CommonMethods.numerateDataGridView(dgvStates);
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddState f = new frmAddState();
            f.ShowDialog();
        }
    }
}
