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
            this.lblArrow = new System.Windows.Forms.Label();
            this.grdStudentRatings = new System.Windows.Forms.DataGridView();
            this.StuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAspects = new System.Windows.Forms.DataGridView();
            this.txtTotalHours = new System.Windows.Forms.TextBox();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDateSubmitted = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Specific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.General = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriterionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAspects)).BeginInit();
            this.gbDetails.SuspendLayout();
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
            this.grdStudentRatings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentRatings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuID,
            this.Rating});
            this.grdStudentRatings.Location = new System.Drawing.Point(799, 92);
            this.grdStudentRatings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdStudentRatings.Name = "grdStudentRatings";
            this.grdStudentRatings.Size = new System.Drawing.Size(361, 425);
            this.grdStudentRatings.TabIndex = 53;
            // 
            // StuID
            // 
            this.StuID.HeaderText = "Student";
            this.StuID.Name = "StuID";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating/Score";
            this.Rating.Name = "Rating";
            // 
            // grdAspects
            // 
            this.grdAspects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAspects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAspects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CriterionID,
            this.General,
            this.Specific});
            this.grdAspects.Location = new System.Drawing.Point(19, 92);
            this.grdAspects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdAspects.Name = "grdAspects";
            this.grdAspects.Size = new System.Drawing.Size(739, 425);
            this.grdAspects.TabIndex = 47;
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.Location = new System.Drawing.Point(529, 69);
            this.txtTotalHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.Size = new System.Drawing.Size(188, 22);
            this.txtTotalHours.TabIndex = 45;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(368, 69);
            this.lblTotalHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(149, 25);
            this.lblTotalHours.TabIndex = 44;
            this.lblTotalHours.Text = "Project Hours:";
            // 
            // txtTeamID
            // 
            this.txtTeamID.Location = new System.Drawing.Point(153, 71);
            this.txtTeamID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(188, 22);
            this.txtTeamID.TabIndex = 43;
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(43, 69);
            this.lblTeamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(95, 25);
            this.lblTeamID.TabIndex = 42;
            this.lblTeamID.Text = "TeamID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(989, 537);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 46);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(83, 23);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(58, 25);
            this.lblDueDate.TabIndex = 41;
            this.lblDueDate.Text = "Due:";
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
            this.btnSubmit.Location = new System.Drawing.Point(799, 537);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 46);
            this.btnSubmit.TabIndex = 49;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 25);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // lblDateSubmitted
            // 
            this.lblDateSubmitted.AutoSize = true;
            this.lblDateSubmitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSubmitted.Location = new System.Drawing.Point(403, 23);
            this.lblDateSubmitted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateSubmitted.Name = "lblDateSubmitted";
            this.lblDateSubmitted.Size = new System.Drawing.Size(116, 25);
            this.lblDateSubmitted.TabIndex = 39;
            this.lblDateSubmitted.Text = "Submitted:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.textBox1);
            this.gbDetails.Controls.Add(this.lblComments);
            this.gbDetails.Controls.Add(this.txtTotalHours);
            this.gbDetails.Controls.Add(this.lblTotalHours);
            this.gbDetails.Controls.Add(this.txtTeamID);
            this.gbDetails.Controls.Add(this.lblTeamID);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.dateTimePicker2);
            this.gbDetails.Controls.Add(this.lblDateSubmitted);
            this.gbDetails.Controls.Add(this.dateTimePicker1);
            this.gbDetails.Location = new System.Drawing.Point(19, 529);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Size = new System.Drawing.Size(739, 256);
            this.gbDetails.TabIndex = 50;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Other Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 122);
            this.textBox1.TabIndex = 47;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(13, 118);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(122, 25);
            this.lblComments.TabIndex = 46;
            this.lblComments.Text = "Comments:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Specific
            // 
            this.Specific.HeaderText = "Specific Aspect";
            this.Specific.Name = "Specific";
            // 
            // General
            // 
            this.General.HeaderText = "General Aspect";
            this.General.Name = "General";
            // 
            // CriterionID
            // 
            this.CriterionID.HeaderText = "Criterion ID";
            this.CriterionID.Name = "CriterionID";
            // 
            // frmStuPeerAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 795);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.grdStudentRatings);
            this.Controls.Add(this.grdAspects);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStuPeerAssessment";
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAspects)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.DataGridView grdStudentRatings;
        private System.Windows.Forms.DataGridView grdAspects;
        private System.Windows.Forms.TextBox txtTotalHours;
        public System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.TextBox txtTeamID;
        public System.Windows.Forms.Label lblTeamID;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label lblDateSubmitted;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriterionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn General;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specific;
    }
}