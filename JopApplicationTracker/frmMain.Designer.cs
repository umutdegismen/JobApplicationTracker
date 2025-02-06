namespace JopApplicationTracker
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
            this.btnAddJob = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEnvironmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationWebsitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workEnvironmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddState = new System.Windows.Forms.Button();
            this.btnWebsite = new System.Windows.Forms.Button();
            this.btnAddJobType = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.seeTheStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddJob
            // 
            this.btnAddJob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddJob.Location = new System.Drawing.Point(937, 1103);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(276, 75);
            this.btnAddJob.TabIndex = 0;
            this.btnAddJob.Text = "New Application";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // dgvJobs
            // 
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(12, 55);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 72;
            this.dgvJobs.RowTemplate.Height = 31;
            this.dgvJobs.Size = new System.Drawing.Size(2127, 1016);
            this.dgvJobs.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
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
            this.newStateToolStripMenuItem,
            this.newWebsiteToolStripMenuItem,
            this.newEnvironmentToolStripMenuItem,
            this.newToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.exitToolStripMenuItem.Text = "Add";
            // 
            // newJobToolStripMenuItem
            // 
            this.newJobToolStripMenuItem.Name = "newJobToolStripMenuItem";
            this.newJobToolStripMenuItem.Size = new System.Drawing.Size(374, 40);
            this.newJobToolStripMenuItem.Text = "New Application..";
            this.newJobToolStripMenuItem.Click += new System.EventHandler(this.newJobToolStripMenuItem_Click);
            // 
            // newStateToolStripMenuItem
            // 
            this.newStateToolStripMenuItem.Name = "newStateToolStripMenuItem";
            this.newStateToolStripMenuItem.Size = new System.Drawing.Size(374, 40);
            this.newStateToolStripMenuItem.Text = "New State..";
            this.newStateToolStripMenuItem.Click += new System.EventHandler(this.newStateToolStripMenuItem_Click);
            // 
            // newWebsiteToolStripMenuItem
            // 
            this.newWebsiteToolStripMenuItem.Name = "newWebsiteToolStripMenuItem";
            this.newWebsiteToolStripMenuItem.Size = new System.Drawing.Size(374, 40);
            this.newWebsiteToolStripMenuItem.Text = "New Application Website..";
            this.newWebsiteToolStripMenuItem.Click += new System.EventHandler(this.newWebsiteToolStripMenuItem_Click);
            // 
            // newEnvironmentToolStripMenuItem
            // 
            this.newEnvironmentToolStripMenuItem.Name = "newEnvironmentToolStripMenuItem";
            this.newEnvironmentToolStripMenuItem.Size = new System.Drawing.Size(374, 40);
            this.newEnvironmentToolStripMenuItem.Text = "New Job Type..";
            this.newEnvironmentToolStripMenuItem.Click += new System.EventHandler(this.newEnvironmentToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(374, 40);
            this.newToolStripMenuItem.Text = "New Status..";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statesToolStripMenuItem,
            this.applicationWebsitesToolStripMenuItem,
            this.workEnvironmentsToolStripMenuItem,
            this.seeTheStatusToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statesToolStripMenuItem
            // 
            this.statesToolStripMenuItem.Name = "statesToolStripMenuItem";
            this.statesToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.statesToolStripMenuItem.Text = "State List";
            // 
            // applicationWebsitesToolStripMenuItem
            // 
            this.applicationWebsitesToolStripMenuItem.Name = "applicationWebsitesToolStripMenuItem";
            this.applicationWebsitesToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.applicationWebsitesToolStripMenuItem.Text = "Website List";
            // 
            // workEnvironmentsToolStripMenuItem
            // 
            this.workEnvironmentsToolStripMenuItem.Name = "workEnvironmentsToolStripMenuItem";
            this.workEnvironmentsToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.workEnvironmentsToolStripMenuItem.Text = "Job Types List";
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
            // btnAddState
            // 
            this.btnAddState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddState.Location = new System.Drawing.Point(1696, 1125);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(136, 53);
            this.btnAddState.TabIndex = 3;
            this.btnAddState.Text = "Add State";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // btnWebsite
            // 
            this.btnWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWebsite.Location = new System.Drawing.Point(1554, 1125);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Size = new System.Drawing.Size(136, 53);
            this.btnWebsite.TabIndex = 4;
            this.btnWebsite.Text = "Add Website";
            this.btnWebsite.UseVisualStyleBackColor = true;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // btnAddJobType
            // 
            this.btnAddJobType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJobType.Location = new System.Drawing.Point(1980, 1125);
            this.btnAddJobType.Name = "btnAddJobType";
            this.btnAddJobType.Size = new System.Drawing.Size(159, 53);
            this.btnAddJobType.TabIndex = 6;
            this.btnAddJobType.Text = "Add Job Type";
            this.btnAddJobType.UseVisualStyleBackColor = true;
            this.btnAddJobType.Click += new System.EventHandler(this.btnAddJobType_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatus.Location = new System.Drawing.Point(1838, 1125);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(136, 53);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "Add Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // seeTheStatusToolStripMenuItem
            // 
            this.seeTheStatusToolStripMenuItem.Name = "seeTheStatusToolStripMenuItem";
            this.seeTheStatusToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.seeTheStatusToolStripMenuItem.Text = "Status List";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2151, 1202);
            this.Controls.Add(this.btnAddJobType);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.btnAddState);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationWebsitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workEnvironmentsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.Button btnWebsite;
        private System.Windows.Forms.ToolStripMenuItem newEnvironmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button btnAddJobType;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.ToolStripMenuItem seeTheStatusToolStripMenuItem;
    }
}