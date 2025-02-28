namespace JobApplicationTracker
{
    partial class frmAddState
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStates = new System.Windows.Forms.TextBox();
            this.btnAddStateList = new System.Windows.Forms.Button();
            this.btnStateList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a state:";
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(12, 72);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(422, 29);
            this.txtStates.TabIndex = 4;
            // 
            // btnAddStateList
            // 
            this.btnAddStateList.Location = new System.Drawing.Point(304, 118);
            this.btnAddStateList.Name = "btnAddStateList";
            this.btnAddStateList.Size = new System.Drawing.Size(130, 43);
            this.btnAddStateList.TabIndex = 3;
            this.btnAddStateList.Text = "Save";
            this.btnAddStateList.UseVisualStyleBackColor = true;
            this.btnAddStateList.Click += new System.EventHandler(this.btnAddStateList_Click);
            // 
            // btnStateList
            // 
            this.btnStateList.Location = new System.Drawing.Point(12, 117);
            this.btnStateList.Name = "btnStateList";
            this.btnStateList.Size = new System.Drawing.Size(192, 88);
            this.btnStateList.TabIndex = 6;
            this.btnStateList.Text = "Add List of States";
            this.btnStateList.UseVisualStyleBackColor = true;
            this.btnStateList.Click += new System.EventHandler(this.btnStateList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddState
            // 
            this.AcceptButton = this.btnAddStateList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(446, 217);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStateList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStates);
            this.Controls.Add(this.btnAddStateList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add State";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStates;
        private System.Windows.Forms.Button btnAddStateList;
        private System.Windows.Forms.Button btnStateList;
        private System.Windows.Forms.Button btnCancel;
    }
}