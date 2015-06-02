namespace FrontEndV0._1.forms
{
    partial class frmStuDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStuDetails));
            this.label7 = new System.Windows.Forms.Label();
            this.txtStuSName = new System.Windows.Forms.TextBox();
            this.grdStudentInfo = new System.Windows.Forms.DataGridView();
            this.Stuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStuPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStuFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentInfo)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.gbIdentifyingInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone:";
            // 
            // txtStuSName
            // 
            this.txtStuSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuSName.Location = new System.Drawing.Point(350, 46);
            this.txtStuSName.Name = "txtStuSName";
            this.txtStuSName.Size = new System.Drawing.Size(100, 26);
            this.txtStuSName.TabIndex = 5;
            // 
            // grdStudentInfo
            // 
            this.grdStudentInfo.AllowUserToAddRows = false;
            this.grdStudentInfo.AllowUserToDeleteRows = false;
            this.grdStudentInfo.AllowUserToResizeColumns = false;
            this.grdStudentInfo.AllowUserToResizeRows = false;
            this.grdStudentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stuid,
            this.fname,
            this.sname,
            this.stuEmail,
            this.stuPhone,
            this.stuPassword});
            this.grdStudentInfo.Location = new System.Drawing.Point(486, 65);
            this.grdStudentInfo.MultiSelect = false;
            this.grdStudentInfo.Name = "grdStudentInfo";
            this.grdStudentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudentInfo.Size = new System.Drawing.Size(421, 569);
            this.grdStudentInfo.TabIndex = 19;
            this.grdStudentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudentInfo_SelectionChanged);
            // 
            // Stuid
            // 
            this.Stuid.HeaderText = "Student ID";
            this.Stuid.Name = "Stuid";
            this.Stuid.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // sname
            // 
            this.sname.HeaderText = "Surname";
            this.sname.Name = "sname";
            // 
            // stuEmail
            // 
            this.stuEmail.HeaderText = "Email";
            this.stuEmail.Name = "stuEmail";
            this.stuEmail.Visible = false;
            // 
            // stuPhone
            // 
            this.stuPhone.HeaderText = "Phone No.";
            this.stuPhone.Name = "stuPhone";
            this.stuPhone.Visible = false;
            // 
            // stuPassword
            // 
            this.stuPassword.HeaderText = "Password";
            this.stuPassword.Name = "stuPassword";
            this.stuPassword.Visible = false;
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuPhone.Location = new System.Drawing.Point(350, 132);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(100, 26);
            this.txtStuPhone.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtStuPhone);
            this.gbDetails.Controls.Add(this.label7);
            this.gbDetails.Controls.Add(this.txtStuSName);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.txtStuPass);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.txtStuEmail);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.txtStuFName);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Enabled = false;
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(7, 357);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(472, 277);
            this.gbDetails.TabIndex = 17;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Surname:";
            // 
            // txtStuPass
            // 
            this.txtStuPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuPass.Location = new System.Drawing.Point(114, 223);
            this.txtStuPass.Name = "txtStuPass";
            this.txtStuPass.Size = new System.Drawing.Size(100, 26);
            this.txtStuPass.TabIndex = 8;
            this.txtStuPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuEmail.Location = new System.Drawing.Point(114, 132);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(100, 26);
            this.txtStuEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // txtStuFName
            // 
            this.txtStuFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuFName.Location = new System.Drawing.Point(116, 46);
            this.txtStuFName.Name = "txtStuFName";
            this.txtStuFName.Size = new System.Drawing.Size(100, 26);
            this.txtStuFName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.txtStuID);
            this.gbIdentifyingInformation.Controls.Add(this.label2);
            this.gbIdentifyingInformation.Enabled = false;
            this.gbIdentifyingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(8, 57);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(325, 282);
            this.gbIdentifyingInformation.TabIndex = 15;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // txtStuID
            // 
            this.txtStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuID.Location = new System.Drawing.Point(132, 23);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 26);
            this.txtStuID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student Details";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(342, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 37);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmStuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 646);
            this.Controls.Add(this.grdStudentInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStuDetails";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmStuDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentInfo)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtStuSName;
        public System.Windows.Forms.DataGridView grdStudentInfo;
        public System.Windows.Forms.TextBox txtStuPhone;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtStuPass;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtStuEmail;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtStuFName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.TextBox txtStuID;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuPassword;
    }
}