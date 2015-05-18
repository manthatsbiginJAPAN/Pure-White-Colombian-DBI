namespace FrontEndV0._1.forms
{
    partial class frmStuAssessment
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
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.grdAssessments = new System.Windows.Forms.DataGridView();
            this.btnTeamContribution = new System.Windows.Forms.Button();
            this.btnPeerAssessment = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAssTitle = new System.Windows.Forms.Label();
            this.txtMarkingGuide = new System.Windows.Forms.TextBox();
            this.lblMarkingGuide = new System.Windows.Forms.Label();
            this.AssID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "Student Assessments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtMarkingGuide);
            this.gbDetails.Controls.Add(this.lblMarkingGuide);
            this.gbDetails.Controls.Add(this.txtDesc);
            this.gbDetails.Controls.Add(this.lblDesc);
            this.gbDetails.Controls.Add(this.txtTitle);
            this.gbDetails.Controls.Add(this.lblAssTitle);
            this.gbDetails.Location = new System.Drawing.Point(25, 79);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(413, 543);
            this.gbDetails.TabIndex = 48;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // grdAssessments
            // 
            this.grdAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssessments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssID,
            this.UnitID,
            this.Semester,
            this.Year});
            this.grdAssessments.Location = new System.Drawing.Point(468, 85);
            this.grdAssessments.Name = "grdAssessments";
            this.grdAssessments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssessments.Size = new System.Drawing.Size(390, 480);
            this.grdAssessments.TabIndex = 49;
            // 
            // btnTeamContribution
            // 
            this.btnTeamContribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamContribution.Location = new System.Drawing.Point(669, 583);
            this.btnTeamContribution.Name = "btnTeamContribution";
            this.btnTeamContribution.Size = new System.Drawing.Size(189, 37);
            this.btnTeamContribution.TabIndex = 50;
            this.btnTeamContribution.Text = "Team Contribution";
            this.btnTeamContribution.UseVisualStyleBackColor = true;
            // 
            // btnPeerAssessment
            // 
            this.btnPeerAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeerAssessment.Location = new System.Drawing.Point(468, 583);
            this.btnPeerAssessment.Name = "btnPeerAssessment";
            this.btnPeerAssessment.Size = new System.Drawing.Size(195, 37);
            this.btnPeerAssessment.TabIndex = 51;
            this.btnPeerAssessment.Text = "Peer Assessment";
            this.btnPeerAssessment.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(20, 155);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(367, 104);
            this.txtDesc.TabIndex = 51;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(17, 130);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(105, 20);
            this.lblDesc.TabIndex = 50;
            this.lblDesc.Text = "Description:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(70, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(317, 20);
            this.txtTitle.TabIndex = 49;
            // 
            // lblAssTitle
            // 
            this.lblAssTitle.AutoSize = true;
            this.lblAssTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssTitle.Location = new System.Drawing.Point(22, 32);
            this.lblAssTitle.Name = "lblAssTitle";
            this.lblAssTitle.Size = new System.Drawing.Size(48, 20);
            this.lblAssTitle.TabIndex = 48;
            this.lblAssTitle.Text = "Title:";
            // 
            // txtMarkingGuide
            // 
            this.txtMarkingGuide.Location = new System.Drawing.Point(20, 334);
            this.txtMarkingGuide.Multiline = true;
            this.txtMarkingGuide.Name = "txtMarkingGuide";
            this.txtMarkingGuide.Size = new System.Drawing.Size(367, 189);
            this.txtMarkingGuide.TabIndex = 53;
            // 
            // lblMarkingGuide
            // 
            this.lblMarkingGuide.AutoSize = true;
            this.lblMarkingGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkingGuide.Location = new System.Drawing.Point(17, 309);
            this.lblMarkingGuide.Name = "lblMarkingGuide";
            this.lblMarkingGuide.Size = new System.Drawing.Size(130, 20);
            this.lblMarkingGuide.TabIndex = 52;
            this.lblMarkingGuide.Text = "Marking Guide:";
            // 
            // AssID
            // 
            this.AssID.HeaderText = "Assessment ID";
            this.AssID.Name = "AssID";
            // 
            // UnitID
            // 
            this.UnitID.HeaderText = "Unit ID";
            this.UnitID.Name = "UnitID";
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // frmStuAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.btnTeamContribution);
            this.Controls.Add(this.btnPeerAssessment);
            this.Controls.Add(this.grdAssessments);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmStuAssessment";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DataGridView grdAssessments;
        public System.Windows.Forms.Button btnTeamContribution;
        public System.Windows.Forms.Button btnPeerAssessment;
        private System.Windows.Forms.TextBox txtMarkingGuide;
        public System.Windows.Forms.Label lblMarkingGuide;
        private System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.Label lblAssTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;

    }
}