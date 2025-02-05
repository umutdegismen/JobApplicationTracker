using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Migrations.Model;

namespace JopApplicationTracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnAddJob_Click(object sender, EventArgs e)
        {
            frmAddApplication f = new frmAddApplication();
            f.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hitch your wagon to a star 🫵🤘 \nVersion 5.2.0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddApplication f = new frmAddApplication();
            f.ShowDialog();
        }

        private void newStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddState f = new frmAddState();
            f.ShowDialog();
        }

        private void newWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddWebsite f = new frmAddWebsite();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fillUpDgvJobs();
        }

        public void fillUpDgvJobs()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            string query = "SELECT * FROM Applications a INNER JOIN States s ON a.StateId = s.Id INNER JOIN WorkEnvironments w ON a.WorkEnvironmentId = w.Id INNER JOIN ApplicationWebsites aw ON a.ApplicationWebsiteId = aw.Id;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvJobs.DataSource = dt;

            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            frmAddState f = new frmAddState();
            f.ShowDialog();
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            frmAddWebsite f = new frmAddWebsite();
            f.ShowDialog();
        }
    }
}
