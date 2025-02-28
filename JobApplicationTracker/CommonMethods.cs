using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
     

    internal class CommonMethods
    {


        /// <summary>
        /// This method numarates the rows in a DataGridView.
        /// </summary>
        /// <param name="dgv"></param>
        public static void numerateDataGridView(DataGridView dgv)
        {
            if (dgv != null)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        

        /// <summary>
        /// This method clears the columns of the provided DataGridView.
        /// </summary>
        /// <param name="dgv"></param>
        public static void dgvClear(DataGridView dgv)
        {
            dgv.Columns.Clear();
        }

    }
}
