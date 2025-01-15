namespace JopApplicationTracker
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a state or a list of states:";
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(12, 70);
            this.txtStates.Multiline = true;
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(532, 533);
            this.txtStates.TabIndex = 4;
            // 
            // btnAddStateList
            // 
            this.btnAddStateList.Location = new System.Drawing.Point(96, 623);
            this.btnAddStateList.Name = "btnAddStateList";
            this.btnAddStateList.Size = new System.Drawing.Size(364, 73);
            this.btnAddStateList.TabIndex = 3;
            this.btnAddStateList.Text = "Save";
            this.btnAddStateList.UseVisualStyleBackColor = true;
            // 
            // frmAddState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStates);
            this.Controls.Add(this.btnAddStateList);
            this.MaximizeBox = false;
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
    }
}