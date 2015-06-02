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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAgendaNum = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAgendaNum = new System.Windows.Forms.Label();
            this.txtAgendaDesc = new System.Windows.Forms.TextBox();
            this.lblActionDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdAgendaItems = new System.Windows.Forms.DataGridView();
            this.colAgendaNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgendaDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendaItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.btnAdd);
            this.gbDetails.Controls.Add(this.txtAgendaNum);
            this.gbDetails.Controls.Add(this.btnDelete);
            this.gbDetails.Controls.Add(this.btnEdit);
            this.gbDetails.Controls.Add(this.lblAgendaNum);
            this.gbDetails.Controls.Add(this.txtAgendaDesc);
            this.gbDetails.Controls.Add(this.lblActionDesc);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(12, 47);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(500, 290);
            this.gbDetails.TabIndex = 66;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = " ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(369, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 37);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAgendaNum
            // 
            this.txtAgendaNum.Enabled = false;
            this.txtAgendaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendaNum.Location = new System.Drawing.Point(135, 30);
            this.txtAgendaNum.Name = "txtAgendaNum";
            this.txtAgendaNum.Size = new System.Drawing.Size(121, 26);
            this.txtAgendaNum.TabIndex = 51;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(369, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 37);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(369, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 37);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblAgendaNum
            // 
            this.lblAgendaNum.AutoSize = true;
            this.lblAgendaNum.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendaNum.Location = new System.Drawing.Point(5, 30);
            this.lblAgendaNum.Name = "lblAgendaNum";
            this.lblAgendaNum.Size = new System.Drawing.Size(124, 21);
            this.lblAgendaNum.TabIndex = 50;
            this.lblAgendaNum.Text = "Agenda Num:";
            // 
            // txtAgendaDesc
            // 
            this.txtAgendaDesc.Enabled = false;
            this.txtAgendaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendaDesc.Location = new System.Drawing.Point(135, 164);
            this.txtAgendaDesc.Multiline = true;
            this.txtAgendaDesc.Name = "txtAgendaDesc";
            this.txtAgendaDesc.Size = new System.Drawing.Size(351, 106);
            this.txtAgendaDesc.TabIndex = 45;
            // 
            // lblActionDesc
            // 
            this.lblActionDesc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionDesc.Location = new System.Drawing.Point(0, 166);
            this.lblActionDesc.Name = "lblActionDesc";
            this.lblActionDesc.Size = new System.Drawing.Size(129, 68);
            this.lblActionDesc.TabIndex = 45;
            this.lblActionDesc.Text = "Agenda Description:";
            this.lblActionDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(364, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 34);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Agenda Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdAgendaItems
            // 
            this.grdAgendaItems.AllowUserToAddRows = false;
            this.grdAgendaItems.AllowUserToDeleteRows = false;
            this.grdAgendaItems.AllowUserToResizeColumns = false;
            this.grdAgendaItems.AllowUserToResizeRows = false;
            this.grdAgendaItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAgendaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAgendaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAgendaNum,
            this.colAgendaDesc});
            this.grdAgendaItems.Location = new System.Drawing.Point(526, 49);
            this.grdAgendaItems.Name = "grdAgendaItems";
            this.grdAgendaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAgendaItems.Size = new System.Drawing.Size(376, 280);
            this.grdAgendaItems.TabIndex = 68;
            // 
            // colAgendaNum
            // 
            this.colAgendaNum.FillWeight = 60.9137F;
            this.colAgendaNum.HeaderText = "Agenda Number";
            this.colAgendaNum.Name = "colAgendaNum";
            // 
            // colAgendaDesc
            // 
            this.colAgendaDesc.FillWeight = 139.0863F;
            this.colAgendaDesc.HeaderText = "Agenda Desc";
            this.colAgendaDesc.Name = "colAgendaDesc";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 367);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdAgendaItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendaItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.Label lblActionDesc;
        public System.Windows.Forms.TextBox txtAgendaDesc;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView grdAgendaItems;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtAgendaNum;
        public System.Windows.Forms.Label lblAgendaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgendaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgendaDesc;
    }
}