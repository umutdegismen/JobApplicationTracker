namespace JopApplicationTracker
{
    partial class frmAddStateList
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
            this.txtStatesList = new System.Windows.Forms.TextBox();
            this.btnAddStateList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter a list of states:";
            // 
            // txtStatesList
            // 
            this.txtStatesList.Location = new System.Drawing.Point(29, 78);
            this.txtStatesList.Multiline = true;
            this.txtStatesList.Name = "txtStatesList";
            this.txtStatesList.Size = new System.Drawing.Size(383, 726);
            this.txtStatesList.TabIndex = 8;
            // 
            // btnAddStateList
            // 
            this.btnAddStateList.Location = new System.Drawing.Point(282, 820);
            this.btnAddStateList.Name = "btnAddStateList";
            this.btnAddStateList.Size = new System.Drawing.Size(130, 43);
            this.btnAddStateList.TabIndex = 7;
            this.btnAddStateList.Text = "Save";
            this.btnAddStateList.UseVisualStyleBackColor = true;
            this.btnAddStateList.Click += new System.EventHandler(this.btnAddStateList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(29, 820);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 43);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddStateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(436, 878);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatesList);
            this.Controls.Add(this.btnAddStateList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStateList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add States";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatesList;
        private System.Windows.Forms.Button btnAddStateList;
        private System.Windows.Forms.Button btnCancel;
    }
}