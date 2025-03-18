using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class frmAddState : Form
    {
        public frmAddState()
        {
            InitializeComponent();
        }

        private void btnAddStateList_Click(object sender, EventArgs e)
        {
            if(txtStates.Text == "")
            {
                MessageBox.Show("Please enter a state name!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveState();
            }
        }

        public void saveState()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string query = "INSERT INTO States (State) VALUES(@stateName);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (txtStates.Text.Length > 20)
                    {
                        MessageBox.Show("Website name is too long! Please enter a shorter name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStates.Text = "";
                        return;
                    }
                    else
                    {
                        try
                        {
                            cmd.Parameters.Add("@stateName", SqlDbType.NVarChar).Value = txtStates.Text;
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                    }
                }
            }

            // UI updates after database operation
            MessageBox.Show($"{txtStates.Text} is successfully added!");
            txtStates.Text = "";
            this.Close();
            dgvRefresh();
        }

        private void btnStateList_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddStateList f = new frmAddStateList();
            f.ShowDialog();
        }

        private void dgvRefresh()
        {
            frmListStates f = (frmListStates)System.Windows.Forms.Application.OpenForms["frmListStates"];
            f.dgvStates.Columns.Clear();
            f.listStates();
        }
    }
}
