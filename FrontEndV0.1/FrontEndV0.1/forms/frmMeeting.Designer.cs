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
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.txtProjID = new System.Windows.Forms.TextBox();
            this.lblMeetingID = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbUnitID = new System.Windows.Forms.ComboBox();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdProjects = new System.Windows.Forms.DataGridView();
            this.colMeetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMeetingType = new System.Windows.Forms.Label();
            this.cmbMeetingType = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblMeetingMinutes = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnActionItems = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            this.gbIdentifyingInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).BeginInit();
            this.SuspendLayout();
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
            this.cbYear.Location = new System.Drawing.Point(156, 181);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 36;
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
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.btnActionItems);
            this.gbDetails.Controls.Add(this.btnAgenda);
            this.gbDetails.Controls.Add(this.textBox2);
            this.gbDetails.Controls.Add(this.lblMeetingMinutes);
            this.gbDetails.Controls.Add(this.txtClientName);
            this.gbDetails.Controls.Add(this.lblClientName);
            this.gbDetails.Controls.Add(this.txtEmpID);
            this.gbDetails.Controls.Add(this.lblEmpID);
            this.gbDetails.Controls.Add(this.txtFinish);
            this.gbDetails.Controls.Add(this.lblFinish);
            this.gbDetails.Controls.Add(this.txtStart);
            this.gbDetails.Controls.Add(this.lblStart);
            this.gbDetails.Controls.Add(this.cmbMeetingType);
            this.gbDetails.Controls.Add(this.lblMeetingType);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(7, 270);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(472, 363);
            this.gbDetails.TabIndex = 45;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // gbIdentifyingInformation
            // 
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
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(8, 56);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 208);
            this.gbIdentifyingInformation.TabIndex = 43;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // txtProjID
            // 
            this.txtProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjID.Location = new System.Drawing.Point(156, 40);
            this.txtProjID.Name = "txtProjID";
            this.txtProjID.Size = new System.Drawing.Size(121, 26);
            this.txtProjID.TabIndex = 38;
            // 
            // lblMeetingID
            // 
            this.lblMeetingID.AutoSize = true;
            this.lblMeetingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingID.Location = new System.Drawing.Point(50, 40);
            this.lblMeetingID.Name = "lblMeetingID";
            this.lblMeetingID.Size = new System.Drawing.Size(102, 20);
            this.lblMeetingID.TabIndex = 37;
            this.lblMeetingID.Text = "Meeting ID:";
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(156, 147);
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
            this.cbUnitID.Location = new System.Drawing.Point(156, 115);
            this.cbUnitID.Name = "cbUnitID";
            this.cbUnitID.Size = new System.Drawing.Size(121, 21);
            this.cbUnitID.TabIndex = 34;
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(52, 145);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(91, 20);
            this.lblSem.TabIndex = 11;
            this.lblSem.Text = "Semester:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(91, 179);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(72, 113);
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
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(342, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
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
            // 
            // grdProjects
            // 
            this.grdProjects.AllowUserToAddRows = false;
            this.grdProjects.AllowUserToDeleteRows = false;
            this.grdProjects.AllowUserToResizeColumns = false;
            this.grdProjects.AllowUserToResizeRows = false;
            this.grdProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMeetID,
            this.colTeamID,
            this.Unitid,
            this.Semester,
            this.Year});
            this.grdProjects.Location = new System.Drawing.Point(486, 64);
            this.grdProjects.Name = "grdProjects";
            this.grdProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProjects.Size = new System.Drawing.Size(421, 569);
            this.grdProjects.TabIndex = 47;
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
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(61, 80);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(82, 20);
            this.lblTeamID.TabIndex = 39;
            this.lblTeamID.Text = "Team ID:";
            this.lblTeamID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 40;
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
            // cmbMeetingType
            // 
            this.cmbMeetingType.Enabled = false;
            this.cmbMeetingType.FormattingEnabled = true;
            this.cmbMeetingType.Items.AddRange(new object[] {
            "Supervisor",
            "Client",
            "Team"});
            this.cmbMeetingType.Location = new System.Drawing.Point(157, 30);
            this.cmbMeetingType.Name = "cmbMeetingType";
            this.cmbMeetingType.Size = new System.Drawing.Size(121, 21);
            this.cmbMeetingType.TabIndex = 41;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(39, 62);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(97, 20);
            this.lblStart.TabIndex = 42;
            this.lblStart.Text = "Start Time:";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(157, 62);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(121, 26);
            this.txtStart.TabIndex = 41;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(31, 100);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(105, 20);
            this.lblFinish.TabIndex = 43;
            this.lblFinish.Text = "Finish Time:";
            // 
            // txtFinish
            // 
            this.txtFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinish.Location = new System.Drawing.Point(157, 97);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(121, 26);
            this.txtFinish.TabIndex = 44;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(20, 137);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(116, 20);
            this.lblEmpID.TabIndex = 45;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(157, 131);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(121, 26);
            this.txtEmpID.TabIndex = 41;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(25, 169);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(111, 20);
            this.lblClientName.TabIndex = 46;
            this.lblClientName.Text = "Client Name:";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(157, 163);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(121, 26);
            this.txtClientName.TabIndex = 47;
            // 
            // lblMeetingMinutes
            // 
            this.lblMeetingMinutes.AutoSize = true;
            this.lblMeetingMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingMinutes.Location = new System.Drawing.Point(20, 202);
            this.lblMeetingMinutes.Name = "lblMeetingMinutes";
            this.lblMeetingMinutes.Size = new System.Drawing.Size(146, 20);
            this.lblMeetingMinutes.TabIndex = 48;
            this.lblMeetingMinutes.Text = "Meeting Minutes:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 225);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(434, 70);
            this.textBox2.TabIndex = 49;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Location = new System.Drawing.Point(335, 30);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(137, 37);
            this.btnAgenda.TabIndex = 50;
            this.btnAgenda.Text = "View Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            // 
            // btnActionItems
            // 
            this.btnActionItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionItems.Location = new System.Drawing.Point(335, 73);
            this.btnActionItems.Name = "btnActionItems";
            this.btnActionItems.Size = new System.Drawing.Size(137, 50);
            this.btnActionItems.TabIndex = 51;
            this.btnActionItems.Text = "View Action Items";
            this.btnActionItems.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdProjects);
            this.Name = "frmMeeting";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.TextBox txtProjID;
        public System.Windows.Forms.Label lblMeetingID;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbUnitID;
        public System.Windows.Forms.Label lblSem;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView grdProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        public System.Windows.Forms.Label lblTeamID;
        public System.Windows.Forms.Label lblMeetingType;
        private System.Windows.Forms.ComboBox cmbMeetingType;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblStart;
        public System.Windows.Forms.TextBox txtStart;
        public System.Windows.Forms.TextBox txtClientName;
        public System.Windows.Forms.Label lblClientName;
        public System.Windows.Forms.TextBox txtEmpID;
        public System.Windows.Forms.Label lblEmpID;
        public System.Windows.Forms.TextBox txtFinish;
        public System.Windows.Forms.Label lblFinish;
        public System.Windows.Forms.Button btnActionItems;
        public System.Windows.Forms.Button btnAgenda;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label lblMeetingMinutes;
    }
}