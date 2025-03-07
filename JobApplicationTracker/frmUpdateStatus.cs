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
    public partial class frmUpdateStatus : Form
    {
        int idToUpdateOrDelete;
        ApplicationStatu status;
        string statusBeforeUpdate;
        JobApplicationDBEntities db = new JobApplicationDBEntities();


        public frmUpdateStatus(int id)
        {
            InitializeComponent();
            idToUpdateOrDelete = id;
        }

        private void frmUpdateStatus_Load(object sender, EventArgs e)
        {
            status = db.ApplicationStatus.Find(idToUpdateOrDelete);
            txtUpdateStatus.Text = status.JobStatus;
            statusBeforeUpdate = txtUpdateStatus.Text;
        }
    }
}
