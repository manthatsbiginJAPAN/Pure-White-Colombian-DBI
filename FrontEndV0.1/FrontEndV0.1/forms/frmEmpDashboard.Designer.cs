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
            this.convenorFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.convenorFunctionsToolStripMenuItem,
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
            this.personalDetailsToolStripMenuItem.Click += new System.EventHandler(this.personalDetailsMenu_Click);
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
            this.administratorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(225, 29);
            this.administratorFunctionsToolStripMenuItem.Text = "Administrator Functions";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.manageToolStripMenuItem.Text = "Manage Students";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.adminDropdownManageStudents_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employees";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.adminDropdownManageEmployees_Click);
            // 
            // manageUnitsToolStripMenuItem
            // 
            this.manageUnitsToolStripMenuItem.Name = "manageUnitsToolStripMenuItem";
            this.manageUnitsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.manageUnitsToolStripMenuItem.Text = "Manage Units";
            this.manageUnitsToolStripMenuItem.Click += new System.EventHandler(this.adminDropdownManageUnits_Click);
            // 
            // manageUnitOfferingsToolStripMenuItem
            // 
            this.manageUnitOfferingsToolStripMenuItem.Name = "manageUnitOfferingsToolStripMenuItem";
            this.manageUnitOfferingsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.manageUnitOfferingsToolStripMenuItem.Text = "Manage Unit Offerings";
            this.manageUnitOfferingsToolStripMenuItem.Click += new System.EventHandler(this.adminDropdownManageUnitOfferings_Click);
            // 
            // manageEnrolmentsToolStripMenuItem
            // 
            this.manageEnrolmentsToolStripMenuItem.Name = "manageEnrolmentsToolStripMenuItem";
            this.manageEnrolmentsToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.manageEnrolmentsToolStripMenuItem.Text = "Manage Enrolments";
            this.manageEnrolmentsToolStripMenuItem.Click += new System.EventHandler(this.adminDropdownManageEnrolments_Click);
            // 
            // convenorFunctionsToolStripMenuItem
            // 
            this.convenorFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAssessmentsMasterToolStripMenuItem,
            this.manageAssessmentAllocationsToolStripMenuItem,
            this.manageTeamsToolStripMenuItem,
            this.viewUnitsToolStripMenuItem,
            this.viewUnitOfferingsToolStripMenuItem});
            this.convenorFunctionsToolStripMenuItem.Enabled = false;
            this.convenorFunctionsToolStripMenuItem.Name = "convenorFunctionsToolStripMenuItem";
            this.convenorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(192, 29);
            this.convenorFunctionsToolStripMenuItem.Text = "Convenor Functions";
            // 
            // manageAssessmentsMasterToolStripMenuItem
            // 
            this.manageAssessmentsMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.allocationsToolStripMenuItem});
            this.manageAssessmentsMasterToolStripMenuItem.Name = "manageAssessmentsMasterToolStripMenuItem";
            this.manageAssessmentsMasterToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.manageAssessmentsMasterToolStripMenuItem.Text = "Manage Assessments";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(258, 30);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.convenorDropdownAssessmentMaster_Click);
            // 
            // allocationsToolStripMenuItem
            // 
            this.allocationsToolStripMenuItem.Name = "allocationsToolStripMenuItem";
            this.allocationsToolStripMenuItem.Size = new System.Drawing.Size(258, 30);
            this.allocationsToolStripMenuItem.Text = "Student Submissions";
            // 
            // manageAssessmentAllocationsToolStripMenuItem
            // 
            this.manageAssessmentAllocationsToolStripMenuItem.Name = "manageAssessmentAllocationsToolStripMenuItem";
            this.manageAssessmentAllocationsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.manageAssessmentAllocationsToolStripMenuItem.Text = "Manage Projects";
            this.manageAssessmentAllocationsToolStripMenuItem.Click += new System.EventHandler(this.convenorDropdownProjects_Click);
            // 
            // manageTeamsToolStripMenuItem
            // 
            this.manageTeamsToolStripMenuItem.Name = "manageTeamsToolStripMenuItem";
            this.manageTeamsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.manageTeamsToolStripMenuItem.Text = "Manage Teams";
            this.manageTeamsToolStripMenuItem.Click += new System.EventHandler(this.convenorDropdownMngTeams_Click);
            // 
            // viewUnitsToolStripMenuItem
            // 
            this.viewUnitsToolStripMenuItem.Name = "viewUnitsToolStripMenuItem";
            this.viewUnitsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.viewUnitsToolStripMenuItem.Text = "View Units";
            this.viewUnitsToolStripMenuItem.Click += new System.EventHandler(this.convenorDropdownViewUnits_Click);
            // 
            // viewUnitOfferingsToolStripMenuItem
            // 
            this.viewUnitOfferingsToolStripMenuItem.Name = "viewUnitOfferingsToolStripMenuItem";
            this.viewUnitOfferingsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.viewUnitOfferingsToolStripMenuItem.Text = "View Unit Offerings";
            this.viewUnitOfferingsToolStripMenuItem.Click += new System.EventHandler(this.convenorDropdownUnitOfferings_Click);
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
            this.supervisorFunctionsToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.supervisorFunctionsToolStripMenuItem.Text = "Supervisor Functions";
            // 
            // manageMeetingsToolStripMenuItem
            // 
            this.manageMeetingsToolStripMenuItem.Name = "manageMeetingsToolStripMenuItem";
            this.manageMeetingsToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.manageMeetingsToolStripMenuItem.Text = "Manage Meetings";
            this.manageMeetingsToolStripMenuItem.Click += new System.EventHandler(this.convenorDropdownMngMeetings_Click);
            // 
            // viewAssessmentsToolStripMenuItem
            // 
            this.viewAssessmentsToolStripMenuItem.Name = "viewAssessmentsToolStripMenuItem";
            this.viewAssessmentsToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.viewAssessmentsToolStripMenuItem.Text = "View Assessments";
            this.viewAssessmentsToolStripMenuItem.Click += new System.EventHandler(this.viewAssessmentsToolStripMenuItem_Click);
            // 
            // viewTeamsToolStripMenuItem
            // 
            this.viewTeamsToolStripMenuItem.Name = "viewTeamsToolStripMenuItem";
            this.viewTeamsToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.viewTeamsToolStripMenuItem.Text = "View Teams";
            this.viewTeamsToolStripMenuItem.Click += new System.EventHandler(this.viewTeamsToolStripMenuItem_Click);
            // 
            // viewProjectsToolStripMenuItem
            // 
            this.viewProjectsToolStripMenuItem.Name = "viewProjectsToolStripMenuItem";
            this.viewProjectsToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.viewProjectsToolStripMenuItem.Text = "View Projects";
            this.viewProjectsToolStripMenuItem.Click += new System.EventHandler(this.viewProjectsToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmpDashboard";
            this.Text = "Employee Dashboard";
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
        private System.Windows.Forms.ToolStripMenuItem convenorFunctionsToolStripMenuItem;
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