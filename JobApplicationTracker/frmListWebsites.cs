using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class frmListWebsites : Form
    {
        public frmListWebsites()
        {
            InitializeComponent();
        }


        JobApplicationDBEntities db = new JobApplicationDBEntities();

        int selectedRowId;


        private void frmListWebsites_Load(object sender, EventArgs e)
        {
            listWebsites();
        }

        public void listWebsites()
        {
            var query = from x in db.ApplicationWebsites
                        select new
                        {
                            id = x.Id,
                            Websites = x.ApplicationWebsite1
                        };

            dgvWebsites.DataSource = query.ToList();


            // DataGridView settings
            dgvWebsites.Columns[0].Visible = false;
            dgvWebsites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWebsites.MultiSelect = false;
            dgvWebsites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // numarate the first column
            CommonMethods.numerateDataGridView(dgvWebsites);






        }

        /// <summary>
        /// This method lists the websites using SqlConnection ADO.NET Approach (Disconnected Data Access)
        /// 
        /// (Can be faster for large data sets)
        /// 
        /// </summary>
        public void listWebsites_AdoNet()
        {
            string connectionString = Constants.CONNECTION_STRING;

            string query = "SELECT * FROM ApplicationWebsites;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlDataAdapter adp = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dgvWebsites.DataSource = dt;

                    // dataGridView settings
                    dgvWebsites.Columns[0].Visible = false;
                    dgvWebsites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvWebsites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvWebsites.MultiSelect = false;

                    // add row count in the row header
                    CommonMethods.numerateDataGridView(dgvWebsites);

                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddWebsite f = new frmAddWebsite();
            f.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedRowId = Convert.ToInt32(dgvWebsites.SelectedRows[0].Cells[0].Value);

            frmUpdateWebsites f = new frmUpdateWebsites(selectedRowId);
            f.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedRowId = Convert.ToInt32(dgvWebsites.SelectedRows[0].Cells[0].Value);
            ApplicationWebsite selectedWebsite = db.ApplicationWebsites.Find(selectedRowId);
            string websiteName = selectedWebsite.ApplicationWebsite1;

            DialogResult ds = MessageBox.Show($"Do you want to delete '{websiteName}'", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (ds == DialogResult.OK)
            {
                try
                {
                    db.ApplicationWebsites.Remove(selectedWebsite);
                    db.SaveChanges();

                    MessageBox.Show($"'{websiteName}' is successfully deleted!");

                    dgvWebsites.Columns.Clear();
                    listWebsites();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
