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
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUnitOfferingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEnrolmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convenerFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAssessmentsMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAssessmentAllocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUnitOfferingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMeetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAssessmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1344, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "msEmp";
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            this.personalDetailsToolStripMenuItem.Click += new System.EventHandler(this.personalDetailsToolStripMenuItem_Click);
            // 
            // administratorFunctionsToolStripMenuItem
            // 
            this.administratorFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem,
            this.manageUnitsToolStripMenuItem,
            this.manageUnitOfferingsToolStripMenuItem,
            this.manageEnrolmentsToolStripMenuItem});
            this.administratorFunctionsToolStripMenuItem.Enabled = false;
            this.administratorFunctionsToolStripMenuItem.Name = "administratorFunctionsToolStripMenuItem";
            this.administratorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(281, 36);
            this.administratorFunctionsToolStripMenuItem.Text = "Administrator Functions";
            this.administratorFunctionsToolStripMenuItem.Click += new System.EventHandler(this.administratorFunctionsToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.manageToolStripMenuItem.Text = "Manage Students";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employees";
            // 
            // manageUnitsToolStripMenuItem
            // 
            this.manageUnitsToolStripMenuItem.Name = "manageUnitsToolStripMenuItem";
            this.manageUnitsToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.manageUnitsToolStripMenuItem.Text = "Manage Units";
            // 
            // manageUnitOfferingsToolStripMenuItem
            // 
            this.manageUnitOfferingsToolStripMenuItem.Name = "manageUnitOfferingsToolStripMenuItem";
            this.manageUnitOfferingsToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.manageUnitOfferingsToolStripMenuItem.Text = "Manage Unit Offerings";
            // 
            // manageEnrolmentsToolStripMenuItem
            // 
            this.manageEnrolmentsToolStripMenuItem.Name = "manageEnrolmentsToolStripMenuItem";
            this.manageEnrolmentsToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.manageEnrolmentsToolStripMenuItem.Text = "Manage Enrolments";
            // 
            // convenerFunctionsToolStripMenuItem
            // 
            this.convenerFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAssessmentsMasterToolStripMenuItem,
            this.manageAssessmentAllocationsToolStripMenuItem,
            this.manageTeamsToolStripMenuItem,
            this.viewUnitsToolStripMenuItem,
            this.viewUnitOfferingsToolStripMenuItem});
            this.convenerFunctionsToolStripMenuItem.Enabled = false;
            this.convenerFunctionsToolStripMenuItem.Name = "convenerFunctionsToolStripMenuItem";

            this.convenerFunctionsToolStripMenuItem.Size = new System.Drawing.Size(241, 36);
            this.convenerFunctionsToolStripMenuItem.Text = "Convenor Functions";

            this.convenerFunctionsToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.convenerFunctionsToolStripMenuItem.Text = "Convener Functions";

            // 
            // manageAssessmentsMasterToolStripMenuItem
            // 
            this.manageAssessmentsMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.allocationsToolStripMenuItem});
            this.manageAssessmentsMasterToolStripMenuItem.Name = "manageAssessmentsMasterToolStripMenuItem";
            this.manageAssessmentsMasterToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.manageAssessmentsMasterToolStripMenuItem.Text = "Manage Assessments";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // allocationsToolStripMenuItem
            // 
            this.allocationsToolStripMenuItem.Name = "allocationsToolStripMenuItem";
            this.allocationsToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.allocationsToolStripMenuItem.Text = "Allocations";
            // 
            // manageAssessmentAllocationsToolStripMenuItem
            // 
            this.manageAssessmentAllocationsToolStripMenuItem.Name = "manageAssessmentAllocationsToolStripMenuItem";

            this.manageAssessmentAllocationsToolStripMenuItem.Size = new System.Drawing.Size(318, 36);

            this.manageAssessmentAllocationsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.manageAssessmentAllocationsToolStripMenuItem.Text = "Manage Projects";
            // 
            // manageTeamsToolStripMenuItem
            // 
            this.manageTeamsToolStripMenuItem.Name = "manageTeamsToolStripMenuItem";
            this.manageTeamsToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.manageTeamsToolStripMenuItem.Text = "Manage Teams";
            // 
            // viewUnitsToolStripMenuItem
            // 
            this.viewUnitsToolStripMenuItem.Name = "viewUnitsToolStripMenuItem";
            this.viewUnitsToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.viewUnitsToolStripMenuItem.Text = "View Units";
            // 
            // viewUnitOfferingsToolStripMenuItem
            // 
            this.viewUnitOfferingsToolStripMenuItem.Name = "viewUnitOfferingsToolStripMenuItem";
            this.viewUnitOfferingsToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.viewUnitOfferingsToolStripMenuItem.Text = "View Unit Offerings";
            // 
            // supervisorFunctionsToolStripMenuItem
            // 
            this.supervisorFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageMeetingsToolStripMenuItem,
            this.viewAssessmentsToolStripMenuItem,
            this.viewTeamsToolStripMenuItem,
            this.viewProjectsToolStripMenuItem});

            this.supervisorFunctionsToolStripMenuItem.Enabled = false;
            this.supervisorFunctionsToolStripMenuItem.Name = "supervisorFunctionsToolStripMenuItem";
            this.supervisorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.supervisorFunctionsToolStripMenuItem.Text = "Supervisor Functions";

            this.supervisorFunctionsToolStripMenuItem.Name = "supervisorFunctionsToolStripMenuItem";
            this.supervisorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.supervisorFunctionsToolStripMenuItem.Text = "Supervisor Functions";
            // 
            // manageMeetingsToolStripMenuItem
            // 
            this.manageMeetingsToolStripMenuItem.Name = "manageMeetingsToolStripMenuItem";
            this.manageMeetingsToolStripMenuItem.Size = new System.Drawing.Size(284, 36);
            this.manageMeetingsToolStripMenuItem.Text = "Manage Meetings";
            this.manageMeetingsToolStripMenuItem.Click += new System.EventHandler(this.manageMeetingsToolStripMenuItem_Click);
            // 
            // viewAssessmentsToolStripMenuItem
            // 
            this.viewAssessmentsToolStripMenuItem.Name = "viewAssessmentsToolStripMenuItem";
            this.viewAssessmentsToolStripMenuItem.Size = new System.Drawing.Size(284, 36);
            this.viewAssessmentsToolStripMenuItem.Text = "View Assessments";
            // 
            // viewTeamsToolStripMenuItem
            // 
            this.viewTeamsToolStripMenuItem.Name = "viewTeamsToolStripMenuItem";
            this.viewTeamsToolStripMenuItem.Size = new System.Drawing.Size(284, 36);
            this.viewTeamsToolStripMenuItem.Text = "View Teams";
            // 
            // viewProjectsToolStripMenuItem
            // 
            this.viewProjectsToolStripMenuItem.Name = "viewProjectsToolStripMenuItem";
            this.viewProjectsToolStripMenuItem.Size = new System.Drawing.Size(284, 36);
            this.viewProjectsToolStripMenuItem.Text = "View Projects";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmEmpDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 898);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEmpDashboard";
            this.Text = "frmEmpDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUnitOfferingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEnrolmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAssessmentsMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAssessmentAllocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUnitOfferingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMeetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAssessmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProjectsToolStripMenuItem;
    }
}