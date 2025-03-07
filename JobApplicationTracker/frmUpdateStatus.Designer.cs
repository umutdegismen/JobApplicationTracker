namespace JobApplicationTracker
{
    partial class frmUpdateStatus
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
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateStatus = new System.Windows.Forms.TextBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUpdate.Location = new System.Drawing.Point(12, 117);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(130, 43);
            this.btnCancelUpdate.TabIndex = 16;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter updated status:";
            // 
            // txtUpdateStatus
            // 
            this.txtUpdateStatus.Location = new System.Drawing.Point(12, 67);
            this.txtUpdateStatus.Name = "txtUpdateStatus";
            this.txtUpdateStatus.Size = new System.Drawing.Size(422, 29);
            this.txtUpdateStatus.TabIndex = 14;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(304, 117);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(130, 43);
            this.btnUpdateStatus.TabIndex = 13;
            this.btnUpdateStatus.Text = "Update";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // frmUpdateStatus
            // 
            this.AcceptButton = this.btnUpdateStatus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelUpdate;
            this.ClientSize = new System.Drawing.Size(446, 180);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateStatus);
            this.Controls.Add(this.btnUpdateStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status Update Form";
            this.Load += new System.EventHandler(this.frmUpdateStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}