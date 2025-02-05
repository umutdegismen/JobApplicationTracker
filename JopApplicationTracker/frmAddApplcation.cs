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
    public partial class frmAddApplication : Form
    {
        public frmAddApplication()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            saveApplication();
        }

        private void saveApplication()
        {

        }
        // 1. query
        // 2. column name
        // 
        private void frmAddApplication_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            string loadStateQuery = "SELECT * FROM States";
            string loadWorkEnvironmentQuery = "SELECT * FROM WorkEnvironments";
            string loadWebsiteQuery = "SELECT * FROM ApplicationWebsites";
            string loadStatusQuery = "SELECT * FROM Status";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                
                using (SqlDataAdapter adp = new SqlDataAdapter(loadStateQuery, connectionString))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    foreach (DataRow item in dt.Rows)
                    {
                        cmbState.Items.Add(item["State"].ToString());
                    }

                }
            }
        }
    }
}
