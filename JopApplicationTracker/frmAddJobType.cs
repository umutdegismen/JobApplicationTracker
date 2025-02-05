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
    public partial class frmAddJobType : Form
    {
        public frmAddJobType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtJobType.Text == "")
            {
                MessageBox.Show("Please enter a job type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveJobType();
            }
        }

        private void saveJobType()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            string query = "INSERT INTO JobTypes (JobType) VALUES (@JobType)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@JobType", SqlDbType.NVarChar).Value = txtJobType.Text;
                    cmd.ExecuteNonQuery();
                }
            }

            // UI updates after database operation
            MessageBox.Show($"{txtJobType.Text} is added successfully!");
            txtJobType.Text = "";  
            this.Close();
        }
    }
}
