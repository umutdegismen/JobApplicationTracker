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
    public partial class frmUpdateState : Form
    {
        int selectecId;
        State stateToUpdate;
        string stateBeforeUpdate;
        string newState;
        

        public frmUpdateState(int sentId)
        {
            InitializeComponent();

            // id is coming from DataGridView row selection in frmListStates
            selectecId = sentId;
        }

        JobApplicationDBEntities db = new JobApplicationDBEntities();

        private void frmUpdateState_Load(object sender, EventArgs e)
        {
            stateToUpdate = db.States.Find(selectecId);
            txtUpdateStates.Text = stateToUpdate.State1;
            stateBeforeUpdate = txtUpdateStates.Text;
        }

        private void btnUpdateState_Click(object sender, EventArgs e)
        {
            newState = txtUpdateStates.Text;

            if (stateBeforeUpdate == newState)
            {
                DialogResult questionResult = MessageBox.Show("There is no any changes between old and new state name. \nDo you want to continue ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (questionResult == DialogResult.OK)
                {
                    save();
                }
            }
            else
            {
                save();
            }
        }

        /// <summary>
        /// This method saves changes to DataBase.
        /// 
        /// </summary>
        private void save()
        {
            // save changes to DB
            stateToUpdate.State1 = newState;
            db.SaveChanges();

            MessageBox.Show("'" + stateBeforeUpdate + "' is succesfully updated with '" + newState + "'");
            this.Close();
            
            dgvRefresh();
        }

        /// <summary>
        /// This method refreshes the DataGridView.
        /// 
        /// </summary>
        private void dgvRefresh()
        {
           
            frmListStates f = (frmListStates)System.Windows.Forms.Application.OpenForms["frmListStates"];
            f.dgvStates.Columns.Clear();
            f.listStates();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Avoid entering numbers. Allow only letters, space and backspace.
        private void txtUpdateStates_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
