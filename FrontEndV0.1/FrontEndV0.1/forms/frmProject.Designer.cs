namespace FrontEndV0._1.forms
{
    partial class frmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProject));
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbUnitID = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdProjects = new System.Windows.Forms.DataGridView();
            this.colProjID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtProjDesc = new System.Windows.Forms.TextBox();
            this.lblProjDesc = new System.Windows.Forms.Label();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.txtProjID = new System.Windows.Forms.TextBox();
            this.lblProjID = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.gbIdentifyingInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(170, 191);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(374, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 34);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Projects";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(170, 144);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(121, 21);
            this.cbSemester.TabIndex = 35;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // cbUnitID
            // 
            this.cbUnitID.FormattingEnabled = true;
            this.cbUnitID.Items.AddRange(new object[] {
            "INF30011",
            "INF20011"});
            this.cbUnitID.Location = new System.Drawing.Point(170, 94);
            this.cbUnitID.Name = "cbUnitID";
            this.cbUnitID.Size = new System.Drawing.Size(121, 21);
            this.cbUnitID.TabIndex = 34;
            this.cbUnitID.SelectedIndexChanged += new System.EventHandler(this.cbUnitID_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(342, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdProjects
            // 
            this.grdProjects.AllowUserToAddRows = false;
            this.grdProjects.AllowUserToDeleteRows = false;
            this.grdProjects.AllowUserToResizeColumns = false;
            this.grdProjects.AllowUserToResizeRows = false;
            this.grdProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjID,
            this.projdesc,
            this.Unitid,
            this.Semester,
            this.Year});
            this.grdProjects.Location = new System.Drawing.Point(486, 64);
            this.grdProjects.Name = "grdProjects";
            this.grdProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProjects.Size = new System.Drawing.Size(421, 569);
            this.grdProjects.TabIndex = 40;
            // 
            // colProjID
            // 
            this.colProjID.HeaderText = "Project ID";
            this.colProjID.Name = "colProjID";
            // 
            // projdesc
            // 
            this.projdesc.HeaderText = "Description";
            this.projdesc.Name = "projdesc";
            this.projdesc.Visible = false;
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
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(98, 191);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 21);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtProjDesc);
            this.gbDetails.Controls.Add(this.lblProjDesc);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(7, 356);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(472, 277);
            this.gbDetails.TabIndex = 38;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtProjDesc
            // 
            this.txtProjDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjDesc.Location = new System.Drawing.Point(21, 74);
            this.txtProjDesc.Multiline = true;
            this.txtProjDesc.Name = "txtProjDesc";
            this.txtProjDesc.Size = new System.Drawing.Size(427, 124);
            this.txtProjDesc.TabIndex = 39;
            // 
            // lblProjDesc
            // 
            this.lblProjDesc.AutoSize = true;
            this.lblProjDesc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjDesc.Location = new System.Drawing.Point(17, 45);
            this.lblProjDesc.Name = "lblProjDesc";
            this.lblProjDesc.Size = new System.Drawing.Size(185, 21);
            this.lblProjDesc.TabIndex = 15;
            this.lblProjDesc.Text = "Project Description:";
            // 
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.txtProjID);
            this.gbIdentifyingInformation.Controls.Add(this.lblProjID);
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
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 282);
            this.gbIdentifyingInformation.TabIndex = 36;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // txtProjID
            // 
            this.txtProjID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjID.Location = new System.Drawing.Point(170, 38);
            this.txtProjID.Name = "txtProjID";
            this.txtProjID.Size = new System.Drawing.Size(121, 26);
            this.txtProjID.TabIndex = 38;
            // 
            // lblProjID
            // 
            this.lblProjID.AutoSize = true;
            this.lblProjID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjID.Location = new System.Drawing.Point(47, 40);
            this.lblProjID.Name = "lblProjID";
            this.lblProjID.Size = new System.Drawing.Size(114, 21);
            this.lblProjID.TabIndex = 37;
            this.lblProjID.Text = "Project ID: ";
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(64, 144);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(91, 21);
            this.lblSem.TabIndex = 11;
            this.lblSem.Text = "Semester:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(71, 94);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(84, 21);
            this.lblUnitID.TabIndex = 1;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdProjects);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProject";
            this.Load += new System.EventHandler(this.frmProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbUnitID;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView grdProjects;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.Label lblProjDesc;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.Label lblSem;
        public System.Windows.Forms.Label lblUnitID;
        public System.Windows.Forms.Label lblProjID;
        public System.Windows.Forms.TextBox txtProjID;
        public System.Windows.Forms.TextBox txtProjDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjID;
        private System.Windows.Forms.DataGridViewTextBoxColumn projdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}