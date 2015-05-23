namespace FrontEndV0._1.forms
{
    partial class frmAgenda
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
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cbStuID = new System.Windows.Forms.ComboBox();
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAgendaNum = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAgendaNum = new System.Windows.Forms.Label();
            this.txtAgendaDesc = new System.Windows.Forms.TextBox();
            this.lblActionDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdAgendatems = new System.Windows.Forms.DataGridView();
            this.colAgendaNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendatems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStuID
            // 
            this.lblStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.Location = new System.Drawing.Point(21, 60);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(91, 47);
            this.lblStuID.TabIndex = 46;
            this.lblStuID.Text = "Student Assigned:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(21, 115);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(91, 20);
            this.lblDueDate.TabIndex = 45;
            this.lblDueDate.Text = "Due Date:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.cbStuID);
            this.gbDetails.Controls.Add(this.dtDue);
            this.gbDetails.Controls.Add(this.btnAdd);
            this.gbDetails.Controls.Add(this.txtAgendaNum);
            this.gbDetails.Controls.Add(this.btnDelete);
            this.gbDetails.Controls.Add(this.btnEdit);
            this.gbDetails.Controls.Add(this.lblAgendaNum);
            this.gbDetails.Controls.Add(this.lblStuID);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.txtAgendaDesc);
            this.gbDetails.Controls.Add(this.lblActionDesc);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(8, 47);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(525, 305);
            this.gbDetails.TabIndex = 66;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = " ";
            // 
            // cbStuID
            // 
            this.cbStuID.FormattingEnabled = true;
            this.cbStuID.Location = new System.Drawing.Point(144, 71);
            this.cbStuID.Name = "cbStuID";
            this.cbStuID.Size = new System.Drawing.Size(121, 21);
            this.cbStuID.TabIndex = 80;
            // 
            // dtDue
            // 
            this.dtDue.Location = new System.Drawing.Point(144, 114);
            this.dtDue.Margin = new System.Windows.Forms.Padding(2);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(207, 20);
            this.dtDue.TabIndex = 79;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(384, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtAgendaNum
            // 
            this.txtAgendaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendaNum.Location = new System.Drawing.Point(144, 32);
            this.txtAgendaNum.Name = "txtAgendaNum";
            this.txtAgendaNum.Size = new System.Drawing.Size(121, 26);
            this.txtAgendaNum.TabIndex = 51;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(384, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(384, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblAgendaNum
            // 
            this.lblAgendaNum.AutoSize = true;
            this.lblAgendaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendaNum.Location = new System.Drawing.Point(21, 32);
            this.lblAgendaNum.Name = "lblAgendaNum";
            this.lblAgendaNum.Size = new System.Drawing.Size(117, 20);
            this.lblAgendaNum.TabIndex = 50;
            this.lblAgendaNum.Text = "Agenda Num:";
            // 
            // txtAgendaDesc
            // 
            this.txtAgendaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendaDesc.Location = new System.Drawing.Point(134, 174);
            this.txtAgendaDesc.Multiline = true;
            this.txtAgendaDesc.Name = "txtAgendaDesc";
            this.txtAgendaDesc.Size = new System.Drawing.Size(385, 106);
            this.txtAgendaDesc.TabIndex = 45;
            // 
            // lblActionDesc
            // 
            this.lblActionDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionDesc.Location = new System.Drawing.Point(11, 174);
            this.lblActionDesc.Name = "lblActionDesc";
            this.lblActionDesc.Size = new System.Drawing.Size(83, 40);
            this.lblActionDesc.TabIndex = 45;
            this.lblActionDesc.Text = "Agenda Desc:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(329, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 34);
            this.lblTitle.TabIndex = 63;
            this.lblTitle.Text = "Agenda Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdAgendatems
            // 
            this.grdAgendatems.AllowUserToAddRows = false;
            this.grdAgendatems.AllowUserToDeleteRows = false;
            this.grdAgendatems.AllowUserToResizeColumns = false;
            this.grdAgendatems.AllowUserToResizeRows = false;
            this.grdAgendatems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAgendatems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAgendatems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAgendaNum,
            this.colStuID,
            this.colDueDate});
            this.grdAgendatems.Location = new System.Drawing.Point(539, 57);
            this.grdAgendatems.Name = "grdAgendatems";
            this.grdAgendatems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAgendatems.Size = new System.Drawing.Size(363, 280);
            this.grdAgendatems.TabIndex = 68;
            // 
            // colAgendaNum
            // 
            this.colAgendaNum.HeaderText = "Agenda Number";
            this.colAgendaNum.Name = "colAgendaNum";
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
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 367);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdAgendatems);
            this.Name = "frmAgenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendatems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblStuID;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.Label lblActionDesc;
        public System.Windows.Forms.TextBox txtAgendaDesc;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView grdAgendatems;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgendaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        public System.Windows.Forms.TextBox txtAgendaNum;
        public System.Windows.Forms.Label lblAgendaNum;
        private System.Windows.Forms.DateTimePicker dtDue;
        private System.Windows.Forms.ComboBox cbStuID;
    }
}