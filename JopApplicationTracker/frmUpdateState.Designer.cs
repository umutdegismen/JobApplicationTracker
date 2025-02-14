namespace JopApplicationTracker
{
    partial class frmUpdateState
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateStates = new System.Windows.Forms.TextBox();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 43);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter updated state:";
            // 
            // txtUpdateStates
            // 
            this.txtUpdateStates.Location = new System.Drawing.Point(12, 65);
            this.txtUpdateStates.Name = "txtUpdateStates";
            this.txtUpdateStates.Size = new System.Drawing.Size(422, 29);
            this.txtUpdateStates.TabIndex = 9;
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.Location = new System.Drawing.Point(304, 115);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(130, 43);
            this.btnUpdateState.TabIndex = 8;
            this.btnUpdateState.Text = "Update";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            this.btnUpdateState.Click += new System.EventHandler(this.btnUpdateState_Click);
            // 
            // frmUpdateState
            // 
            this.AcceptButton = this.btnUpdateState;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(446, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateStates);
            this.Controls.Add(this.btnUpdateState);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Update Form";
            this.Load += new System.EventHandler(this.frmUpdateState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateStates;
        private System.Windows.Forms.Button btnUpdateState;
    }
}