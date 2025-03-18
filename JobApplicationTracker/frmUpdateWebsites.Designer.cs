namespace JobApplicationTracker
{
    partial class frmUpdateWebsites
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
            this.btnCancelWebsite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateWebsite = new System.Windows.Forms.TextBox();
            this.btnUpdateWebsite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelWebsite
            // 
            this.btnCancelWebsite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelWebsite.Location = new System.Drawing.Point(12, 120);
            this.btnCancelWebsite.Name = "btnCancelWebsite";
            this.btnCancelWebsite.Size = new System.Drawing.Size(130, 43);
            this.btnCancelWebsite.TabIndex = 20;
            this.btnCancelWebsite.Text = "Cancel";
            this.btnCancelWebsite.UseVisualStyleBackColor = true;
            this.btnCancelWebsite.Click += new System.EventHandler(this.btnCancelWebsite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter updated website:";
            // 
            // txtUpdateWebsite
            // 
            this.txtUpdateWebsite.Location = new System.Drawing.Point(12, 70);
            this.txtUpdateWebsite.Name = "txtUpdateWebsite";
            this.txtUpdateWebsite.Size = new System.Drawing.Size(422, 29);
            this.txtUpdateWebsite.TabIndex = 18;
            // 
            // btnUpdateWebsite
            // 
            this.btnUpdateWebsite.Location = new System.Drawing.Point(304, 120);
            this.btnUpdateWebsite.Name = "btnUpdateWebsite";
            this.btnUpdateWebsite.Size = new System.Drawing.Size(130, 43);
            this.btnUpdateWebsite.TabIndex = 17;
            this.btnUpdateWebsite.Text = "Update";
            this.btnUpdateWebsite.UseVisualStyleBackColor = true;
            this.btnUpdateWebsite.Click += new System.EventHandler(this.btnUpdateWebsite_Click);
            // 
            // frmUpdateWebsites
            // 
            this.AcceptButton = this.btnUpdateWebsite;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 180);
            this.Controls.Add(this.btnCancelWebsite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateWebsite);
            this.Controls.Add(this.btnUpdateWebsite);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateWebsites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateWebsites";
            this.Load += new System.EventHandler(this.frmUpdateWebsites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelWebsite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateWebsite;
        private System.Windows.Forms.Button btnUpdateWebsite;
    }
}