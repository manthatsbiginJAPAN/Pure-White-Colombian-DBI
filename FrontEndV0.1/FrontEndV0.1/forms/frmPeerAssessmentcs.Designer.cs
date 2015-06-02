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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeerAssessmentcs));
            this.txtCritID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCritID = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCriteriaInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCritID
            // 
            this.txtCritID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritID.Location = new System.Drawing.Point(172, 22);
            this.txtCritID.Name = "txtCritID";
            this.txtCritID.Size = new System.Drawing.Size(121, 26);
            this.txtCritID.TabIndex = 50;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(317, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 34);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Peer Assessment";
            // 
            // lblCritID
            // 
            this.lblCritID.AutoSize = true;
            this.lblCritID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCritID.Location = new System.Drawing.Point(43, 24);
            this.lblCritID.Name = "lblCritID";
            this.lblCritID.Size = new System.Drawing.Size(123, 21);
            this.lblCritID.TabIndex = 49;
            this.lblCritID.Text = "Criterion ID:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtCritID);
            this.gbDetails.Controls.Add(this.lblCritID);
            this.gbDetails.Controls.Add(this.txtSpecificCrit);
            this.gbDetails.Controls.Add(this.lblSpecfic);
            this.gbDetails.Controls.Add(this.txtGeneralCrit);
            this.gbDetails.Controls.Add(this.lblGeneral);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(8, 79);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(361, 318);
            this.gbDetails.TabIndex = 34;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtSpecificCrit
            // 
            this.txtSpecificCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecificCrit.Location = new System.Drawing.Point(14, 214);
            this.txtSpecificCrit.Multiline = true;
            this.txtSpecificCrit.Name = "txtSpecificCrit";
            this.txtSpecificCrit.Size = new System.Drawing.Size(328, 81);
            this.txtSpecificCrit.TabIndex = 52;
            // 
            // lblSpecfic
            // 
            this.lblSpecfic.AutoSize = true;
            this.lblSpecfic.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecfic.Location = new System.Drawing.Point(10, 186);
            this.lblSpecfic.Name = "lblSpecfic";
            this.lblSpecfic.Size = new System.Drawing.Size(143, 21);
            this.lblSpecfic.TabIndex = 51;
            this.lblSpecfic.Text = "Specific Aspect";
            // 
            // txtGeneralCrit
            // 
            this.txtGeneralCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneralCrit.Location = new System.Drawing.Point(14, 105);
            this.txtGeneralCrit.Multiline = true;
            this.txtGeneralCrit.Name = "txtGeneralCrit";
            this.txtGeneralCrit.Size = new System.Drawing.Size(328, 52);
            this.txtGeneralCrit.TabIndex = 50;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(10, 80);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(146, 21);
            this.lblGeneral.TabIndex = 48;
            this.lblGeneral.Text = "General Aspect:";
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
            this.colSpecificCrit});
            this.grdCriteriaInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCriteriaInfo.Location = new System.Drawing.Point(486, 83);
            this.grdCriteriaInfo.Name = "grdCriteriaInfo";
            this.grdCriteriaInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCriteriaInfo.Size = new System.Drawing.Size(421, 538);
            this.grdCriteriaInfo.TabIndex = 33;
            this.grdCriteriaInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCriteriaInfo_SelectionChanged);
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
            this.colGeneralCrit.HeaderText = "General Aspect";
            this.colGeneralCrit.MinimumWidth = 80;
            this.colGeneralCrit.Name = "colGeneralCrit";
            // 
            // colSpecificCrit
            // 
            this.colSpecificCrit.FillWeight = 159.8985F;
            this.colSpecificCrit.HeaderText = "Specific Aspect";
            this.colSpecificCrit.MinimumWidth = 105;
            this.colSpecificCrit.Name = "colSpecificCrit";
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
            this.colGeneralCrit.HeaderText = "General Aspect";
            this.colGeneralCrit.MinimumWidth = 80;
            this.colGeneralCrit.Name = "colGeneralCrit";
            // 
            // colSpecificCrit
            // 
            this.colSpecificCrit.FillWeight = 159.8985F;
            this.colSpecificCrit.HeaderText = "Specific Aspect";
            this.colSpecificCrit.MinimumWidth = 105;
            this.colSpecificCrit.Name = "colSpecificCrit";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(375, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 37);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(375, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 37);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(375, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 37);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Criteria";
            // 
            // frmPeerAssessmentcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.grdCriteriaInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPeerAssessmentcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< HEAD
=======
            this.Load += new System.EventHandler(this.frmPeerAssessmentcs_Load);
>>>>>>> origin/master
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCriteriaInfo)).EndInit();
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
        public System.Windows.Forms.Label lblSpecfic;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCritID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneralCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecificCrit;

    }
}