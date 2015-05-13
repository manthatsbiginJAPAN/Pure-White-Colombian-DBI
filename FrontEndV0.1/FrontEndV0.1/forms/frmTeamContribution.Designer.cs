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
            this.grdTaskInfo = new System.Windows.Forms.DataGridView();
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.grdAssessmentsInfo = new System.Windows.Forms.DataGridView();
            this.AssID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInfo)).BeginInit();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(540, 41);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Team Contribution Assessment";
            // 
            // grdTaskInfo
            // 
            this.grdTaskInfo.AllowUserToAddRows = false;
            this.grdTaskInfo.AllowUserToDeleteRows = false;
            this.grdTaskInfo.AllowUserToResizeRows = false;
            this.grdTaskInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTaskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaskInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskId,
            this.colTaskDesc});
            this.grdTaskInfo.Location = new System.Drawing.Point(648, 80);
            this.grdTaskInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(30, 425);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 46);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(221, 425);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 46);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(412, 425);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 46);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtTaskDesc);
            this.gbDetails.Controls.Add(this.lblTaskDesc);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(11, 495);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Size = new System.Drawing.Size(629, 254);
            this.gbDetails.TabIndex = 27;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDesc.Location = new System.Drawing.Point(165, 195);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(456, 212);
            this.txtTaskDesc.TabIndex = 50;
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDesc.Location = new System.Drawing.Point(14, 199);
            this.lblTaskDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(143, 57);
            this.lblTaskDesc.TabIndex = 48;
            this.lblTaskDesc.Text = "Task Description:";
            // 
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
            this.grdAssessmentsInfo.Name = "grdAssessmentsInfo";
            this.grdAssessmentsInfo.RowTemplate.Height = 24;
            this.grdAssessmentsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssessmentsInfo.Size = new System.Drawing.Size(602, 327);
            this.grdAssessmentsInfo.TabIndex = 28;
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
            // frmTeamContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 795);
            this.Controls.Add(this.grdAssessmentsInfo);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdTaskInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTeamContribution";
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInfo)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessmentsInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView grdTaskInfo;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskDesc;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.TextBox txtTaskDesc;
        public System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.DataGridView grdAssessmentsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
    }
}