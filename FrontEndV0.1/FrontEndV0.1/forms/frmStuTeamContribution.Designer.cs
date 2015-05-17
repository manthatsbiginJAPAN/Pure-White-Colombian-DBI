﻿namespace FrontEndV0._1.forms
{
    partial class frmStuTeamContribution
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdTasks = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateSubmitted = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.grdPeriods = new System.Windows.Forms.DataGridView();
            this.grdStudentHours = new System.Windows.Forms.DataGridView();
            this.lblArrow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalHours = new System.Windows.Forms.TextBox();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPeriodHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).BeginInit();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Team Contribution Submission";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdTasks
            // 
            this.grdTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task});
            this.grdTasks.Location = new System.Drawing.Point(12, 79);
            this.grdTasks.Name = "grdTasks";
            this.grdTasks.Size = new System.Drawing.Size(271, 424);
            this.grdTasks.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(740, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 37);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(597, 526);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 37);
            this.btnSubmit.TabIndex = 41;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtTotalHours);
            this.gbDetails.Controls.Add(this.lblTotalHours);
            this.gbDetails.Controls.Add(this.txtTeamID);
            this.gbDetails.Controls.Add(this.lblTeamID);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.dateTimePicker2);
            this.gbDetails.Controls.Add(this.lblDateSubmitted);
            this.gbDetails.Controls.Add(this.dateTimePicker1);
            this.gbDetails.Location = new System.Drawing.Point(12, 526);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(561, 108);
            this.gbDetails.TabIndex = 42;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Other Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(397, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblDateSubmitted
            // 
            this.lblDateSubmitted.AutoSize = true;
            this.lblDateSubmitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSubmitted.Location = new System.Drawing.Point(302, 19);
            this.lblDateSubmitted.Name = "lblDateSubmitted";
            this.lblDateSubmitted.Size = new System.Drawing.Size(96, 20);
            this.lblDateSubmitted.TabIndex = 39;
            this.lblDateSubmitted.Text = "Submitted:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(48, 19);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(47, 20);
            this.lblDueDate.TabIndex = 41;
            this.lblDueDate.Text = "Due:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(101, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(18, 56);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(77, 20);
            this.lblTeamID.TabIndex = 42;
            this.lblTeamID.Text = "TeamID:";
            // 
            // txtTeamID
            // 
            this.txtTeamID.Location = new System.Drawing.Point(101, 58);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(142, 20);
            this.txtTeamID.TabIndex = 43;
            // 
            // grdPeriods
            // 
            this.grdPeriods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPeriods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPeriods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.Date,
            this.TotalPeriodHours});
            this.grdPeriods.Location = new System.Drawing.Point(305, 79);
            this.grdPeriods.Name = "grdPeriods";
            this.grdPeriods.Size = new System.Drawing.Size(271, 424);
            this.grdPeriods.TabIndex = 43;
            // 
            // grdStudentHours
            // 
            this.grdStudentHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuID,
            this.Hours});
            this.grdStudentHours.Location = new System.Drawing.Point(597, 79);
            this.grdStudentHours.Name = "grdStudentHours";
            this.grdStudentHours.Size = new System.Drawing.Size(271, 424);
            this.grdStudentHours.TabIndex = 44;
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.Location = new System.Drawing.Point(285, 291);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(19, 20);
            this.lblArrow.TabIndex = 44;
            this.lblArrow.Text = ">";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = ">";
            // 
            // StuID
            // 
            this.StuID.HeaderText = "Student";
            this.StuID.Name = "StuID";
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.Location = new System.Drawing.Point(397, 56);
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.Size = new System.Drawing.Size(142, 20);
            this.txtTotalHours.TabIndex = 45;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(276, 56);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(123, 20);
            this.lblTotalHours.TabIndex = 44;
            this.lblTotalHours.Text = "Project Hours:";
            // 
            // Period
            // 
            this.Period.HeaderText = "Period";
            this.Period.Name = "Period";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // TotalPeriodHours
            // 
            this.TotalPeriodHours.HeaderText = "Total Hours";
            this.TotalPeriodHours.Name = "TotalPeriodHours";
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // frmStuTeamContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.grdStudentHours);
            this.Controls.Add(this.grdPeriods);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdTasks);
            this.Controls.Add(this.label1);
            this.Name = "frmStuTeamContribution";
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdTasks;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTeamID;
        public System.Windows.Forms.Label lblTeamID;
        public System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label lblDateSubmitted;
        private System.Windows.Forms.DataGridView grdPeriods;
        private System.Windows.Forms.DataGridView grdStudentHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        public System.Windows.Forms.Label lblArrow;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalHours;
        public System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPeriodHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
    }
}