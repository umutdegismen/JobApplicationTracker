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

namespace JopApplicationTracker
{
    public partial class frmAddWebsite : Form
    {
        public frmAddWebsite()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtWebsite.Text == "")
            {
                MessageBox.Show("Please enter a website!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveWebsite();
            }
        }

        private void saveWebsite()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string query = "INSERT INTO ApplicationWebsites (ApplicationWebsite) VALUES (@WebsiteName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@WebsiteName", SqlDbType.NVarChar).Value = txtWebsite.Text;
                    cmd.ExecuteNonQuery();
                }
            }

            // UI updates after database operation
            MessageBox.Show($"{txtWebsite.Text} is added successfully!");
            txtWebsite.Text = "";
            this.Close();
        }
    }
}
