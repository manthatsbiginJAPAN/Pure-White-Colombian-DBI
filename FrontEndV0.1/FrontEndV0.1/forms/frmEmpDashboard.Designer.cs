namespace FrontEndV0._1.forms
{
    partial class frmEmpDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convenerFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDetailsToolStripMenuItem,
            this.administratorFunctionsToolStripMenuItem,
            this.convenerFunctionsToolStripMenuItem,
            this.supervisorFunctionsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "msEmp";
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            this.personalDetailsToolStripMenuItem.Click += new System.EventHandler(this.personalDetailsToolStripMenuItem_Click);
            // 
            // administratorFunctionsToolStripMenuItem
            // 
            this.administratorFunctionsToolStripMenuItem.Name = "administratorFunctionsToolStripMenuItem";
            this.administratorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(225, 29);
            this.administratorFunctionsToolStripMenuItem.Text = "Administrator Functions";
            this.administratorFunctionsToolStripMenuItem.Click += new System.EventHandler(this.administratorFunctionsToolStripMenuItem_Click);
            // 
            // convenerFunctionsToolStripMenuItem
            // 
            this.convenerFunctionsToolStripMenuItem.Name = "convenerFunctionsToolStripMenuItem";
            this.convenerFunctionsToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.convenerFunctionsToolStripMenuItem.Text = "Convener Functions";
            this.convenerFunctionsToolStripMenuItem.Click += new System.EventHandler(this.convenerFunctionsToolStripMenuItem_Click);
            // 
            // supervisorFunctionsToolStripMenuItem
            // 
            this.supervisorFunctionsToolStripMenuItem.Name = "supervisorFunctionsToolStripMenuItem";
            this.supervisorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.supervisorFunctionsToolStripMenuItem.Text = "Supervisor Functions";
            this.supervisorFunctionsToolStripMenuItem.Click += new System.EventHandler(this.supervisorFunctionsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmEmpDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmpDashboard";
            this.Text = "frmEmpDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convenerFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}