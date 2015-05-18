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
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.txtAgendaNum = new System.Windows.Forms.TextBox();
            this.lblAgendaNum = new System.Windows.Forms.Label();
            this.lblMeetingMinutes = new System.Windows.Forms.Label();
            this.txtMeetingMinutes = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.lblActionDesc = new System.Windows.Forms.Label();
            this.txtAgendaDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdAgendatems = new System.Windows.Forms.DataGridView();
            this.colAgendaNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdMeetings = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendatems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStuID
            // 
            this.lblStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.Location = new System.Drawing.Point(11, 181);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(91, 47);
            this.lblStuID.TabIndex = 46;
            this.lblStuID.Text = "Student Assigned:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(11, 228);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(91, 20);
            this.lblDueDate.TabIndex = 45;
            this.lblDueDate.Text = "Due Date:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dtDue);
            this.gbDetails.Controls.Add(this.txtAgendaNum);
            this.gbDetails.Controls.Add(this.lblAgendaNum);
            this.gbDetails.Controls.Add(this.lblMeetingMinutes);
            this.gbDetails.Controls.Add(this.txtMeetingMinutes);
            this.gbDetails.Controls.Add(this.txtStuID);
            this.gbDetails.Controls.Add(this.lblStuID);
            this.gbDetails.Controls.Add(this.lblDueDate);
            this.gbDetails.Controls.Add(this.lblActionDesc);
            this.gbDetails.Controls.Add(this.txtAgendaDesc);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(7, 293);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(500, 342);
            this.gbDetails.TabIndex = 66;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = " ";
            // 
            // dtDue
            // 
            this.dtDue.Location = new System.Drawing.Point(108, 228);
            this.dtDue.Margin = new System.Windows.Forms.Padding(2);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(193, 20);
            this.dtDue.TabIndex = 79;
            // 
            // txtAgendaNum
            // 
            this.txtAgendaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendaNum.Location = new System.Drawing.Point(142, 28);
            this.txtAgendaNum.Name = "txtAgendaNum";
            this.txtAgendaNum.Size = new System.Drawing.Size(121, 26);
            this.txtAgendaNum.TabIndex = 51;
            // 
            // lblAgendaNum
            // 
            this.lblAgendaNum.AutoSize = true;
            this.lblAgendaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendaNum.Location = new System.Drawing.Point(19, 31);
            this.lblAgendaNum.Name = "lblAgendaNum";
            this.lblAgendaNum.Size = new System.Drawing.Size(117, 20);
            this.lblAgendaNum.TabIndex = 50;
            this.lblAgendaNum.Text = "Agenda Num:";
            // 
            // lblMeetingMinutes
            // 
            this.lblMeetingMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingMinutes.Location = new System.Drawing.Point(11, 257);
            this.lblMeetingMinutes.Name = "lblMeetingMinutes";
            this.lblMeetingMinutes.Size = new System.Drawing.Size(91, 66);
            this.lblMeetingMinutes.TabIndex = 49;
            this.lblMeetingMinutes.Text = "Last Meeting\'s Minutes  :";
            // 
            // txtMeetingMinutes
            // 
            this.txtMeetingMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingMinutes.Location = new System.Drawing.Point(108, 257);
            this.txtMeetingMinutes.Multiline = true;
            this.txtMeetingMinutes.Name = "txtMeetingMinutes";
            this.txtMeetingMinutes.Size = new System.Drawing.Size(375, 79);
            this.txtMeetingMinutes.TabIndex = 48;
            // 
            // txtStuID
            // 
            this.txtStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuID.Location = new System.Drawing.Point(108, 181);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(121, 26);
            this.txtStuID.TabIndex = 47;
            // 
            // lblActionDesc
            // 
            this.lblActionDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionDesc.Location = new System.Drawing.Point(19, 69);
            this.lblActionDesc.Name = "lblActionDesc";
            this.lblActionDesc.Size = new System.Drawing.Size(83, 40);
            this.lblActionDesc.TabIndex = 45;
            this.lblActionDesc.Text = "Agenda Desc:";
            // 
            // txtAgendaDesc
            // 
            this.txtAgendaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendaDesc.Location = new System.Drawing.Point(108, 66);
            this.txtAgendaDesc.Multiline = true;
            this.txtAgendaDesc.Name = "txtAgendaDesc";
            this.txtAgendaDesc.Size = new System.Drawing.Size(375, 106);
            this.txtAgendaDesc.TabIndex = 45;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(526, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(342, 9);
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
            this.grdAgendatems.Location = new System.Drawing.Point(526, 48);
            this.grdAgendatems.Name = "grdAgendatems";
            this.grdAgendatems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAgendatems.Size = new System.Drawing.Size(376, 239);
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
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(526, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(526, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grdMeetings
            // 
            this.grdMeetings.AllowUserToAddRows = false;
            this.grdMeetings.AllowUserToDeleteRows = false;
            this.grdMeetings.AllowUserToResizeColumns = false;
            this.grdMeetings.AllowUserToResizeRows = false;
            this.grdMeetings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdMeetings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.grdMeetings.Location = new System.Drawing.Point(7, 48);
            this.grdMeetings.Name = "grdMeetings";
            this.grdMeetings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMeetings.Size = new System.Drawing.Size(500, 239);
            this.grdMeetings.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Meeting ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Team ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Semester";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Year";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.grdMeetings);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdAgendatems);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmAgenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendatems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblStuID;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.TextBox txtStuID;
        public System.Windows.Forms.Label lblActionDesc;
        public System.Windows.Forms.TextBox txtAgendaDesc;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView grdAgendatems;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtMeetingMinutes;
        public System.Windows.Forms.Label lblMeetingMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgendaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        public System.Windows.Forms.DataGridView grdMeetings;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.TextBox txtAgendaNum;
        public System.Windows.Forms.Label lblAgendaNum;
        private System.Windows.Forms.DateTimePicker dtDue;
    }
}