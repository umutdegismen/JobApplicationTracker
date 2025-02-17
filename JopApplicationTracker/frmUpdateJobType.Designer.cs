namespace JopApplicationTracker
{
    partial class frmUpdateJobType
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
            this.txtUpdateStates = new System.Windows.Forms.TextBox();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUpdate.Location = new System.Drawing.Point(12, 113);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(156, 43);
            this.btnCancelUpdate.TabIndex = 16;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter updated state:";
            // 
            // txtUpdateStates
            // 
            this.txtUpdateStates.Location = new System.Drawing.Point(12, 63);
            this.txtUpdateStates.Name = "txtUpdateStates";
            this.txtUpdateStates.Size = new System.Drawing.Size(514, 29);
            this.txtUpdateStates.TabIndex = 14;
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.Location = new System.Drawing.Point(370, 113);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(156, 43);
            this.btnUpdateState.TabIndex = 13;
            this.btnUpdateState.Text = "Update";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            // 
            // frmUpdateJobType
            // 
            this.AcceptButton = this.btnUpdateState;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelUpdate;
            this.ClientSize = new System.Drawing.Size(538, 180);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateStates);
            this.Controls.Add(this.btnUpdateState);
            this.Name = "frmUpdateJobType";
            this.Text = "Job Type Update Form";
            this.Load += new System.EventHandler(this.frmUpdateJobType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateStates;
        private System.Windows.Forms.Button btnUpdateState;
    }
}