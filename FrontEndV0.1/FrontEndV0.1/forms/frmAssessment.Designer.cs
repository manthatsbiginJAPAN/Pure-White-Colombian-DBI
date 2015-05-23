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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeerAss = new System.Windows.Forms.Button();
            this.btnTeamCont = new System.Windows.Forms.Button();
            this.txtMarkingGuide = new System.Windows.Forms.TextBox();
            this.lblMarkingGuide = new System.Windows.Forms.Label();
            this.lblAssTitle = new System.Windows.Forms.Label();
            this.txtAssDesc = new System.Windows.Forms.TextBox();
            this.txtAssTitle = new System.Windows.Forms.TextBox();
            this.lblAssDesc = new System.Windows.Forms.Label();
            this.txtAssID = new System.Windows.Forms.TextBox();
            this.lblAssId = new System.Windows.Forms.Label();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.cmbUnitId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdAssessmentInfo = new System.Windows.Forms.DataGridView();
            this.colAssID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.btnPeerAss);
            this.gbDetails.Controls.Add(this.btnTeamCont);
            this.gbDetails.Controls.Add(this.txtMarkingGuide);
            this.gbDetails.Controls.Add(this.lblMarkingGuide);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Create:";
            // 
            // btnPeerAss
            // 
            this.btnPeerAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeerAss.Location = new System.Drawing.Point(316, 128);
            this.btnPeerAss.Name = "btnPeerAss";
            this.btnPeerAss.Size = new System.Drawing.Size(137, 47);
            this.btnPeerAss.TabIndex = 51;
            this.btnPeerAss.Text = "Peer Assess.";
            this.btnPeerAss.UseVisualStyleBackColor = true;
            this.btnPeerAss.Click += new System.EventHandler(this.btnPeerAss_Click);
            // 
            // btnTeamCont
            // 
            this.btnTeamCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamCont.Location = new System.Drawing.Point(315, 75);
            this.btnTeamCont.Name = "btnTeamCont";
            this.btnTeamCont.Size = new System.Drawing.Size(137, 47);
            this.btnTeamCont.TabIndex = 20;
            this.btnTeamCont.Text = "Team Cont.";
            this.btnTeamCont.UseVisualStyleBackColor = true;
            this.btnTeamCont.Click += new System.EventHandler(this.btnTeamCont_Click);
            // 
            // txtMarkingGuide
            // 
            this.txtMarkingGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkingGuide.Location = new System.Drawing.Point(141, 195);
            this.txtMarkingGuide.Multiline = true;
            this.txtMarkingGuide.Name = "txtMarkingGuide";
            this.txtMarkingGuide.Size = new System.Drawing.Size(302, 98);
            this.txtMarkingGuide.TabIndex = 50;
            // 
            // lblMarkingGuide
            // 
            this.lblMarkingGuide.AutoSize = true;
            this.lblMarkingGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkingGuide.Location = new System.Drawing.Point(6, 195);
            this.lblMarkingGuide.Name = "lblMarkingGuide";
            this.lblMarkingGuide.Size = new System.Drawing.Size(130, 20);
            this.lblMarkingGuide.TabIndex = 48;
            this.lblMarkingGuide.Text = "Marking Guide:";
            // 
            // lblAssTitle
            // 
            this.lblAssTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssTitle.Location = new System.Drawing.Point(11, 43);
            this.lblAssTitle.Name = "lblAssTitle";
            this.lblAssTitle.Size = new System.Drawing.Size(110, 45);
            this.lblAssTitle.TabIndex = 20;
            this.lblAssTitle.Text = "Assessment Title:";
            // 
            // txtAssDesc
            // 
            this.txtAssDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssDesc.Location = new System.Drawing.Point(141, 88);
            this.txtAssDesc.Name = "txtAssDesc";
            this.txtAssDesc.Size = new System.Drawing.Size(131, 26);
            this.txtAssDesc.TabIndex = 23;
            // 
            // txtAssTitle
            // 
            this.txtAssTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssTitle.Location = new System.Drawing.Point(141, 43);
            this.txtAssTitle.Name = "txtAssTitle";
            this.txtAssTitle.Size = new System.Drawing.Size(131, 26);
            this.txtAssTitle.TabIndex = 21;
            // 
            // lblAssDesc
            // 
            this.lblAssDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssDesc.Location = new System.Drawing.Point(11, 88);
            this.lblAssDesc.Name = "lblAssDesc";
            this.lblAssDesc.Size = new System.Drawing.Size(110, 47);
            this.lblAssDesc.TabIndex = 22;
            this.lblAssDesc.Text = "Assessment Desc:";
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
            // cmbYear
            // 
            this.cmbYear.Enabled = false;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(150, 184);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 48;
            // 
            // cmbSem
            // 
            this.cmbSem.Enabled = false;
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Location = new System.Drawing.Point(150, 128);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(121, 21);
            this.cmbSem.TabIndex = 47;
            this.cmbSem.SelectedIndexChanged += new System.EventHandler(this.cmbSem_SelectedIndexChanged_1);
            // 
            // cmbUnitId
            // 
            this.cmbUnitId.FormattingEnabled = true;
            this.cmbUnitId.Location = new System.Drawing.Point(150, 77);
            this.cmbUnitId.Name = "cmbUnitId";
            this.cmbUnitId.Size = new System.Drawing.Size(121, 21);
            this.cmbUnitId.TabIndex = 46;
            this.cmbUnitId.SelectedIndexChanged += new System.EventHandler(this.cmbUnitId_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Semester:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Unit ID:";
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.grdAssessmentInfo.MultiSelect = false;
            this.grdAssessmentInfo.Name = "grdAssessmentInfo";
            this.grdAssessmentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssessmentInfo.Size = new System.Drawing.Size(421, 550);
            this.grdAssessmentInfo.TabIndex = 19;
            // 
            // colAssID
            // 
            this.colAssID.HeaderText = "Assessment ID";
            this.colAssID.Name = "colAssID";
            this.colAssID.ReadOnly = true;
            // 
            // colUnitID
            // 
            this.colUnitID.HeaderText = "Unit ID";
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.ReadOnly = true;
            // 
            // colSem
            // 
            this.colSem.HeaderText = "Semester";
            this.colSem.Name = "colSem";
            this.colSem.ReadOnly = true;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // frmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 609);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdAssessmentInfo);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.MinimumSize = new System.Drawing.Size(300, 296);
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
        public System.Windows.Forms.Label lblMarkingGuide;
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
        public System.Windows.Forms.TextBox txtMarkingGuide;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnPeerAss;
        public System.Windows.Forms.Button btnTeamCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;

    }
}