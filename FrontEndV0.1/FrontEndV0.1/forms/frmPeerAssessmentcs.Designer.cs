namespace FrontEndV0._1.forms
{
    partial class frmPeerAssessmentcs
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
            this.txtCritID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCritID = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpecificCrit = new System.Windows.Forms.TextBox();
            this.lblSpecfic = new System.Windows.Forms.Label();
            this.txtGeneralCrit = new System.Windows.Forms.TextBox();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.grdCriteriaInfo = new System.Windows.Forms.DataGridView();
            this.colCritID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeneralCrit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecificCrit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdAssessmentsInfo = new System.Windows.Forms.DataGridView();
            this.AssID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCriteriaInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCritID
            // 
            this.txtCritID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritID.Location = new System.Drawing.Point(210, 26);
            this.txtCritID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCritID.Name = "txtCritID";
            this.txtCritID.Size = new System.Drawing.Size(160, 30);
            this.txtCritID.TabIndex = 50;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(423, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 41);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Peer Assessment";
            // 
            // lblCritID
            // 
            this.lblCritID.AutoSize = true;
            this.lblCritID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCritID.Location = new System.Drawing.Point(58, 26);
            this.lblCritID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCritID.Name = "lblCritID";
            this.lblCritID.Size = new System.Drawing.Size(128, 25);
            this.lblCritID.TabIndex = 49;
            this.lblCritID.Text = "Criterion ID:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dtDue);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.txtCritID);
            this.gbDetails.Controls.Add(this.lblCritID);
            this.gbDetails.Controls.Add(this.txtSpecificCrit);
            this.gbDetails.Controls.Add(this.lblSpecfic);
            this.gbDetails.Controls.Add(this.txtGeneralCrit);
            this.gbDetails.Controls.Add(this.lblGeneral);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(11, 412);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetails.Size = new System.Drawing.Size(629, 306);
            this.gbDetails.TabIndex = 34;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // dtDue
            // 
            this.dtDue.Location = new System.Drawing.Point(210, 264);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(258, 23);
            this.dtDue.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Due Date:";
            // 
            // txtSpecificCrit
            // 
            this.txtSpecificCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecificCrit.Location = new System.Drawing.Point(210, 125);
            this.txtSpecificCrit.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecificCrit.Multiline = true;
            this.txtSpecificCrit.Name = "txtSpecificCrit";
            this.txtSpecificCrit.Size = new System.Drawing.Size(411, 113);
            this.txtSpecificCrit.TabIndex = 52;
            // 
            // lblSpecfic
            // 
            this.lblSpecfic.AutoSize = true;
            this.lblSpecfic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecfic.Location = new System.Drawing.Point(14, 129);
            this.lblSpecfic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecfic.Name = "lblSpecfic";
            this.lblSpecfic.Size = new System.Drawing.Size(172, 25);
            this.lblSpecfic.TabIndex = 51;
            this.lblSpecfic.Text = "Specific Criteria:";
            // 
            // txtGeneralCrit
            // 
            this.txtGeneralCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneralCrit.Location = new System.Drawing.Point(210, 76);
            this.txtGeneralCrit.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralCrit.Multiline = true;
            this.txtGeneralCrit.Name = "txtGeneralCrit";
            this.txtGeneralCrit.Size = new System.Drawing.Size(223, 27);
            this.txtGeneralCrit.TabIndex = 50;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(14, 80);
            this.lblGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(171, 25);
            this.lblGeneral.TabIndex = 48;
            this.lblGeneral.Text = "General Criteria:";
            // 
            // grdCriteriaInfo
            // 
            this.grdCriteriaInfo.AllowUserToAddRows = false;
            this.grdCriteriaInfo.AllowUserToDeleteRows = false;
            this.grdCriteriaInfo.AllowUserToResizeRows = false;
            this.grdCriteriaInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCriteriaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCriteriaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCritID,
            this.colGeneralCrit,
            this.colSpecificCrit,
            this.DueDate});
            this.grdCriteriaInfo.Location = new System.Drawing.Point(648, 87);
            this.grdCriteriaInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grdCriteriaInfo.Name = "grdCriteriaInfo";
            this.grdCriteriaInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCriteriaInfo.Size = new System.Drawing.Size(561, 677);
            this.grdCriteriaInfo.TabIndex = 33;
            // 
            // colCritID
            // 
            this.colCritID.FillWeight = 46.30474F;
            this.colCritID.HeaderText = "Criterion ID";
            this.colCritID.Name = "colCritID";
            // 
            // colGeneralCrit
            // 
            this.colGeneralCrit.FillWeight = 93.79678F;
            this.colGeneralCrit.HeaderText = "General Criteria";
            this.colGeneralCrit.MinimumWidth = 80;
            this.colGeneralCrit.Name = "colGeneralCrit";
            // 
            // colSpecificCrit
            // 
            this.colSpecificCrit.FillWeight = 159.8985F;
            this.colSpecificCrit.HeaderText = "Specific Criteria";
            this.colSpecificCrit.MinimumWidth = 105;
            this.colSpecificCrit.Name = "colSpecificCrit";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 736);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 46);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(205, 736);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 46);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(396, 736);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 46);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdAssessmentsInfo
            // 
            this.grdAssessmentsInfo.AllowUserToAddRows = false;
            this.grdAssessmentsInfo.AllowUserToDeleteRows = false;
            this.grdAssessmentsInfo.AllowUserToResizeColumns = false;
            this.grdAssessmentsInfo.AllowUserToResizeRows = false;
            this.grdAssessmentsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAssessmentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssessmentsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssID,
            this.UnitID,
            this.Semester,
            this.Year});
            this.grdAssessmentsInfo.Location = new System.Drawing.Point(10, 87);
            this.grdAssessmentsInfo.Name = "grdAssessmentsInfo";
            this.grdAssessmentsInfo.RowTemplate.Height = 24;
            this.grdAssessmentsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssessmentsInfo.Size = new System.Drawing.Size(630, 318);
            this.grdAssessmentsInfo.TabIndex = 35;
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
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // frmPeerAssessmentcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 795);
            this.Controls.Add(this.grdAssessmentsInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.grdCriteriaInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPeerAssessmentcs";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCriteriaInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentsInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCritID;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblCritID;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.TextBox txtGeneralCrit;
        public System.Windows.Forms.Label lblGeneral;
        public System.Windows.Forms.DataGridView grdCriteriaInfo;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtSpecificCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCritID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneralCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecificCrit;
        private System.Windows.Forms.DataGridView grdAssessmentsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DateTimePicker dtDue;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblSpecfic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;

    }
}