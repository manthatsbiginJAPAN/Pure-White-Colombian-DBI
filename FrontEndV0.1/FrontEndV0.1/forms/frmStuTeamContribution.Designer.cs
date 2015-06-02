namespace FrontEndV0._1.forms
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grdPeriods = new System.Windows.Forms.DataGridView();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPeriodHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdStudentHours = new System.Windows.Forms.DataGridView();
            this.StuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblArrow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 41);
            this.label1.TabIndex = 36;
            this.label1.Text = "Team Contribution Submission";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdTasks
            // 
            this.grdTasks.AllowUserToAddRows = false;
            this.grdTasks.AllowUserToDeleteRows = false;
            this.grdTasks.AllowUserToResizeColumns = false;
            this.grdTasks.AllowUserToResizeRows = false;
            this.grdTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Task});
            this.grdTasks.Location = new System.Drawing.Point(16, 97);
            this.grdTasks.Margin = new System.Windows.Forms.Padding(4);
            this.grdTasks.Name = "grdTasks";
            this.grdTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTasks.Size = new System.Drawing.Size(361, 631);
            this.grdTasks.TabIndex = 37;
            this.grdTasks.SelectionChanged += new System.EventHandler(this.grdTasks_SelectionChanged);
            // 
            // ID
            // 
            this.ID.FillWeight = 30.45685F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Task
            // 
            this.Task.FillWeight = 169.5432F;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(986, 736);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 46);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(796, 736);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 46);
            this.btnSubmit.TabIndex = 41;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grdPeriods
            // 
            this.grdPeriods.AllowUserToAddRows = false;
            this.grdPeriods.AllowUserToDeleteRows = false;
            this.grdPeriods.AllowUserToResizeRows = false;
            this.grdPeriods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPeriods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPeriods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.Date,
            this.TotalPeriodHours});
            this.grdPeriods.Location = new System.Drawing.Point(407, 97);
            this.grdPeriods.Margin = new System.Windows.Forms.Padding(4);
            this.grdPeriods.Name = "grdPeriods";
            this.grdPeriods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPeriods.Size = new System.Drawing.Size(361, 631);
            this.grdPeriods.TabIndex = 43;
            this.grdPeriods.SelectionChanged += new System.EventHandler(this.grdPeriods_SelectionChanged);
            // 
            // Period
            // 
            this.Period.HeaderText = "Period";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalPeriodHours
            // 
            this.TotalPeriodHours.HeaderText = "Total Hours";
            this.TotalPeriodHours.Name = "TotalPeriodHours";
            this.TotalPeriodHours.ReadOnly = true;
            // 
            // grdStudentHours
            // 
            this.grdStudentHours.AllowUserToAddRows = false;
            this.grdStudentHours.AllowUserToDeleteRows = false;
            this.grdStudentHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuID,
            this.Name,
            this.Hours});
            this.grdStudentHours.Location = new System.Drawing.Point(796, 97);
            this.grdStudentHours.Margin = new System.Windows.Forms.Padding(4);
            this.grdStudentHours.Name = "grdStudentHours";
            this.grdStudentHours.Size = new System.Drawing.Size(361, 631);
            this.grdStudentHours.TabIndex = 44;
            // 
            // StuID
            // 
            this.StuID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StuID.Frozen = true;
            this.StuID.HeaderText = "ID";
            this.StuID.Name = "StuID";
            this.StuID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Name.Frozen = true;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 130;
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.Location = new System.Drawing.Point(380, 358);
            this.lblArrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(25, 25);
            this.lblArrow.TabIndex = 44;
            this.lblArrow.Text = ">";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(769, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = ">";
            // 
            // frmStuTeamContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 795);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.grdStudentHours);
            this.Controls.Add(this.grdPeriods);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdTasks);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "frmStuTeamContribution";
            this.Text = "Team Contribution Submission";
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).EndInit();
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
        private System.Windows.Forms.DataGridView grdPeriods;
        private System.Windows.Forms.DataGridView grdStudentHours;
        public System.Windows.Forms.Label lblArrow;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPeriodHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
    }
}