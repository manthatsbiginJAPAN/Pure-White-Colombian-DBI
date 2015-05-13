namespace FrontEndV0._1.forms
{
    partial class frmTeamContribution
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
            this.lblTitle = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.grdTaskInfo = new System.Windows.Forms.DataGridView();
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.grdAssessmentInfo = new System.Windows.Forms.DataGridView();
            this.cmbYear = new System.Windows.Forms.ComboBox();
>>>>>>> origin/master
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.cmbUnitId = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.txtAssID = new System.Windows.Forms.TextBox();
            this.lblAssId = new System.Windows.Forms.Label();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentInfo)).BeginInit();
            this.gbIdentifyingInformation.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(225, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(441, 34);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Team Contribution Assessment";
            // 
            // grdAssessmentInfo
            // 
            this.grdAssessmentInfo.AllowUserToAddRows = false;
            this.grdAssessmentInfo.AllowUserToDeleteRows = false;
            this.grdAssessmentInfo.AllowUserToResizeRows = false;
            this.grdAssessmentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAssessmentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssessmentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskId,
<<<<<<< HEAD
            this.colTaskDesc,
            this.Duedate});
            this.grdTaskInfo.Location = new System.Drawing.Point(648, 80);
            this.grdTaskInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grdTaskInfo.Name = "grdTaskInfo";
            this.grdTaskInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTaskInfo.Size = new System.Drawing.Size(561, 677);
            this.grdTaskInfo.TabIndex = 26;
            // 
            // colTaskId
            // 
            this.colTaskId.FillWeight = 40.60914F;
            this.colTaskId.HeaderText = "Task Id";
            this.colTaskId.Name = "colTaskId";
            // 
            // colTaskDesc
            // 
            this.colTaskDesc.FillWeight = 159.3909F;
            this.colTaskDesc.HeaderText = "Task Description";
            this.colTaskDesc.Name = "colTaskDesc";
=======
            this.colTaskDesc});
            this.grdAssessmentInfo.Location = new System.Drawing.Point(486, 65);
            this.grdAssessmentInfo.Name = "grdAssessmentInfo";
            this.grdAssessmentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssessmentInfo.Size = new System.Drawing.Size(421, 550);
            this.grdAssessmentInfo.TabIndex = 26;
            // 
            // cmbYear
            // 
            this.cmbYear.Enabled = false;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbYear.Location = new System.Drawing.Point(150, 133);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 48;
>>>>>>> origin/master
            // 
            // Duedate
            // 
            this.Duedate.HeaderText = "Due Date";
            this.Duedate.Name = "Duedate";
            this.Duedate.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnAdd.Location = new System.Drawing.Point(30, 711);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnAdd.Location = new System.Drawing.Point(342, 65);
>>>>>>> origin/master
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnEdit.Location = new System.Drawing.Point(241, 711);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnEdit.Location = new System.Drawing.Point(342, 110);
>>>>>>> origin/master
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnDelete.Location = new System.Drawing.Point(441, 711);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnDelete.Location = new System.Drawing.Point(342, 153);
>>>>>>> origin/master
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbSem
            // 
            this.cmbSem.Enabled = false;
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSem.Location = new System.Drawing.Point(150, 95);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(121, 21);
            this.cmbSem.TabIndex = 47;
            // 
            // cmbUnitId
            // 
            this.cmbUnitId.FormattingEnabled = true;
            this.cmbUnitId.Location = new System.Drawing.Point(150, 63);
            this.cmbUnitId.Name = "cmbUnitId";
            this.cmbUnitId.Size = new System.Drawing.Size(121, 21);
            this.cmbUnitId.TabIndex = 46;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(10, 96);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(91, 20);
            this.lblSemester.TabIndex = 44;
            this.lblSemester.Text = "Semester:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(10, 131);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 45;
            this.lblYear.Text = "Year:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(10, 61);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(71, 20);
            this.lblUnitID.TabIndex = 43;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // txtAssID
            // 
            this.txtAssID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssID.Location = new System.Drawing.Point(150, 26);
            this.txtAssID.Name = "txtAssID";
            this.txtAssID.Size = new System.Drawing.Size(100, 26);
            this.txtAssID.TabIndex = 2;
            // 
            // lblAssId
            // 
            this.lblAssId.AutoSize = true;
            this.lblAssId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssId.Location = new System.Drawing.Point(10, 26);
            this.lblAssId.Name = "lblAssId";
            this.lblAssId.Size = new System.Drawing.Size(136, 20);
            this.lblAssId.TabIndex = 1;
            this.lblAssId.Text = "Assessment ID:";
            // 
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.txtTaskID);
            this.gbIdentifyingInformation.Controls.Add(this.lblTaskID);
            this.gbIdentifyingInformation.Controls.Add(this.cmbYear);
            this.gbIdentifyingInformation.Controls.Add(this.cmbSem);
            this.gbIdentifyingInformation.Controls.Add(this.cmbUnitId);
            this.gbIdentifyingInformation.Controls.Add(this.lblSemester);
            this.gbIdentifyingInformation.Controls.Add(this.lblYear);
            this.gbIdentifyingInformation.Controls.Add(this.lblUnitID);
            this.gbIdentifyingInformation.Controls.Add(this.txtAssID);
            this.gbIdentifyingInformation.Controls.Add(this.lblAssId);
            this.gbIdentifyingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(8, 57);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 208);
            this.gbIdentifyingInformation.TabIndex = 22;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // colTaskId
            // 
            this.colTaskId.FillWeight = 40.60914F;
            this.colTaskId.HeaderText = "Task Id";
            this.colTaskId.Name = "colTaskId";
            // 
            // colTaskDesc
            // 
            this.colTaskDesc.FillWeight = 159.3909F;
            this.colTaskDesc.HeaderText = "Task Description";
            this.colTaskDesc.Name = "colTaskDesc";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskID.Location = new System.Drawing.Point(150, 170);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(100, 26);
            this.txtTaskID.TabIndex = 50;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.Location = new System.Drawing.Point(10, 170);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(76, 20);
            this.lblTaskID.TabIndex = 49;
            this.lblTaskID.Text = "Task ID:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtTaskId);
            this.gbDetails.Controls.Add(this.lblTaskId);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.dtDue);
            this.gbDetails.Controls.Add(this.txtTaskDesc);
            this.gbDetails.Controls.Add(this.lblTaskDesc);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.gbDetails.Location = new System.Drawing.Point(3, 414);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetails.Size = new System.Drawing.Size(629, 254);
