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
            this.btnConUnitReport = new System.Windows.Forms.Button();
            this.txtReportDisplay = new System.Windows.Forms.TextBox();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnTeamDetails = new System.Windows.Forms.Button();
            this.btnProjectReport = new System.Windows.Forms.Button();
            this.btnSupervisorReport = new System.Windows.Forms.Button();
            this.btnEnrolmentReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConUnitReport
            // 
            this.btnConUnitReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConUnitReport.Location = new System.Drawing.Point(21, 77);
            this.btnConUnitReport.Name = "btnConUnitReport";
            this.btnConUnitReport.Size = new System.Drawing.Size(146, 57);
            this.btnConUnitReport.TabIndex = 35;
            this.btnConUnitReport.Text = "Convenors and Units";
            this.btnConUnitReport.UseVisualStyleBackColor = true;
            this.btnConUnitReport.Click += new System.EventHandler(this.btnConUnitReport_Click);
            // 
            // txtReportDisplay
            // 
            this.txtReportDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportDisplay.Location = new System.Drawing.Point(219, 39);
            this.txtReportDisplay.Multiline = true;
            this.txtReportDisplay.Name = "txtReportDisplay";
            this.txtReportDisplay.Size = new System.Drawing.Size(683, 595);
            this.txtReportDisplay.TabIndex = 41;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(17, 39);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(78, 20);
            this.lblReports.TabIndex = 42;
            this.lblReports.Text = "Reports:";
            // 
            // btnTeamDetails
            // 
            this.btnTeamDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamDetails.Location = new System.Drawing.Point(21, 429);
            this.btnTeamDetails.Name = "btnTeamDetails";
            this.btnTeamDetails.Size = new System.Drawing.Size(146, 57);
            this.btnTeamDetails.TabIndex = 43;
            this.btnTeamDetails.Text = "Team Details";
            this.btnTeamDetails.UseVisualStyleBackColor = true;
            // 
            // btnProjectReport
            // 
            this.btnProjectReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectReport.Location = new System.Drawing.Point(21, 336);
            this.btnProjectReport.Name = "btnProjectReport";
            this.btnProjectReport.Size = new System.Drawing.Size(146, 57);
            this.btnProjectReport.TabIndex = 44;
            this.btnProjectReport.Text = "Projects";
            this.btnProjectReport.UseVisualStyleBackColor = true;
            // 
            // btnSupervisorReport
            // 
            this.btnSupervisorReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervisorReport.Location = new System.Drawing.Point(21, 249);
            this.btnSupervisorReport.Name = "btnSupervisorReport";
            this.btnSupervisorReport.Size = new System.Drawing.Size(146, 57);
            this.btnSupervisorReport.TabIndex = 45;
            this.btnSupervisorReport.Text = "Supervisors";
            this.btnSupervisorReport.UseVisualStyleBackColor = true;
            // 
            // btnEnrolmentReport
            // 
            this.btnEnrolmentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolmentReport.Location = new System.Drawing.Point(21, 165);
            this.btnEnrolmentReport.Name = "btnEnrolmentReport";
            this.btnEnrolmentReport.Size = new System.Drawing.Size(146, 57);
            this.btnEnrolmentReport.TabIndex = 46;
            this.btnEnrolmentReport.Text = "Enrolments in a Unit";
            this.btnEnrolmentReport.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.btnEnrolmentReport);
            this.Controls.Add(this.btnSupervisorReport);
            this.Controls.Add(this.btnProjectReport);
            this.Controls.Add(this.btnTeamDetails);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.txtReportDisplay);
            this.Controls.Add(this.btnConUnitReport);
            this.Name = "frmReports";
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

    }
}