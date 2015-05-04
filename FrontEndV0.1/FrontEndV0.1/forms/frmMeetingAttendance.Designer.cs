﻿namespace FrontEndV0._1.forms
{
    partial class frmMeetingAttendance
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdMeetingAtt = new System.Windows.Forms.DataGridView();
            this.colMeetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.txtProjID = new System.Windows.Forms.TextBox();
            this.lblMeetingID = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbUnitID = new System.Windows.Forms.ComboBox();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.lblStuID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetingAtt)).BeginInit();
            this.gbIdentifyingInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(303, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 34);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Meeting Attendance";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdMeetingAtt
            // 
            this.grdMeetingAtt.AllowUserToAddRows = false;
            this.grdMeetingAtt.AllowUserToDeleteRows = false;
            this.grdMeetingAtt.AllowUserToResizeColumns = false;
            this.grdMeetingAtt.AllowUserToResizeRows = false;
            this.grdMeetingAtt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMeetingAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdMeetingAtt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMeetID,
            this.colTeamID,
            this.colStuID,
            this.Unitid,
            this.Semester,
            this.Year});
            this.grdMeetingAtt.Location = new System.Drawing.Point(486, 64);
            this.grdMeetingAtt.Name = "grdMeetingAtt";
            this.grdMeetingAtt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMeetingAtt.Size = new System.Drawing.Size(421, 200);
            this.grdMeetingAtt.TabIndex = 54;
            this.grdMeetingAtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProjects_CellContentClick);
            // 
            // colMeetID
            // 
            this.colMeetID.HeaderText = "Meeting ID";
            this.colMeetID.Name = "colMeetID";
            // 
            // colTeamID
            // 
            this.colTeamID.HeaderText = "Team ID";
            this.colTeamID.Name = "colTeamID";
            // 
            // colStuID
            // 
            this.colStuID.HeaderText = "Student ID";
            this.colStuID.Name = "colStuID";
            // 
            // Unitid
            // 
            this.Unitid.HeaderText = "Unit ID";
            this.Unitid.Name = "Unitid";
            this.Unitid.ReadOnly = true;
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
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.txtStuID);
            this.gbIdentifyingInformation.Controls.Add(this.lblStuID);
            this.gbIdentifyingInformation.Controls.Add(this.textBox1);
            this.gbIdentifyingInformation.Controls.Add(this.lblTeamID);
            this.gbIdentifyingInformation.Controls.Add(this.txtProjID);
            this.gbIdentifyingInformation.Controls.Add(this.lblMeetingID);
            this.gbIdentifyingInformation.Controls.Add(this.cbYear);
            this.gbIdentifyingInformation.Controls.Add(this.cbSemester);
            this.gbIdentifyingInformation.Controls.Add(this.cbUnitID);
            this.gbIdentifyingInformation.Controls.Add(this.lblSem);
            this.gbIdentifyingInformation.Controls.Add(this.lblYear);
            this.gbIdentifyingInformation.Controls.Add(this.lblUnitID);
            this.gbIdentifyingInformation.Enabled = false;
            this.gbIdentifyingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(8, 46);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 238);
            this.gbIdentifyingInformation.TabIndex = 58;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 40;
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(61, 71);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(82, 20);
            this.lblTeamID.TabIndex = 39;
            this.lblTeamID.Text = "Team ID:";
            // 
            // txtProjID
            // 
            this.txtProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjID.Location = new System.Drawing.Point(156, 34);
            this.txtProjID.Name = "txtProjID";
            this.txtProjID.Size = new System.Drawing.Size(121, 26);
            this.txtProjID.TabIndex = 38;
            // 
            // lblMeetingID
            // 
            this.lblMeetingID.AutoSize = true;
            this.lblMeetingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingID.Location = new System.Drawing.Point(41, 37);
            this.lblMeetingID.Name = "lblMeetingID";
            this.lblMeetingID.Size = new System.Drawing.Size(102, 20);
            this.lblMeetingID.TabIndex = 37;
            this.lblMeetingID.Text = "Meeting ID:";
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbYear.Location = new System.Drawing.Point(156, 202);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 36;
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(156, 168);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(121, 21);
            this.cbSemester.TabIndex = 35;
            // 
            // cbUnitID
            // 
            this.cbUnitID.FormattingEnabled = true;
            this.cbUnitID.Items.AddRange(new object[] {
            "INF30011",
            "INF20011"});
            this.cbUnitID.Location = new System.Drawing.Point(156, 136);
            this.cbUnitID.Name = "cbUnitID";
            this.cbUnitID.Size = new System.Drawing.Size(121, 21);
            this.cbUnitID.TabIndex = 34;
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(52, 166);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(91, 20);
            this.lblSem.TabIndex = 11;
            this.lblSem.Text = "Semester:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(91, 200);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(72, 134);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(71, 20);
            this.lblUnitID.TabIndex = 1;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // txtStuID
            // 
            this.txtStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuID.Location = new System.Drawing.Point(156, 106);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(121, 26);
            this.txtStuID.TabIndex = 42;
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.Location = new System.Drawing.Point(41, 106);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(102, 20);
            this.lblStuID.TabIndex = 41;
            this.lblStuID.Text = "Student ID:";
            // 
            // frmMeetingAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 456);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdMeetingAtt);
            this.Name = "frmMeetingAttendance";
            this.Load += new System.EventHandler(this.frmMeetingAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetingAtt)).EndInit();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView grdMeetingAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblTeamID;
        public System.Windows.Forms.TextBox txtProjID;
        public System.Windows.Forms.Label lblMeetingID;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbUnitID;
        public System.Windows.Forms.Label lblSem;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.TextBox txtStuID;
        public System.Windows.Forms.Label lblStuID;
    }
}