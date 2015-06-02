namespace FrontEndV0._1.forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeeting));
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.chkApproved = new System.Windows.Forms.CheckBox();
            this.lblApproved = new System.Windows.Forms.Label();
            this.dtFinishTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtMeetingMinutes = new System.Windows.Forms.TextBox();
            this.lblMeetingMinutes = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.cbMeetingType = new System.Windows.Forms.ComboBox();
            this.lblMeetingType = new System.Windows.Forms.Label();
            this.grdAttendees = new System.Windows.Forms.DataGridView();
            this.Attended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAttendees = new System.Windows.Forms.Label();
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
            this.grdMeetings = new System.Windows.Forms.DataGridView();
            this.colMeetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadAttendees = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnActionItems = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAttendees)).BeginInit();
            this.gbIdentifyingInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetings)).BeginInit();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(164, 102);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 36;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtSupervisor);
            this.gbDetails.Controls.Add(this.chkApproved);
            this.gbDetails.Controls.Add(this.lblApproved);
            this.gbDetails.Controls.Add(this.dtFinishTime);
            this.gbDetails.Controls.Add(this.dtStartTime);
            this.gbDetails.Controls.Add(this.txtClientName);
            this.gbDetails.Controls.Add(this.txtMeetingMinutes);
            this.gbDetails.Controls.Add(this.lblMeetingMinutes);
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
            this.gbDetails.Size = new System.Drawing.Size(472, 327);
            this.gbDetails.TabIndex = 45;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Enabled = false;
            this.txtSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisor.Location = new System.Drawing.Point(156, 134);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(150, 26);
            this.txtSupervisor.TabIndex = 59;
            // 
            // chkApproved
            // 
            this.chkApproved.AutoSize = true;
            this.chkApproved.Location = new System.Drawing.Point(157, 199);
            this.chkApproved.Name = "chkApproved";
            this.chkApproved.Size = new System.Drawing.Size(15, 14);
            this.chkApproved.TabIndex = 58;
            this.chkApproved.UseVisualStyleBackColor = true;
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApproved.Location = new System.Drawing.Point(56, 193);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(95, 21);
            this.lblApproved.TabIndex = 57;
            this.lblApproved.Text = "Approved:";
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
            this.dtFinishTime.Value = new System.DateTime(2015, 5, 24, 21, 32, 31, 0);
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "hh:mm tt dd/MM/yyyy";
            this.dtStartTime.Enabled = false;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(156, 62);
            this.dtStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(151, 20);
            this.dtStartTime.TabIndex = 52;
            this.dtStartTime.Value = new System.DateTime(2015, 5, 24, 21, 32, 0, 0);
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(157, 164);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(150, 26);
            this.txtClientName.TabIndex = 47;
            // 
            // txtMeetingMinutes
            // 
            this.txtMeetingMinutes.Enabled = false;
            this.txtMeetingMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingMinutes.Location = new System.Drawing.Point(156, 219);
            this.txtMeetingMinutes.Multiline = true;
            this.txtMeetingMinutes.Name = "txtMeetingMinutes";
            this.txtMeetingMinutes.Size = new System.Drawing.Size(310, 102);
            this.txtMeetingMinutes.TabIndex = 49;
            // 
            // lblMeetingMinutes
            // 
            this.lblMeetingMinutes.AutoSize = true;
            this.lblMeetingMinutes.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingMinutes.Location = new System.Drawing.Point(66, 219);
            this.lblMeetingMinutes.Name = "lblMeetingMinutes";
            this.lblMeetingMinutes.Size = new System.Drawing.Size(85, 21);
            this.lblMeetingMinutes.TabIndex = 48;
            this.lblMeetingMinutes.Text = "Minutes:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(30, 166);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(121, 21);
            this.lblClientName.TabIndex = 46;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(15, 136);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(136, 21);
            this.lblSupervisor.TabIndex = 45;
            this.lblSupervisor.Text = "Supervisor ID:";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(28, 99);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(123, 21);
            this.lblFinish.TabIndex = 43;
            this.lblFinish.Text = "Finish Time:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(43, 61);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(108, 21);
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
            this.cbMeetingType.Size = new System.Drawing.Size(150, 21);
            this.cbMeetingType.TabIndex = 41;
            this.cbMeetingType.SelectedIndexChanged += new System.EventHandler(this.cbMeetingType_SelectedIndexChanged);
            // 
            // lblMeetingType
            // 
            this.lblMeetingType.AutoSize = true;
            this.lblMeetingType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingType.Location = new System.Drawing.Point(19, 30);
            this.lblMeetingType.Name = "lblMeetingType";
            this.lblMeetingType.Size = new System.Drawing.Size(132, 21);
            this.lblMeetingType.TabIndex = 41;
            this.lblMeetingType.Text = "Meeting Type:";
            // 
            // grdAttendees
            // 
            this.grdAttendees.AllowUserToAddRows = false;
            this.grdAttendees.AllowUserToDeleteRows = false;
            this.grdAttendees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAttendees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAttendees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAttendees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attended,
            this.StuID,
            this.FirstName,
            this.LastName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAttendees.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAttendees.Location = new System.Drawing.Point(489, 494);
            this.grdAttendees.MultiSelect = false;
            this.grdAttendees.Name = "grdAttendees";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAttendees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdAttendees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAttendees.Size = new System.Drawing.Size(411, 140);
            this.grdAttendees.TabIndex = 59;
            // 
            // Attended
            // 
            this.Attended.FillWeight = 40.60914F;
            this.Attended.HeaderText = "";
            this.Attended.Name = "Attended";
            this.Attended.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StuID
            // 
            this.StuID.FillWeight = 95.28937F;
            this.StuID.HeaderText = "StuID";
            this.StuID.Name = "StuID";
            this.StuID.ReadOnly = true;
            this.StuID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StuID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FirstName
            // 
            this.FirstName.FillWeight = 132.0507F;
            this.FirstName.HeaderText = "First";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastName
            // 
            this.LastName.FillWeight = 132.0507F;
            this.LastName.HeaderText = "Last";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblAttendees
            // 
            this.lblAttendees.AutoSize = true;
            this.lblAttendees.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendees.Location = new System.Drawing.Point(485, 464);
            this.lblAttendees.Name = "lblAttendees";
            this.lblAttendees.Size = new System.Drawing.Size(99, 21);
            this.lblAttendees.TabIndex = 55;
            this.lblAttendees.Text = "Attendees:";
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
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(317, 245);
            this.gbIdentifyingInformation.TabIndex = 43;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // cbTeamID
            // 
            this.cbTeamID.FormattingEnabled = true;
            this.cbTeamID.Location = new System.Drawing.Point(165, 138);
            this.cbTeamID.Name = "cbTeamID";
            this.cbTeamID.Size = new System.Drawing.Size(121, 21);
            this.cbTeamID.TabIndex = 37;
            this.cbTeamID.SelectedIndexChanged += new System.EventHandler(this.cbTeamID_SelectedIndexChanged);
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(164, 69);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(121, 21);
            this.cbSemester.TabIndex = 35;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(63, 138);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(92, 21);
            this.lblTeamID.TabIndex = 39;
            this.lblTeamID.Text = "Team ID:";
            // 
            // cbUnitID
            // 
            this.cbUnitID.FormattingEnabled = true;
            this.cbUnitID.Location = new System.Drawing.Point(165, 38);
            this.cbUnitID.Name = "cbUnitID";
            this.cbUnitID.Size = new System.Drawing.Size(121, 21);
            this.cbUnitID.TabIndex = 34;
            this.cbUnitID.SelectedIndexChanged += new System.EventHandler(this.cbUnitID_SelectedIndexChanged);
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(64, 69);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(91, 21);
            this.lblSem.TabIndex = 11;
            this.lblSem.Text = "Semester:";
            // 
            // txtMeetID
            // 
            this.txtMeetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetID.Location = new System.Drawing.Point(164, 175);
            this.txtMeetID.Name = "txtMeetID";
            this.txtMeetID.Size = new System.Drawing.Size(121, 26);
            this.txtMeetID.TabIndex = 38;
            this.txtMeetID.TextChanged += new System.EventHandler(this.txtMeetID_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(98, 102);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 21);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // lblMeetingID
            // 
            this.lblMeetingID.AutoSize = true;
            this.lblMeetingID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingID.Location = new System.Drawing.Point(41, 177);
            this.lblMeetingID.Name = "lblMeetingID";
            this.lblMeetingID.Size = new System.Drawing.Size(114, 21);
            this.lblMeetingID.TabIndex = 37;
            this.lblMeetingID.Text = "Meeting ID:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(71, 38);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(84, 21);
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
            this.Year,
            this.MeetType,
            this.StartTime,
            this.FinishTime,
            this.Minutes,
            this.EmpID,
            this.ClientName,
            this.Approved});
            this.grdMeetings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdMeetings.Location = new System.Drawing.Point(486, 64);
            this.grdMeetings.MultiSelect = false;
            this.grdMeetings.Name = "grdMeetings";
            this.grdMeetings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMeetings.Size = new System.Drawing.Size(416, 355);
            this.grdMeetings.TabIndex = 47;
            this.grdMeetings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMeetings_CellClick);
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
            // MeetType
            // 
            this.MeetType.HeaderText = "MeetType";
            this.MeetType.Name = "MeetType";
            this.MeetType.Visible = false;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            this.StartTime.Visible = false;
            // 
            // FinishTime
            // 
            this.FinishTime.HeaderText = "FinishTime";
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.Visible = false;
            // 
            // Minutes
            // 
            this.Minutes.HeaderText = "Minutes";
            this.Minutes.Name = "Minutes";
            this.Minutes.Visible = false;
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "Supervisor";
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = false;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.Name = "ClientName";
            this.ClientName.Visible = false;
            // 
            // Approved
            // 
            this.Approved.HeaderText = "Approved";
            this.Approved.Name = "Approved";
            this.Approved.Visible = false;
            // 
            // btnLoadAttendees
            // 
            this.btnLoadAttendees.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAttendees.Location = new System.Drawing.Point(788, 460);
            this.btnLoadAttendees.Name = "btnLoadAttendees";
            this.btnLoadAttendees.Size = new System.Drawing.Size(112, 30);
            this.btnLoadAttendees.TabIndex = 60;
            this.btnLoadAttendees.Text = "Load";
            this.btnLoadAttendees.UseVisualStyleBackColor = true;
            this.btnLoadAttendees.Click += new System.EventHandler(this.btnLoadAttendees_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.lblCancel);
            this.gbButtons.Controls.Add(this.btnAdd);
            this.gbButtons.Controls.Add(this.btnActionItems);
            this.gbButtons.Controls.Add(this.btnEdit);
            this.gbButtons.Controls.Add(this.btnAgenda);
            this.gbButtons.Controls.Add(this.btnDelete);
            this.gbButtons.Location = new System.Drawing.Point(332, 56);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(147, 245);
            this.gbButtons.TabIndex = 61;
            this.gbButtons.TabStop = false;
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(18, 138);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(114, 13);
            this.lblCancel.TabIndex = 71;
            this.lblCancel.Text = "*Press [ESC] to cancel";
            this.lblCancel.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(5, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnActionItems
            // 
            this.btnActionItems.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionItems.Location = new System.Drawing.Point(5, 202);
            this.btnActionItems.Name = "btnActionItems";
            this.btnActionItems.Size = new System.Drawing.Size(137, 38);
            this.btnActionItems.TabIndex = 70;
            this.btnActionItems.Text = "Action Items";
            this.btnActionItems.UseVisualStyleBackColor = true;
            this.btnActionItems.Click += new System.EventHandler(this.btnActionItems_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(5, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 67;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Location = new System.Drawing.Point(5, 162);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(137, 37);
            this.btnAgenda.TabIndex = 69;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(5, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.btnLoadAttendees);
            this.Controls.Add(this.grdAttendees);
            this.Controls.Add(this.lblAttendees);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdMeetings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMeeting_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAttendees)).EndInit();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetings)).EndInit();
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
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
        public System.Windows.Forms.DataGridView grdMeetings;
        public System.Windows.Forms.Label lblTeamID;
        public System.Windows.Forms.Label lblMeetingType;
        private System.Windows.Forms.ComboBox cbMeetingType;
        public System.Windows.Forms.Label lblStart;
        public System.Windows.Forms.TextBox txtClientName;
        public System.Windows.Forms.Label lblClientName;
        public System.Windows.Forms.Label lblSupervisor;
        public System.Windows.Forms.Label lblFinish;
        public System.Windows.Forms.TextBox txtMeetingMinutes;
        public System.Windows.Forms.Label lblMeetingMinutes;
        private System.Windows.Forms.ComboBox cbTeamID;
        private System.Windows.Forms.DateTimePicker dtFinishTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        public System.Windows.Forms.Label lblAttendees;
        private System.Windows.Forms.CheckBox chkApproved;
        public System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.DataGridView grdAttendees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attended;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        public System.Windows.Forms.Button btnLoadAttendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approved;
        public System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.GroupBox gbButtons;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnActionItems;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAgenda;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCancel;
    }
}