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
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        // variables
        frmMain f;
        string columnNameForHourlySalary = "Hourly Salary";
        string columnNameForYearlySalary = "Annual Salary";


        private void frmOptions_Load(object sender, EventArgs e)
        {
            f = (frmMain)System.Windows.Forms.Application.OpenForms["frmMain"];

            // change the hourly salary buttons name based on the status of salary type
            if (f.dgvJobs.Columns[columnNameForHourlySalary].DefaultCellStyle.Format == "C0")
            {
                btnChangeHourly.Text = "Whole to Decimal";
            }
            else
            {
                btnChangeHourly.Text = "Decimal to Whole";
            }
            // change the yearly salary buttons name based on the status of salary type
            if (f.dgvJobs.Columns[columnNameForYearlySalary].DefaultCellStyle.Format == "C0")
            {
                btnChangeYearly.Text = "Whole to Decimal";
            }
            else
            {
                btnChangeYearly.Text = "Decimal to Whole";
            }

        }

        private void btnSalaryHour_Click(object sender, EventArgs e)
        {
            roundWholeSalary(columnNameForHourlySalary, btnChangeHourly);

        }


        private void btnChangeYearly_Click(object sender, EventArgs e)
        {
            roundWholeSalary(columnNameForYearlySalary, btnChangeYearly);
        }


        /// <summary>
        /// This method  changes the salary format (decimal to whole number or opposite).
        /// 
        /// </summary>
        /// <param name="salaryFormat"></param>
        /// <param name="btn"></param>
        public void roundWholeSalary(string salaryFormat, Button btn)
        {
            // change the format of money type column from '10.00' to '$10'
            /*
                "N0"	3000 (No decimals)
                "N2"	3000.50 (Two decimal places)
                "C"	    $3,000.50 (Currency format, based on system locale)
                "C0"	$3,000 (Currency without decimals)
             */

            if (btn.Text == "Decimal to Whole")
            {
                f.dgvJobs.Columns[salaryFormat].DefaultCellStyle.Format = "C0";
                btn.Text = "Whole to Decimal";
            }
            else
            {
                f.dgvJobs.Columns[salaryFormat].DefaultCellStyle.Format = "C";
                btn.Text = "Decimal to Whole";
            }
        }
    }
}
