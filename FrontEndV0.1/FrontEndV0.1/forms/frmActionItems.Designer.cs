﻿namespace FrontEndV0._1.forms
{
    partial class frmActionItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionItems));
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.cbStuID = new System.Windows.Forms.ComboBox();
            this.txtActionItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtActionDesc = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblActionItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblActionDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdActionItems = new System.Windows.Forms.DataGridView();
            this.colActionNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActionItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dtDue);
            this.gbDetails.Controls.Add(this.cbStuID);
            this.gbDetails.Controls.Add(this.txtActionItem);
            this.gbDetails.Controls.Add(this.btnAdd);
            this.gbDetails.Controls.Add(this.txtActionDesc);
            this.gbDetails.Controls.Add(this.btnDelete);
            this.gbDetails.Controls.Add(this.btnEdit);
            this.gbDetails.Controls.Add(this.lblActionItems);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.cbStatus);
            this.gbDetails.Controls.Add(this.lblStuID);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.lblActionDesc);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(12, 49);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(500, 306);
            this.gbDetails.TabIndex = 59;
            this.gbDetails.TabStop = false;
            // 
            // dtDue
            // 
            this.dtDue.CustomFormat = "dd/MM/yyyy";
            this.dtDue.Enabled = false;
            this.dtDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDue.Location = new System.Drawing.Point(183, 104);
            this.dtDue.Margin = new System.Windows.Forms.Padding(2);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(121, 20);
            this.dtDue.TabIndex = 75;
            this.dtDue.Value = new System.DateTime(2015, 5, 24, 0, 0, 0, 0);
            // 
            // cbStuID
            // 
            this.cbStuID.Enabled = false;
            this.cbStuID.FormattingEnabled = true;
            this.cbStuID.Location = new System.Drawing.Point(183, 67);
            this.cbStuID.Name = "cbStuID";
            this.cbStuID.Size = new System.Drawing.Size(121, 21);
            this.cbStuID.TabIndex = 81;
            // 
            // txtActionItem
            // 
            this.txtActionItem.Enabled = false;
            this.txtActionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActionItem.Location = new System.Drawing.Point(183, 27);
            this.txtActionItem.Name = "txtActionItem";
            this.txtActionItem.Size = new System.Drawing.Size(121, 26);
            this.txtActionItem.TabIndex = 77;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(363, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 37);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtActionDesc
            // 
            this.txtActionDesc.Enabled = false;
            this.txtActionDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActionDesc.Location = new System.Drawing.Point(126, 167);
            this.txtActionDesc.Multiline = true;
            this.txtActionDesc.Name = "txtActionDesc";
            this.txtActionDesc.Size = new System.Drawing.Size(356, 133);
            this.txtActionDesc.TabIndex = 45;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(363, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 37);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(363, 67);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 37);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblActionItems
            // 
            this.lblActionItems.AutoSize = true;
            this.lblActionItems.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionItems.Location = new System.Drawing.Point(32, 29);
            this.lblActionItems.Name = "lblActionItems";
            this.lblActionItems.Size = new System.Drawing.Size(146, 21);
            this.lblActionItems.TabIndex = 76;
            this.lblActionItems.Text = "Action Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Completion Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbStatus.Location = new System.Drawing.Point(183, 135);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(40, 21);
            this.cbStatus.TabIndex = 45;
            // 
            // lblStuID
            // 
            this.lblStuID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.Location = new System.Drawing.Point(13, 67);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(165, 36);
            this.lblStuID.TabIndex = 46;
            this.lblStuID.Text = "Student Assigned:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(79, 103);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 21);
            this.lblDueDate.TabIndex = 45;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblActionDesc
            // 
            this.lblActionDesc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionDesc.Location = new System.Drawing.Point(0, 167);
            this.lblActionDesc.Name = "lblActionDesc";
            this.lblActionDesc.Size = new System.Drawing.Size(120, 55);
            this.lblActionDesc.TabIndex = 45;
            this.lblActionDesc.Text = "Action Description:";
            this.lblActionDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(342, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 34);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Action Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdActionItems
            // 
            this.grdActionItems.AllowUserToAddRows = false;
            this.grdActionItems.AllowUserToDeleteRows = false;
            this.grdActionItems.AllowUserToResizeColumns = false;
            this.grdActionItems.AllowUserToResizeRows = false;
            this.grdActionItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdActionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdActionItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActionNum,
            this.colStuID,
            this.colDueDate,
            this.colStatus});
            this.grdActionItems.Location = new System.Drawing.Point(526, 54);
            this.grdActionItems.Name = "grdActionItems";
            this.grdActionItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdActionItems.Size = new System.Drawing.Size(376, 300);
            this.grdActionItems.TabIndex = 74;
            // 
            // colActionNum
            // 
            this.colActionNum.HeaderText = "Action Number";
            this.colActionNum.Name = "colActionNum";
            // 
            // colStuID
            // 
            this.colStuID.HeaderText = "Student ID";
            this.colStuID.Name = "colStuID";
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Complete?";
            this.colStatus.Name = "colStatus";
            // 
            // frmActionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 367);
            this.Controls.Add(this.grdActionItems);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActionItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmActionItems_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActionItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblActionDesc;
        public System.Windows.Forms.TextBox txtActionDesc;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.Label lblStuID;
        public System.Windows.Forms.DataGridView grdActionItems;
        public System.Windows.Forms.TextBox txtActionItem;
        public System.Windows.Forms.Label lblActionItems;
        private System.Windows.Forms.ComboBox cbStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DateTimePicker dtDue;



    }
}