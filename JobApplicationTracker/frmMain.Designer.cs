namespace JobApplicationTracker
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEnvironmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeTheStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationWebsitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workEnvironmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvJobs.Location = new System.Drawing.Point(12, 55);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 72;
            this.dgvJobs.RowTemplate.Height = 31;
            this.dgvJobs.Size = new System.Drawing.Size(2127, 1016);
            this.dgvJobs.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(271, 150);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2151, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJobToolStripMenuItem,
            this.newEnvironmentToolStripMenuItem,
            this.newToolStripMenuItem,
            this.newStateToolStripMenuItem,
            this.newWebsiteToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 40);
            this.exitToolStripMenuItem.Text = "New";
            // 
            // newJobToolStripMenuItem
            // 
            this.newJobToolStripMenuItem.Name = "newJobToolStripMenuItem";
            this.newJobToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.newJobToolStripMenuItem.Text = "Application...";
            this.newJobToolStripMenuItem.Click += new System.EventHandler(this.newJobToolStripMenuItem_Click);
            // 
            // newEnvironmentToolStripMenuItem
            // 
            this.newEnvironmentToolStripMenuItem.Name = "newEnvironmentToolStripMenuItem";
            this.newEnvironmentToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.newEnvironmentToolStripMenuItem.Text = "Job Type...";
            this.newEnvironmentToolStripMenuItem.Click += new System.EventHandler(this.newEnvironmentToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.newToolStripMenuItem.Text = "Status...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newStateToolStripMenuItem
            // 
            this.newStateToolStripMenuItem.Name = "newStateToolStripMenuItem";
            this.newStateToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.newStateToolStripMenuItem.Text = "State...";
            this.newStateToolStripMenuItem.Click += new System.EventHandler(this.newStateToolStripMenuItem_Click);
            // 
            // newWebsiteToolStripMenuItem
            // 
            this.newWebsiteToolStripMenuItem.Name = "newWebsiteToolStripMenuItem";
            this.newWebsiteToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.newWebsiteToolStripMenuItem.Text = "Website...";
            this.newWebsiteToolStripMenuItem.Click += new System.EventHandler(this.newWebsiteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(173, 40);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeTheStatusToolStripMenuItem,
            this.statesToolStripMenuItem,
            this.applicationWebsitesToolStripMenuItem,
            this.workEnvironmentsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // seeTheStatusToolStripMenuItem
            // 
            this.seeTheStatusToolStripMenuItem.Name = "seeTheStatusToolStripMenuItem";
            this.seeTheStatusToolStripMenuItem.Size = new System.Drawing.Size(221, 40);
            this.seeTheStatusToolStripMenuItem.Text = "Status";
            this.seeTheStatusToolStripMenuItem.Click += new System.EventHandler(this.seeTheStatusToolStripMenuItem_Click);
            // 
            // statesToolStripMenuItem
            // 
            this.statesToolStripMenuItem.Name = "statesToolStripMenuItem";
            this.statesToolStripMenuItem.Size = new System.Drawing.Size(221, 40);
            this.statesToolStripMenuItem.Text = "States";
            this.statesToolStripMenuItem.Click += new System.EventHandler(this.statesToolStripMenuItem_Click);
            // 
            // applicationWebsitesToolStripMenuItem
            // 
            this.applicationWebsitesToolStripMenuItem.Name = "applicationWebsitesToolStripMenuItem";
            this.applicationWebsitesToolStripMenuItem.Size = new System.Drawing.Size(221, 40);
            this.applicationWebsitesToolStripMenuItem.Text = "Websites";
            this.applicationWebsitesToolStripMenuItem.Click += new System.EventHandler(this.applicationWebsitesToolStripMenuItem_Click);
            // 
            // workEnvironmentsToolStripMenuItem
            // 
            this.workEnvironmentsToolStripMenuItem.Name = "workEnvironmentsToolStripMenuItem";
            this.workEnvironmentsToolStripMenuItem.Size = new System.Drawing.Size(221, 40);
            this.workEnvironmentsToolStripMenuItem.Text = "Job Types";
            this.workEnvironmentsToolStripMenuItem.Click += new System.EventHandler(this.workEnvironmentsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(219, 40);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(188, 40);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddJob.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddJob.Location = new System.Drawing.Point(866, 1103);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(419, 75);
            this.btnAddJob.TabIndex = 4;
            this.btnAddJob.Text = "New Application";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2151, 1202);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job Applications";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationWebsitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workEnvironmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEnvironmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeTheStatusToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddJob;
    }
}