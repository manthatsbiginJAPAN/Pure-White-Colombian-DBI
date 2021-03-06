﻿namespace FrontEndV0._1.forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamContribution));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdTaskInfo = new System.Windows.Forms.DataGridView();
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInfo)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(225, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(441, 34);
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
            this.colTaskDesc,
            this.Duedate});
            this.grdTaskInfo.Location = new System.Drawing.Point(486, 108);
            this.grdTaskInfo.Name = "grdTaskInfo";
            this.grdTaskInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTaskInfo.Size = new System.Drawing.Size(406, 513);
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
            // Duedate
            // 
            this.Duedate.HeaderText = "Due Date";
            this.Duedate.Name = "Duedate";
            this.Duedate.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(377, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 37);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(377, 151);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 37);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(377, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtPeriods);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.txtTaskId);
            this.gbDetails.Controls.Add(this.lblTaskId);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.dtDue);
            this.gbDetails.Controls.Add(this.txtTaskDesc);
            this.gbDetails.Controls.Add(this.lblTaskDesc);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(22, 102);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(351, 384);
            this.gbDetails.TabIndex = 27;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(130, 138);
            this.txtPeriods.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(58, 20);
            this.txtPeriods.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 47);
            this.label2.TabIndex = 55;
            this.label2.Text = "Number of Periods:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(130, 29);
            this.txtTaskId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(123, 20);
            this.txtTaskId.TabIndex = 54;
            // 
            // lblTaskId
            // 
            this.lblTaskId.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskId.Location = new System.Drawing.Point(34, 29);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(87, 20);
            this.lblTaskId.TabIndex = 53;
            this.lblTaskId.Text = "Task ID:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(23, 83);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(98, 25);
            this.lblDueDate.TabIndex = 52;
            this.lblDueDate.Text = "Date Due:";
            // 
            // dtDue
            // 
            this.dtDue.Location = new System.Drawing.Point(130, 83);
            this.dtDue.Margin = new System.Windows.Forms.Padding(2);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(196, 20);
            this.dtDue.TabIndex = 51;
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDesc.Location = new System.Drawing.Point(15, 232);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(311, 134);
            this.txtTaskDesc.TabIndex = 50;
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDesc.Location = new System.Drawing.Point(11, 205);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(165, 26);
            this.lblTaskDesc.TabIndex = 48;
            this.lblTaskDesc.Text = "Task Description:";
            this.lblTaskDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tasks";
            // 
            // frmTeamContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdTaskInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeamContribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInfo)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Duedate;
        private System.Windows.Forms.DateTimePicker dtDue;
        public System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtTaskId;
        public System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssID;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriods;
        public System.Windows.Forms.Label label2;
    }
}