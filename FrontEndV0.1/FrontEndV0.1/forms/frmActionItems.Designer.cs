namespace FrontEndV0._1.forms
{
    partial class frmActionItems
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
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.lblActionNum = new System.Windows.Forms.Label();
            this.txtMeetingID = new System.Windows.Forms.TextBox();
            this.lblProjID = new System.Windows.Forms.Label();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.txtProjID = new System.Windows.Forms.TextBox();
            this.lblMeetingID = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbUnitID = new System.Windows.Forms.ComboBox();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.colMeetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.txtActionItems = new System.Windows.Forms.TextBox();
            this.gbIdentifyingInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeamID
            // 
            this.txtTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamID.Location = new System.Drawing.Point(156, 104);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(121, 26);
            this.txtTeamID.TabIndex = 40;
            // 
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.txtActionItems);
            this.gbIdentifyingInformation.Controls.Add(this.lblActionNum);
            this.gbIdentifyingInformation.Controls.Add(this.txtMeetingID);
            this.gbIdentifyingInformation.Controls.Add(this.lblProjID);
            this.gbIdentifyingInformation.Controls.Add(this.txtTeamID);
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
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(8, 58);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 274);
            this.gbIdentifyingInformation.TabIndex = 57;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // lblActionNum
            // 
            this.lblActionNum.AutoSize = true;
            this.lblActionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionNum.Location = new System.Drawing.Point(29, 233);
            this.lblActionNum.Name = "lblActionNum";
            this.lblActionNum.Size = new System.Drawing.Size(120, 20);
            this.lblActionNum.TabIndex = 43;
            this.lblActionNum.Text = "Action Items: ";
            // 
            // txtMeetingID
            // 
            this.txtMeetingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingID.Location = new System.Drawing.Point(156, 37);
            this.txtMeetingID.Name = "txtMeetingID";
            this.txtMeetingID.Size = new System.Drawing.Size(121, 26);
            this.txtMeetingID.TabIndex = 42;
            // 
            // lblProjID
            // 
            this.lblProjID.AutoSize = true;
            this.lblProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjID.Location = new System.Drawing.Point(50, 70);
            this.lblProjID.Name = "lblProjID";
            this.lblProjID.Size = new System.Drawing.Size(99, 20);
            this.lblProjID.TabIndex = 41;
            this.lblProjID.Text = "Project ID: ";
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(61, 104);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(82, 20);
            this.lblTeamID.TabIndex = 39;
            this.lblTeamID.Text = "Team ID:";
            // 
            // txtProjID
            // 
            this.txtProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjID.Location = new System.Drawing.Point(155, 72);
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
            // gbDetails
            // 
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(7, 357);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(472, 278);
            this.gbDetails.TabIndex = 59;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = " ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // colMeetID
            // 
            this.colMeetID.HeaderText = "Meeting ID";
            this.colMeetID.Name = "colMeetID";
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            // 
            // Unitid
            // 
            this.Unitid.HeaderText = "Unit ID";
            this.Unitid.Name = "Unitid";
            this.Unitid.ReadOnly = true;
            // 
            // colStuID
            // 
            this.colStuID.HeaderText = "Student ID";
            this.colStuID.Name = "colStuID";
            // 
            // colTeamID
            // 
            this.colTeamID.HeaderText = "Team ID";
            this.colTeamID.Name = "colTeamID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(303, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 34);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Action Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(342, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AllowUserToResizeColumns = false;
            this.grd.AllowUserToResizeRows = false;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMeetID,
            this.colTeamID,
            this.colStuID,
            this.Unitid,
            this.Semester,
            this.Year});
            this.grd.Location = new System.Drawing.Point(486, 66);
            this.grd.Name = "grd";
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(421, 569);
            this.grd.TabIndex = 61;
            // 
            // txtActionItems
            // 
            this.txtActionItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActionItems.Location = new System.Drawing.Point(156, 229);
            this.txtActionItems.Name = "txtActionItems";
            this.txtActionItems.Size = new System.Drawing.Size(121, 26);
            this.txtActionItems.TabIndex = 44;
            // 
            // frmActionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grd);
            this.Name = "frmActionItems";
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTeamID;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.Label lblTeamID;
        public System.Windows.Forms.TextBox txtProjID;
        public System.Windows.Forms.Label lblMeetingID;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbUnitID;
        public System.Windows.Forms.Label lblSem;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamID;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView grd;
        public System.Windows.Forms.TextBox txtMeetingID;
        public System.Windows.Forms.Label lblProjID;
        public System.Windows.Forms.Label lblActionNum;
        public System.Windows.Forms.TextBox txtActionItems;



    }
}