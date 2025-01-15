using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JopApplicationTracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddApplication f = new frmAddApplication();
            f.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hitch your wagon to a star 🫵🤘 \nv1.0.0","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
