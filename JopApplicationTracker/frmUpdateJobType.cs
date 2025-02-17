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
    public partial class frmUpdateJobType : Form
    {

        int selectedId;

        public frmUpdateJobType(int sentId)
        {
            InitializeComponent();

            selectedId = sentId;
        }

        

        private void frmUpdateJobType_Load(object sender, EventArgs e)
        {

        }
    }
}
