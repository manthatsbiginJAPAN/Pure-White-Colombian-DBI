﻿namespace FrontEndV0._1.forms
{
    partial class frmMeeting
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
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAttendees = new System.Windows.Forms.Label();
            this.clbAttendees = new System.Windows.Forms.CheckedListBox();
            this.dtFinishTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.cbSupervisor = new System.Windows.Forms.ComboBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.cbMeetingType = new System.Windows.Forms.ComboBox();
            this.lblMeetingType = new System.Windows.Forms.Label();
            this.btnActionItems = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.txtMeetingMinutes = new System.Windows.Forms.TextBox();
            this.lblMeetingMinutes = new System.Windows.Forms.Label();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.cbTeamID = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.cbUnitID = new System.Windows.Forms.ComboBox();
            this.lblSem = new System.Windows.Forms.Label();
            this.txtMeetID = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMeetingID = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdMeetings = new System.Windows.Forms.DataGridView();
            this.colMeetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetails.SuspendLayout();
            this.gbIdentifyingInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(155, 102);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 36;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblAttendees);
            this.gbDetails.Controls.Add(this.clbAttendees);
            this.gbDetails.Controls.Add(this.dtFinishTime);
            this.gbDetails.Controls.Add(this.dtStartTime);
            this.gbDetails.Controls.Add(this.cbSupervisor);
            this.gbDetails.Controls.Add(this.txtClientName);
            this.gbDetails.Controls.Add(this.lblClientName);
            this.gbDetails.Controls.Add(this.lblSupervisor);
            this.gbDetails.Controls.Add(this.lblFinish);
            this.gbDetails.Controls.Add(this.lblStart);
            this.gbDetails.Controls.Add(this.cbMeetingType);
            this.gbDetails.Controls.Add(this.lblMeetingType);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(7, 307);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(472, 339);
            this.gbDetails.TabIndex = 45;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Absentees";
            // 
            // lblAttendees
            // 
            this.lblAttendees.AutoSize = true;
            this.lblAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendees.Location = new System.Drawing.Point(20, 218);
            this.lblAttendees.Name = "lblAttendees";
            this.lblAttendees.Size = new System.Drawing.Size(97, 20);
            this.lblAttendees.TabIndex = 55;
            this.lblAttendees.Text = "Attendees:";
            // 
            // clbAttendees
            // 
            this.clbAttendees.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.clbAttendees.FormattingEnabled = true;
            this.clbAttendees.Location = new System.Drawing.Point(156, 218);
            this.clbAttendees.Margin = new System.Windows.Forms.Padding(2);
            this.clbAttendees.Name = "clbAttendees";
            this.clbAttendees.Size = new System.Drawing.Size(151, 49);
            this.clbAttendees.TabIndex = 54;
            // 
            // dtFinishTime
            // 
            this.dtFinishTime.CustomFormat = "hh:mm tt dd/MM/yyyy";
            this.dtFinishTime.Enabled = false;
            this.dtFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinishTime.Location = new System.Drawing.Point(156, 100);
            this.dtFinishTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtFinishTime.Name = "dtFinishTime";
            this.dtFinishTime.Size = new System.Drawing.Size(151, 20);
            this.dtFinishTime.TabIndex = 53;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "hh:mm  tt dd/MM/yyyy";
            this.dtStartTime.Enabled = false;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(156, 62);
            this.dtStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(151, 20);
            this.dtStartTime.TabIndex = 52;
            this.dtStartTime.Value = new System.DateTime(2015, 5, 18, 0, 0, 0, 0);
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.Enabled = false;
            this.cbSupervisor.FormattingEnabled = true;
            this.cbSupervisor.Location = new System.Drawing.Point(157, 137);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.Size = new System.Drawing.Size(121, 21);
            this.cbSupervisor.TabIndex = 42;
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(157, 163);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(121, 26);
            this.txtClientName.TabIndex = 47;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(20, 169);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(111, 20);
            this.lblClientName.TabIndex = 46;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(20, 137);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(123, 20);
            this.lblSupervisor.TabIndex = 45;
            this.lblSupervisor.Text = "Supervisor ID:";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(20, 100);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(105, 20);
            this.lblFinish.TabIndex = 43;
            this.lblFinish.Text = "Finish Time:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(20, 62);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(97, 20);
            this.lblStart.TabIndex = 42;
            this.lblStart.Text = "Start Time:";
            // 
            // cbMeetingType
            // 
            this.cbMeetingType.Enabled = false;
            this.cbMeetingType.FormattingEnabled = true;
            this.cbMeetingType.Items.AddRange(new object[] {
            "Supervisor",
            "Client",
            "Student"});
            this.cbMeetingType.Location = new System.Drawing.Point(157, 30);
            this.cbMeetingType.Name = "cbMeetingType";
            this.cbMeetingType.Size = new System.Drawing.Size(121, 21);
            this.cbMeetingType.TabIndex = 41;
            this.cbMeetingType.SelectedIndexChanged += new System.EventHandler(this.cbMeetingType_SelectedIndexChanged);
            // 
            // lblMeetingType
            // 
            this.lblMeetingType.AutoSize = true;
            this.lblMeetingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingType.Location = new System.Drawing.Point(20, 28);
            this.lblMeetingType.Name = "lblMeetingType";
            this.lblMeetingType.Size = new System.Drawing.Size(121, 20);
            this.lblMeetingType.TabIndex = 41;
            this.lblMeetingType.Text = "Meeting Type:";
            // 
            // btnActionItems
            // 
            this.btnActionItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionItems.Location = new System.Drawing.Point(343, 263);
            this.btnActionItems.Name = "btnActionItems";
            this.btnActionItems.Size = new System.Drawing.Size(137, 38);
            this.btnActionItems.TabIndex = 51;
            this.btnActionItems.Text = "Action Items";
            this.btnActionItems.UseVisualStyleBackColor = true;
            this.btnActionItems.Click += new System.EventHandler(this.btnActionItems_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Location = new System.Drawing.Point(343, 220);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(137, 37);
            this.btnAgenda.TabIndex = 50;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // txtMeetingMinutes
            // 
            this.txtMeetingMinutes.Enabled = false;
            this.txtMeetingMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingMinutes.Location = new System.Drawing.Point(486, 465);
            this.txtMeetingMinutes.Multiline = true;
            this.txtMeetingMinutes.Name = "txtMeetingMinutes";
            this.txtMeetingMinutes.Size = new System.Drawing.Size(416, 144);
            this.txtMeetingMinutes.TabIndex = 49;
            // 
            // lblMeetingMinutes
            // 
            this.lblMeetingMinutes.AutoSize = true;
            this.lblMeetingMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingMinutes.Location = new System.Drawing.Point(485, 442);
            this.lblMeetingMinutes.Name = "lblMeetingMinutes";
            this.lblMeetingMinutes.Size = new System.Drawing.Size(146, 20);
            this.lblMeetingMinutes.TabIndex = 48;
            this.lblMeetingMinutes.Text = "Meeting Minutes:";
            // 
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.cbTeamID);
            this.gbIdentifyingInformation.Controls.Add(this.cbYear);
            this.gbIdentifyingInformation.Controls.Add(this.cbSemester);
            this.gbIdentifyingInformation.Controls.Add(this.lblTeamID);
            this.gbIdentifyingInformation.Controls.Add(this.cbUnitID);
            this.gbIdentifyingInformation.Controls.Add(this.lblSem);
            this.gbIdentifyingInformation.Controls.Add(this.txtMeetID);
            this.gbIdentifyingInformation.Controls.Add(this.lblYear);
            this.gbIdentifyingInformation.Controls.Add(this.lblMeetingID);
            this.gbIdentifyingInformation.Controls.Add(this.lblUnitID);
            this.gbIdentifyingInformation.Enabled = false;
            this.gbIdentifyingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(8, 56);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 245);
            this.gbIdentifyingInformation.TabIndex = 43;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // cbTeamID
            // 
            this.cbTeamID.FormattingEnabled = true;
            this.cbTeamID.Location = new System.Drawing.Point(156, 138);
            this.cbTeamID.Name = "cbTeamID";
            this.cbTeamID.Size = new System.Drawing.Size(121, 21);
            this.cbTeamID.TabIndex = 41;
            this.cbTeamID.SelectedIndexChanged += new System.EventHandler(this.cbTeamID_SelectedIndexChanged);
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(155, 69);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(121, 21);
            this.cbSemester.TabIndex = 35;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(58, 136);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(82, 20);
            this.lblTeamID.TabIndex = 39;
            this.lblTeamID.Text = "Team ID:";
            // 
            // cbUnitID
            // 
            this.cbUnitID.FormattingEnabled = true;
            this.cbUnitID.Location = new System.Drawing.Point(156, 38);
            this.cbUnitID.Name = "cbUnitID";
            this.cbUnitID.Size = new System.Drawing.Size(121, 21);
            this.cbUnitID.TabIndex = 34;
            this.cbUnitID.SelectedIndexChanged += new System.EventHandler(this.cbUnitID_SelectedIndexChanged);
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(49, 67);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(91, 20);
            this.lblSem.TabIndex = 11;
            this.lblSem.Text = "Semester:";
            // 
            // txtMeetID
            // 
            this.txtMeetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetID.Location = new System.Drawing.Point(155, 175);
            this.txtMeetID.Name = "txtMeetID";
            this.txtMeetID.Size = new System.Drawing.Size(121, 26);
            this.txtMeetID.TabIndex = 38;
            this.txtMeetID.TextChanged += new System.EventHandler(this.txtMeetID_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(91, 100);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // lblMeetingID
            // 
            this.lblMeetingID.AutoSize = true;
            this.lblMeetingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingID.Location = new System.Drawing.Point(40, 178);
            this.lblMeetingID.Name = "lblMeetingID";
            this.lblMeetingID.Size = new System.Drawing.Size(102, 20);
            this.lblMeetingID.TabIndex = 37;
            this.lblMeetingID.Text = "Meeting ID:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(72, 36);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(71, 20);
            this.lblUnitID.TabIndex = 1;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(374, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 34);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Meetings";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(342, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdMeetings
            // 
            this.grdMeetings.AllowUserToAddRows = false;
            this.grdMeetings.AllowUserToDeleteRows = false;
            this.grdMeetings.AllowUserToResizeColumns = false;
            this.grdMeetings.AllowUserToResizeRows = false;
            this.grdMeetings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdMeetings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMeetID,
            this.colTeamID,
            this.Unitid,
            this.Semester,
            this.Year});
            this.grdMeetings.Location = new System.Drawing.Point(486, 64);
            this.grdMeetings.Name = "grdMeetings";
            this.grdMeetings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMeetings.Size = new System.Drawing.Size(421, 355);
            this.grdMeetings.TabIndex = 47;
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
            // frmMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnActionItems);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMeetingMinutes);
            this.Controls.Add(this.grdMeetings);
            this.Controls.Add(this.lblMeetingMinutes);
            this.Name = "frmMeeting";
            this.Load += new System.EventHandler(this.frmMeeting_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.TextBox txtMeetID;
        public System.Windows.Forms.Label lblMeetingID;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbUnitID;
        public System.Windows.Forms.Label lblSem;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView grdMeetings;
        public System.Windows.Forms.Label lblTeamID;
        public System.Windows.Forms.Label lblMeetingType;
        private System.Windows.Forms.ComboBox cbMeetingType;
        public System.Windows.Forms.Label lblStart;
        public System.Windows.Forms.TextBox txtClientName;
        public System.Windows.Forms.Label lblClientName;
        public System.Windows.Forms.Label lblSupervisor;
        public System.Windows.Forms.Label lblFinish;
        public System.Windows.Forms.Button btnActionItems;
        public System.Windows.Forms.Button btnAgenda;
        public System.Windows.Forms.TextBox txtMeetingMinutes;
        public System.Windows.Forms.Label lblMeetingMinutes;
        private System.Windows.Forms.ComboBox cbSupervisor;
        private System.Windows.Forms.ComboBox cbTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DateTimePicker dtFinishTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.CheckedListBox clbAttendees;
        public System.Windows.Forms.Label lblAttendees;
    }
}