=======
            this.gbDetails.Location = new System.Drawing.Point(8, 271);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(472, 337);
>>>>>>> origin/master
            this.gbDetails.TabIndex = 27;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(165, 20);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(212, 23);
            this.txtTaskId.TabIndex = 54;
            // 
            // lblTaskId
            // 
            this.lblTaskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskId.Location = new System.Drawing.Point(22, 20);
            this.lblTaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(143, 57);
            this.lblTaskId.TabIndex = 53;
            this.lblTaskId.Text = "Task ID:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(8, 219);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(143, 57);
            this.lblDueDate.TabIndex = 52;
            this.lblDueDate.Text = "Date Due:";
            // 
            // dtDue
            // 
            this.dtDue.Location = new System.Drawing.Point(165, 220);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(256, 23);
            this.dtDue.TabIndex = 51;
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txtTaskDesc.Location = new System.Drawing.Point(165, 101);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(456, 112);
=======
            this.txtTaskDesc.Location = new System.Drawing.Point(123, 39);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(343, 173);
>>>>>>> origin/master
            this.txtTaskDesc.TabIndex = 50;
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblTaskDesc.Location = new System.Drawing.Point(14, 105);
            this.lblTaskDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblTaskDesc.Location = new System.Drawing.Point(10, 42);
>>>>>>> origin/master
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(107, 46);
            this.lblTaskDesc.TabIndex = 48;
            this.lblTaskDesc.Text = "Task Description:";
            // 
<<<<<<< HEAD
            // grdAssessmentsInfo
            // 
            this.grdAssessmentsInfo.AllowUserToAddRows = false;
            this.grdAssessmentsInfo.AllowUserToDeleteRows = false;
            this.grdAssessmentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssessmentsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssID,
            this.UnitID,
            this.Year,
            this.Semester});
            this.grdAssessmentsInfo.Location = new System.Drawing.Point(30, 80);
            this.grdAssessmentsInfo.MultiSelect = false;
            this.grdAssessmentsInfo.Name = "grdAssessmentsInfo";
            this.grdAssessmentsInfo.RowTemplate.Height = 24;
            this.grdAssessmentsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssessmentsInfo.Size = new System.Drawing.Size(602, 327);
            this.grdAssessmentsInfo.TabIndex = 28;
            this.grdAssessmentsInfo.SelectionChanged += new System.EventHandler(this.grdAssessmentsInfo_SelectionChanged);
            // 
            // AssID
            // 
            this.AssID.HeaderText = "AssID";
            this.AssID.Name = "AssID";
            this.AssID.ReadOnly = true;
            // 
            // UnitID
            // 
            this.UnitID.HeaderText = "UnitID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
=======
>>>>>>> origin/master
            // frmTeamContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdAssessmentInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4);
=======
            this.Controls.Add(this.gbIdentifyingInformation);
>>>>>>> origin/master
            this.Name = "frmTeamContribution";
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentInfo)).EndInit();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView grdAssessmentInfo;
        private System.Windows.Forms.ComboBox cmbYear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.ComboBox cmbUnitId;
        public System.Windows.Forms.Label lblSemester;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.TextBox txtAssID;
        public System.Windows.Forms.Label lblAssId;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskDesc;
        public System.Windows.Forms.TextBox txtTaskID;
        public System.Windows.Forms.Label lblTaskID;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.TextBox txtTaskDesc;
        public System.Windows.Forms.Label lblTaskDesc;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridView grdAssessmentsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duedate;
        private System.Windows.Forms.DateTimePicker dtDue;
        public System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtTaskId;
        public System.Windows.Forms.Label lblTaskId;
=======
>>>>>>> origin/master
    }
}