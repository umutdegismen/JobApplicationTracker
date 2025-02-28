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
using System.Windows.Forms.VisualStyles;
using System.Configuration;
using System.Xml.Serialization;

namespace JobApplicationTracker
{
    public partial class frmAddStateList : Form
    {

        public frmAddStateList()
        {
            InitializeComponent();
        }

        private void btnAddStateList_Click(object sender, EventArgs e)
        {
           if(txtStatesList.Text == "")
            {
                MessageBox.Show("Please enter a state list!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveStateList();
            }
        }

        private void saveStateList()
        {
            List<string> statesList = new List<string>();

            string statesInTxtbox = txtStatesList.Text;

            // Split the input by newline characters, trimming any leading or trailing spaces
            string[] states = statesInTxtbox.Split ( new[] { '\r', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string state in states)
            {
                statesList.Add(state);
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();
                foreach (string state in statesList)
                {
                    string query = "INSERT INTO States (State) VALUES(@stateName);";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@stateName", SqlDbType.NVarChar).Value = state;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            txtStatesList.Text = "";
            MessageBox.Show("The States are successfully added!");
            this.Close();
        }
    }
}
