using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class frmAddWebsite : Form
    {
        public frmAddWebsite()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtWebsite.Text == "")
            {
                MessageBox.Show("Please enter a website!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveWebsite();
                listWebsites();
            }
        }

        private void saveWebsite()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string query = "INSERT INTO ApplicationWebsites (ApplicationWebsite) VALUES (@WebsiteName);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (txtWebsite.Text.Length > 20)
                    {
                        MessageBox.Show("Website name is too long! Please enter a shorter one.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtWebsite.Text = "";
                        return;
                    }
                    else
                    {
                        try
                        {
                            cmd.Parameters.Add("@WebsiteName", SqlDbType.NVarChar).Value = txtWebsite.Text;
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
            MessageBox.Show($"{txtWebsite.Text} is successfully added!");
            txtWebsite.Text = "";
            this.Close();
        }


        public void listWebsites()
        {
            frmListWebsites f = (frmListWebsites)System.Windows.Forms.Application.OpenForms["frmListWebsites"];
            f.dgvWebsites.Columns.Clear();
            f.listWebsites();
        }
    }
}
