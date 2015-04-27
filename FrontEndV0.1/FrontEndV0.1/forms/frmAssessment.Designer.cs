namespace FrontEndV0._1.forms
{
    partial class frmAssessment
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
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtAssID = new System.Windows.Forms.TextBox();
            this.lblAssId = new System.Windows.Forms.Label();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAssType = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.cmbUnitId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdAssessmentInfo = new System.Windows.Forms.DataGridView();
            this.lblAssTitle = new System.Windows.Forms.Label();
            this.txtAssTitle = new System.Windows.Forms.TextBox();
            this.lblAssDesc = new System.Windows.Forms.Label();
            this.txtAssDesc = new System.Windows.Forms.TextBox();
            this.cmbAssType = new System.Windows.Forms.ComboBox();
            this.colAssID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMarkingGuide = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtMarkingGuide = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbDetails.SuspendLayout();
            this.gbIdentifyingInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(316, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 34);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Assessment Details";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.textBox2);
            this.gbDetails.Controls.Add(this.txtMarkingGuide);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.lblMarkingGuide);
            this.gbDetails.Controls.Add(this.cmbAssType);
            this.gbDetails.Controls.Add(this.lblAssType);
            this.gbDetails.Controls.Add(this.lblAssTitle);
            this.gbDetails.Controls.Add(this.txtAssDesc);
            this.gbDetails.Controls.Add(this.txtAssTitle);
            this.gbDetails.Controls.Add(this.lblAssDesc);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(7, 297);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(472, 337);
            this.gbDetails.TabIndex = 17;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
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
            this.gbIdentifyingInformation.Controls.Add(this.cmbYear);
            this.gbIdentifyingInformation.Controls.Add(this.cmbSem);
            this.gbIdentifyingInformation.Controls.Add(this.cmbUnitId);
            this.gbIdentifyingInformation.Controls.Add(this.label3);
            this.gbIdentifyingInformation.Controls.Add(this.label4);
            this.gbIdentifyingInformation.Controls.Add(this.label5);
            this.gbIdentifyingInformation.Controls.Add(this.txtAssID);
            this.gbIdentifyingInformation.Controls.Add(this.lblAssId);
            this.gbIdentifyingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(8, 57);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 234);
            this.gbIdentifyingInformation.TabIndex = 15;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(342, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblAssType
            // 
            this.lblAssType.AutoSize = true;
            this.lblAssType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssType.Location = new System.Drawing.Point(14, 127);
            this.lblAssType.Name = "lblAssType";
            this.lblAssType.Size = new System.Drawing.Size(155, 20);
            this.lblAssType.TabIndex = 24;
            this.lblAssType.Text = "Assessment Type:";
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
            this.cmbYear.Location = new System.Drawing.Point(150, 184);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 48;
            // 
            // cmbSem
            // 
            this.cmbSem.Enabled = false;
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSem.Location = new System.Drawing.Point(150, 128);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(121, 21);
            this.cmbSem.TabIndex = 47;
            // 
            // cmbUnitId
            // 
            this.cmbUnitId.FormattingEnabled = true;
            this.cmbUnitId.Items.AddRange(new object[] {
            "INF30011",
            "INF20011"});
            this.cmbUnitId.Location = new System.Drawing.Point(150, 77);
            this.cmbUnitId.Name = "cmbUnitId";
            this.cmbUnitId.Size = new System.Drawing.Size(121, 21);
            this.cmbUnitId.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Semester:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Unit ID:";
            // 
            // grdAssessmentInfo
            // 
            this.grdAssessmentInfo.AllowUserToAddRows = false;
            this.grdAssessmentInfo.AllowUserToDeleteRows = false;
            this.grdAssessmentInfo.AllowUserToResizeColumns = false;
            this.grdAssessmentInfo.AllowUserToResizeRows = false;
            this.grdAssessmentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAssessmentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssessmentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssID,
            this.colUnitID,
            this.colSem,
            this.colYear});
            this.grdAssessmentInfo.Location = new System.Drawing.Point(486, 65);
            this.grdAssessmentInfo.Name = "grdAssessmentInfo";
            this.grdAssessmentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssessmentInfo.Size = new System.Drawing.Size(421, 550);
            this.grdAssessmentInfo.TabIndex = 19;
            // 
            // lblAssTitle
            // 
            this.lblAssTitle.AutoSize = true;
            this.lblAssTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssTitle.Location = new System.Drawing.Point(11, 43);
            this.lblAssTitle.Name = "lblAssTitle";
            this.lblAssTitle.Size = new System.Drawing.Size(151, 20);
            this.lblAssTitle.TabIndex = 20;
            this.lblAssTitle.Text = "Assessment Title:";
            // 
            // txtAssTitle
            // 
            this.txtAssTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssTitle.Location = new System.Drawing.Point(184, 37);
            this.txtAssTitle.Name = "txtAssTitle";
            this.txtAssTitle.Size = new System.Drawing.Size(152, 26);
            this.txtAssTitle.TabIndex = 21;
            // 
            // lblAssDesc
            // 
            this.lblAssDesc.AutoSize = true;
            this.lblAssDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssDesc.Location = new System.Drawing.Point(11, 88);
            this.lblAssDesc.Name = "lblAssDesc";
            this.lblAssDesc.Size = new System.Drawing.Size(158, 20);
            this.lblAssDesc.TabIndex = 22;
            this.lblAssDesc.Text = "Assessment Desc:";
            // 
            // txtAssDesc
            // 
            this.txtAssDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssDesc.Location = new System.Drawing.Point(184, 88);
            this.txtAssDesc.Name = "txtAssDesc";
            this.txtAssDesc.Size = new System.Drawing.Size(152, 26);
            this.txtAssDesc.TabIndex = 23;
            // 
            // cmbAssType
            // 
            this.cmbAssType.FormattingEnabled = true;
            this.cmbAssType.Items.AddRange(new object[] {
            "Peer Assessment",
            "Team Contribution"});
            this.cmbAssType.Location = new System.Drawing.Point(184, 129);
            this.cmbAssType.Name = "cmbAssType";
            this.cmbAssType.Size = new System.Drawing.Size(152, 21);
            this.cmbAssType.TabIndex = 47;
            // 
            // colAssID
            // 
            this.colAssID.HeaderText = "Assessment ID";
            this.colAssID.Name = "colAssID";
            // 
            // colUnitID
            // 
            this.colUnitID.HeaderText = "Unit ID";
            this.colUnitID.Name = "colUnitID";
            // 
            // colSem
            // 
            this.colSem.HeaderText = "Semester";
            this.colSem.Name = "colSem";
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            // 
            // lblMarkingGuide
            // 
            this.lblMarkingGuide.AutoSize = true;
            this.lblMarkingGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkingGuide.Location = new System.Drawing.Point(14, 169);
            this.lblMarkingGuide.Name = "lblMarkingGuide";
            this.lblMarkingGuide.Size = new System.Drawing.Size(130, 20);
            this.lblMarkingGuide.TabIndex = 48;
            this.lblMarkingGuide.Text = "Marking Guide:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(14, 265);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(91, 20);
            this.lblDueDate.TabIndex = 49;
            this.lblDueDate.Text = "Due Date:";
            // 
            // txtMarkingGuide
            // 
            this.txtMarkingGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkingGuide.Location = new System.Drawing.Point(184, 169);
            this.txtMarkingGuide.Multiline = true;
            this.txtMarkingGuide.Name = "txtMarkingGuide";
            this.txtMarkingGuide.Size = new System.Drawing.Size(282, 88);
            this.txtMarkingGuide.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(184, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 51;
            // 
            // frmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdAssessmentInfo);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.MinimumSize = new System.Drawing.Size(300, 299);
            this.Name = "frmAssessment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.TextBox txtAssID;
        public System.Windows.Forms.Label lblAssId;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblMarkingGuide;
        private System.Windows.Forms.ComboBox cmbAssType;
        public System.Windows.Forms.Label lblAssType;
        public System.Windows.Forms.Label lblAssTitle;
        public System.Windows.Forms.TextBox txtAssDesc;
        public System.Windows.Forms.TextBox txtAssTitle;
        public System.Windows.Forms.Label lblAssDesc;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.ComboBox cmbUnitId;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView grdAssessmentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox txtMarkingGuide;

    }
}