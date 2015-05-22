namespace FrontEndV0._1.forms
{
    partial class frmTeamDetails
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
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cbSupervisor = new System.Windows.Forms.ComboBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.cbProjID = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbUnitID = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.lblProjID = new System.Windows.Forms.Label();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdTeamInfo = new System.Windows.Forms.DataGridView();
            this.colTeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grdTeamAllocation = new System.Windows.Forms.DataGridView();
            this.colStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTeamDetails = new System.Windows.Forms.Label();
            this.lblStuID = new System.Windows.Forms.Label();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnDeleteStu = new System.Windows.Forms.Button();
            this.txtStuID = new System.Windows.Forms.ComboBox();
            this.gbTeamAlloc = new System.Windows.Forms.GroupBox();
            this.gbDetails.SuspendLayout();
            this.gbIdentifyingInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamAllocation)).BeginInit();
            this.gbTeamAlloc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(456, 80);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 46);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.cbSupervisor);
            this.gbDetails.Controls.Add(this.lblEmpID);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(9, 378);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Size = new System.Drawing.Size(435, 85);
            this.gbDetails.TabIndex = 24;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.Enabled = false;
            this.cbSupervisor.FormattingEnabled = true;
            this.cbSupervisor.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbSupervisor.Location = new System.Drawing.Point(177, 47);
            this.cbSupervisor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.Size = new System.Drawing.Size(160, 25);
            this.cbSupervisor.TabIndex = 39;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(15, 44);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(141, 25);
            this.lblEmpID.TabIndex = 11;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(456, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 46);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.cbProjID);
            this.gbIdentifyingInformation.Controls.Add(this.cbYear);
            this.gbIdentifyingInformation.Controls.Add(this.cbSemester);
            this.gbIdentifyingInformation.Controls.Add(this.cbUnitID);
            this.gbIdentifyingInformation.Controls.Add(this.lblYear);
            this.gbIdentifyingInformation.Controls.Add(this.lblSemester);
            this.gbIdentifyingInformation.Controls.Add(this.lblUnitID);
            this.gbIdentifyingInformation.Controls.Add(this.lblProjID);
            this.gbIdentifyingInformation.Controls.Add(this.txtTeamID);
            this.gbIdentifyingInformation.Controls.Add(this.lblTeam);
            this.gbIdentifyingInformation.Enabled = false;
            this.gbIdentifyingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(11, 70);
            this.gbIdentifyingInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(433, 308);
            this.gbIdentifyingInformation.TabIndex = 22;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // cbProjID
            // 
            this.cbProjID.FormattingEnabled = true;
            this.cbProjID.Items.AddRange(new object[] {
            "INF30011",
            "INF20011"});
            this.cbProjID.Location = new System.Drawing.Point(176, 92);
            this.cbProjID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProjID.Name = "cbProjID";
            this.cbProjID.Size = new System.Drawing.Size(160, 25);
            this.cbProjID.TabIndex = 38;
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbYear.Location = new System.Drawing.Point(176, 258);
            this.cbYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(160, 25);
            this.cbYear.TabIndex = 37;
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(176, 203);
            this.cbSemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(160, 25);
            this.cbSemester.TabIndex = 36;
            // 
            // cbUnitID
            // 
            this.cbUnitID.FormattingEnabled = true;
            this.cbUnitID.Items.AddRange(new object[] {
            "INF30011",
            "INF20011"});
            this.cbUnitID.Location = new System.Drawing.Point(176, 149);
            this.cbUnitID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUnitID.Name = "cbUnitID";
            this.cbUnitID.Size = new System.Drawing.Size(160, 25);
            this.cbUnitID.TabIndex = 35;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(17, 256);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(64, 25);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(13, 201);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(111, 25);
            this.lblSemester.TabIndex = 7;
            this.lblSemester.Text = "Semester:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(13, 146);
            this.lblUnitID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(84, 25);
            this.lblUnitID.TabIndex = 5;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // lblProjID
            // 
            this.lblProjID.AutoSize = true;
            this.lblProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjID.Location = new System.Drawing.Point(13, 90);
            this.lblProjID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjID.Name = "lblProjID";
            this.lblProjID.Size = new System.Drawing.Size(113, 25);
            this.lblProjID.TabIndex = 3;
            this.lblProjID.Text = "Project ID:";
            // 
            // txtTeamID
            // 
            this.txtTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamID.Location = new System.Drawing.Point(176, 28);
            this.txtTeamID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(132, 30);
            this.txtTeamID.TabIndex = 2;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(13, 32);
            this.lblTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(101, 25);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Team ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(421, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 41);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Team Details";
            // 
            // grdTeamInfo
            // 
            this.grdTeamInfo.AllowUserToAddRows = false;
            this.grdTeamInfo.AllowUserToDeleteRows = false;
            this.grdTeamInfo.AllowUserToResizeColumns = false;
            this.grdTeamInfo.AllowUserToResizeRows = false;
            this.grdTeamInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTeamInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeamInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeamId,
            this.colProjID,
            this.colUnitID,
            this.colSemester,
            this.colYear,
            this.colEmpID});
            this.grdTeamInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdTeamInfo.Location = new System.Drawing.Point(648, 80);
            this.grdTeamInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTeamInfo.MultiSelect = false;
            this.grdTeamInfo.Name = "grdTeamInfo";
            this.grdTeamInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTeamInfo.Size = new System.Drawing.Size(561, 700);
            this.grdTeamInfo.TabIndex = 26;
            this.grdTeamInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTeamInfo_CellClick);
            // 
            // colTeamId
            // 
            this.colTeamId.HeaderText = "Team ID";
            this.colTeamId.Name = "colTeamId";
            // 
            // colProjID
            // 
            this.colProjID.HeaderText = "Project ID:";
            this.colProjID.Name = "colProjID";
            // 
            // colUnitID
            // 
            this.colUnitID.HeaderText = "Unit ID";
            this.colUnitID.Name = "colUnitID";
            // 
            // colSemester
            // 
            this.colSemester.HeaderText = "Semester";
            this.colSemester.Name = "colSemester";
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            // 
            // colEmpID
            // 
            this.colEmpID.HeaderText = "Emp ID";
            this.colEmpID.Name = "colEmpID";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(456, 135);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 46);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grdTeamAllocation
            // 
            this.grdTeamAllocation.AllowUserToAddRows = false;
            this.grdTeamAllocation.AllowUserToDeleteRows = false;
            this.grdTeamAllocation.AllowUserToResizeColumns = false;
            this.grdTeamAllocation.AllowUserToResizeRows = false;
            this.grdTeamAllocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTeamAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeamAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStuID,
            this.FirstName,
            this.LastName});
            this.grdTeamAllocation.Location = new System.Drawing.Point(8, 87);
            this.grdTeamAllocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTeamAllocation.MultiSelect = false;
            this.grdTeamAllocation.Name = "grdTeamAllocation";
            this.grdTeamAllocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTeamAllocation.Size = new System.Drawing.Size(419, 165);
            this.grdTeamAllocation.TabIndex = 27;
            this.grdTeamAllocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTeamAllocation_CellClick);
            // 
            // colStuID
            // 
            this.colStuID.HeaderText = "Student ID";
            this.colStuID.Name = "colStuID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last";
            this.LastName.Name = "LastName";
            // 
            // lblTeamDetails
            // 
            this.lblTeamDetails.AutoSize = true;
            this.lblTeamDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamDetails.Location = new System.Drawing.Point(15, 61);
            this.lblTeamDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamDetails.Name = "lblTeamDetails";
            this.lblTeamDetails.Size = new System.Drawing.Size(169, 25);
            this.lblTeamDetails.TabIndex = 11;
            this.lblTeamDetails.Text = "Team Members:";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.Location = new System.Drawing.Point(15, 24);
            this.lblStuID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(121, 25);
            this.lblStuID.TabIndex = 11;
            this.lblStuID.Text = "Student ID:";
            // 
            // btnAddStu
            // 
            this.btnAddStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStu.Location = new System.Drawing.Point(457, 479);
            this.btnAddStu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(183, 46);
            this.btnAddStu.TabIndex = 28;
            this.btnAddStu.Text = "Add Student";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // btnDeleteStu
            // 
            this.btnDeleteStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStu.Location = new System.Drawing.Point(457, 532);
            this.btnDeleteStu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteStu.Name = "btnDeleteStu";
            this.btnDeleteStu.Size = new System.Drawing.Size(183, 46);
            this.btnDeleteStu.TabIndex = 29;
            this.btnDeleteStu.Text = "Delete Student";
            this.btnDeleteStu.UseVisualStyleBackColor = true;
            this.btnDeleteStu.Click += new System.EventHandler(this.btnDeleteStu_Click);
            // 
            // txtStuID
            // 
            this.txtStuID.Enabled = false;
            this.txtStuID.FormattingEnabled = true;
            this.txtStuID.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.txtStuID.Location = new System.Drawing.Point(177, 24);
            this.txtStuID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(160, 25);
            this.txtStuID.TabIndex = 40;
            // 
            // gbTeamAlloc
            // 
            this.gbTeamAlloc.Controls.Add(this.lblTeamDetails);
            this.gbTeamAlloc.Controls.Add(this.txtStuID);
            this.gbTeamAlloc.Controls.Add(this.grdTeamAllocation);
            this.gbTeamAlloc.Controls.Add(this.lblStuID);
            this.gbTeamAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeamAlloc.Location = new System.Drawing.Point(9, 466);
            this.gbTeamAlloc.Margin = new System.Windows.Forms.Padding(4);
            this.gbTeamAlloc.Name = "gbTeamAlloc";
            this.gbTeamAlloc.Padding = new System.Windows.Forms.Padding(4);
            this.gbTeamAlloc.Size = new System.Drawing.Size(435, 272);
            this.gbTeamAlloc.TabIndex = 41;
            this.gbTeamAlloc.TabStop = false;
            this.gbTeamAlloc.Text = "Students";
            // 
            // frmTeamDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 741);
            this.Controls.Add(this.gbTeamAlloc);
            this.Controls.Add(this.btnDeleteStu);
            this.Controls.Add(this.btnAddStu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdTeamInfo);
            this.Controls.Add(this.btnEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTeamDetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frmTeamDetails_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamAllocation)).EndInit();
            this.gbTeamAlloc.ResumeLayout(false);
            this.gbTeamAlloc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.TextBox txtTeamID;
        public System.Windows.Forms.Label lblTeam;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView grdTeamInfo;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpID;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblSemester;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.Label lblProjID;
        public System.Windows.Forms.Label lblEmpID;
        public System.Windows.Forms.DataGridView grdTeamAllocation;
        public System.Windows.Forms.Label lblTeamDetails;
        public System.Windows.Forms.Label lblStuID;
        public System.Windows.Forms.Button btnAddStu;
        public System.Windows.Forms.Button btnDeleteStu;
        private System.Windows.Forms.ComboBox cbUnitID;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbProjID;
        private System.Windows.Forms.ComboBox cbSupervisor;
        private System.Windows.Forms.ComboBox txtStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        public System.Windows.Forms.GroupBox gbTeamAlloc;
    }
}