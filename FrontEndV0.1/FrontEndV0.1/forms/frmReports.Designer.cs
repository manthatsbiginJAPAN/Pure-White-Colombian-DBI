namespace FrontEndV0._1.forms
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnConUnitReport = new System.Windows.Forms.Button();
            this.txtReportDisplay = new System.Windows.Forms.TextBox();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnTeamDetails = new System.Windows.Forms.Button();
            this.btnProjectReport = new System.Windows.Forms.Button();
            this.btnSupervisorReport = new System.Windows.Forms.Button();
            this.btnEnrolmentReport = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbUnitID = new System.Windows.Forms.ComboBox();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConUnitReport
            // 
            this.btnConUnitReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConUnitReport.Location = new System.Drawing.Point(6, 77);
            this.btnConUnitReport.Name = "btnConUnitReport";
            this.btnConUnitReport.Size = new System.Drawing.Size(223, 64);
            this.btnConUnitReport.TabIndex = 35;
            this.btnConUnitReport.Text = "Convenors and Units";
            this.btnConUnitReport.UseVisualStyleBackColor = true;
            this.btnConUnitReport.Click += new System.EventHandler(this.btnConUnitReport_Click);
            // 
            // txtReportDisplay
            // 
            this.txtReportDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportDisplay.Location = new System.Drawing.Point(235, 77);
            this.txtReportDisplay.Multiline = true;
            this.txtReportDisplay.Name = "txtReportDisplay";
            this.txtReportDisplay.Size = new System.Drawing.Size(667, 557);
            this.txtReportDisplay.TabIndex = 41;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(316, 19);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(314, 38);
            this.lblReports.TabIndex = 42;
            this.lblReports.Text = "Report Generation";
            // 
            // btnTeamDetails
            // 
            this.btnTeamDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamDetails.Location = new System.Drawing.Point(6, 287);
            this.btnTeamDetails.Name = "btnTeamDetails";
            this.btnTeamDetails.Size = new System.Drawing.Size(223, 64);
            this.btnTeamDetails.TabIndex = 43;
            this.btnTeamDetails.Text = "Team";
            this.btnTeamDetails.UseVisualStyleBackColor = true;
            this.btnTeamDetails.Click += new System.EventHandler(this.btnTeamDetails_Click);
            // 
            // btnProjectReport
            // 
            this.btnProjectReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectReport.Location = new System.Drawing.Point(6, 217);
            this.btnProjectReport.Name = "btnProjectReport";
            this.btnProjectReport.Size = new System.Drawing.Size(223, 64);
            this.btnProjectReport.TabIndex = 44;
            this.btnProjectReport.Text = "Projects";
            this.btnProjectReport.UseVisualStyleBackColor = true;
            this.btnProjectReport.Click += new System.EventHandler(this.btnProjectReport_Click);
            // 
            // btnSupervisorReport
            // 
            this.btnSupervisorReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervisorReport.Location = new System.Drawing.Point(6, 147);
            this.btnSupervisorReport.Name = "btnSupervisorReport";
            this.btnSupervisorReport.Size = new System.Drawing.Size(223, 64);
            this.btnSupervisorReport.TabIndex = 45;
            this.btnSupervisorReport.Text = "Supervisors";
            this.btnSupervisorReport.UseVisualStyleBackColor = true;
            this.btnSupervisorReport.Click += new System.EventHandler(this.btnSupervisorReport_Click);
            // 
            // btnEnrolmentReport
            // 
            this.btnEnrolmentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolmentReport.Location = new System.Drawing.Point(6, 357);
            this.btnEnrolmentReport.Name = "btnEnrolmentReport";
            this.btnEnrolmentReport.Size = new System.Drawing.Size(223, 64);
            this.btnEnrolmentReport.TabIndex = 46;
            this.btnEnrolmentReport.Text = "Enrolments";
            this.btnEnrolmentReport.UseVisualStyleBackColor = true;
            this.btnEnrolmentReport.Click += new System.EventHandler(this.btnEnrolmentReport_Click);
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(38, 149);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 52;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(38, 101);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(121, 21);
            this.cbSemester.TabIndex = 51;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // cbUnitID
            // 
            this.cbUnitID.FormattingEnabled = true;
            this.cbUnitID.Location = new System.Drawing.Point(38, 53);
            this.cbUnitID.Name = "cbUnitID";
            this.cbUnitID.Size = new System.Drawing.Size(121, 21);
            this.cbUnitID.TabIndex = 50;
            this.cbUnitID.SelectedIndexChanged += new System.EventHandler(this.cbUnitID_SelectedIndexChanged);
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(34, 77);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(91, 21);
            this.lblSem.TabIndex = 48;
            this.lblSem.Text = "Semester:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(34, 125);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 21);
            this.lblYear.TabIndex = 49;
            this.lblYear.Text = "Year:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(34, 29);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(84, 21);
            this.lblUnitID.TabIndex = 47;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUnitID);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.cbSemester);
            this.groupBox1.Controls.Add(this.lblSem);
            this.groupBox1.Controls.Add(this.cbUnitID);
            this.groupBox1.Location = new System.Drawing.Point(8, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 196);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select a Unit Offering";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnrolmentReport);
            this.Controls.Add(this.btnSupervisorReport);
            this.Controls.Add(this.btnProjectReport);
            this.Controls.Add(this.btnTeamDetails);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.txtReportDisplay);
            this.Controls.Add(this.btnConUnitReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnConUnitReport;
        private System.Windows.Forms.TextBox txtReportDisplay;
        public System.Windows.Forms.Label lblReports;
        public System.Windows.Forms.Button btnTeamDetails;
        public System.Windows.Forms.Button btnProjectReport;
        public System.Windows.Forms.Button btnSupervisorReport;
        public System.Windows.Forms.Button btnEnrolmentReport;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbUnitID;
        public System.Windows.Forms.Label lblSem;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}