namespace FrontEndV0._1.forms
{
    partial class frmStuPeerAssessment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStuPeerAssessment));
            this.lblArrow = new System.Windows.Forms.Label();
            this.grdStudentRatings = new System.Windows.Forms.DataGridView();
            this.StuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAspects = new System.Windows.Forms.DataGridView();
            this.CriterionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.General = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAspects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.Location = new System.Drawing.Point(765, 343);
            this.lblArrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(25, 25);
            this.lblArrow.TabIndex = 52;
            this.lblArrow.Text = ">";
            // 
            // grdStudentRatings
            // 
            this.grdStudentRatings.AllowUserToAddRows = false;
            this.grdStudentRatings.AllowUserToDeleteRows = false;
            this.grdStudentRatings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentRatings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuID,
            this.Name,
            this.Rating});
            this.grdStudentRatings.Location = new System.Drawing.Point(799, 92);
            this.grdStudentRatings.Margin = new System.Windows.Forms.Padding(4);
            this.grdStudentRatings.Name = "grdStudentRatings";
            this.grdStudentRatings.Size = new System.Drawing.Size(361, 591);
            this.grdStudentRatings.TabIndex = 53;
            // 
            // StuID
            // 
            this.StuID.HeaderText = "Student";
            this.StuID.Name = "StuID";
            this.StuID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating/Score";
            this.Rating.Name = "Rating";
            // 
            // grdAspects
            // 
            this.grdAspects.AllowUserToAddRows = false;
            this.grdAspects.AllowUserToDeleteRows = false;
            this.grdAspects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAspects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAspects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CriterionID,
            this.General,
            this.Specific});
            this.grdAspects.Location = new System.Drawing.Point(19, 92);
            this.grdAspects.Margin = new System.Windows.Forms.Padding(4);
            this.grdAspects.Name = "grdAspects";
            this.grdAspects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAspects.Size = new System.Drawing.Size(739, 591);
            this.grdAspects.TabIndex = 47;
            this.grdAspects.SelectionChanged += new System.EventHandler(this.grdAspects_SelectionChanged);
            // 
            // CriterionID
            // 
            this.CriterionID.HeaderText = "Criterion ID";
            this.CriterionID.Name = "CriterionID";
            this.CriterionID.ReadOnly = true;
            // 
            // General
            // 
            this.General.HeaderText = "General Aspect";
            this.General.Name = "General";
            this.General.ReadOnly = true;
            // 
            // Specific
            // 
            this.Specific.HeaderText = "Specific Aspect";
            this.Specific.Name = "Specific";
            this.Specific.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(989, 691);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 46);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 41);
            this.label1.TabIndex = 46;
            this.label1.Text = "Peer Assessment Submission";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(799, 691);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 46);
            this.btnSubmit.TabIndex = 49;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmStuPeerAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 750);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.grdStudentRatings);
            this.Controls.Add(this.grdAspects);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAspects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.DataGridView grdStudentRatings;
        private System.Windows.Forms.DataGridView grdAspects;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriterionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn General;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specific;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
    }
}