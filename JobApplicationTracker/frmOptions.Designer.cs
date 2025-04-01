namespace JobApplicationTracker
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChangeHourly = new System.Windows.Forms.Button();
            this.btnChangeYearly = new System.Windows.Forms.Button();
            this.grpSalary = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeHourly
            // 
            this.btnChangeHourly.Location = new System.Drawing.Point(11, 168);
            this.btnChangeHourly.Name = "btnChangeHourly";
            this.btnChangeHourly.Size = new System.Drawing.Size(404, 52);
            this.btnChangeHourly.TabIndex = 1;
            this.btnChangeHourly.UseVisualStyleBackColor = true;
            this.btnChangeHourly.Click += new System.EventHandler(this.btnSalaryHour_Click);
            // 
            // btnChangeYearly
            // 
            this.btnChangeYearly.Location = new System.Drawing.Point(6, 315);
            this.btnChangeYearly.Name = "btnChangeYearly";
            this.btnChangeYearly.Size = new System.Drawing.Size(409, 52);
            this.btnChangeYearly.TabIndex = 2;
            this.btnChangeYearly.UseVisualStyleBackColor = true;
            this.btnChangeYearly.Click += new System.EventHandler(this.btnChangeYearly_Click);
            // 
            // grpSalary
            // 
            this.grpSalary.Controls.Add(this.label3);
            this.grpSalary.Controls.Add(this.label2);
            this.grpSalary.Controls.Add(this.label1);
            this.grpSalary.Controls.Add(this.btnChangeYearly);
            this.grpSalary.Controls.Add(this.btnChangeHourly);
            this.grpSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalary.Location = new System.Drawing.Point(12, 21);
            this.grpSalary.Name = "grpSalary";
            this.grpSalary.Size = new System.Drawing.Size(421, 373);
            this.grpSalary.TabIndex = 4;
            this.grpSalary.TabStop = false;
            this.grpSalary.Text = "Round Salary to Whole Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Annual Salary Format:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change Hourly Salary Format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 5;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 403);
            this.Controls.Add(this.grpSalary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.grpSalary.ResumeLayout(false);
            this.grpSalary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeHourly;
        private System.Windows.Forms.Button btnChangeYearly;
        private System.Windows.Forms.GroupBox grpSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}