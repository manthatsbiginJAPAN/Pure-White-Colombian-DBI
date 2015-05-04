namespace FrontEndV0._1.forms
{
    partial class frmEmpDetails
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIdentifyingInformation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpSName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbEmpRoles = new System.Windows.Forms.CheckedListBox();
            this.gbIdentifyingInformation.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(463, 91);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Details";
            // 
            // gbIdentifyingInformation
            // 
            this.gbIdentifyingInformation.Controls.Add(this.clbEmpRoles);
            this.gbIdentifyingInformation.Controls.Add(this.label8);
            this.gbIdentifyingInformation.Controls.Add(this.txtEmpID);
            this.gbIdentifyingInformation.Controls.Add(this.label2);
            this.gbIdentifyingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifyingInformation.Location = new System.Drawing.Point(17, 81);
            this.gbIdentifyingInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIdentifyingInformation.Name = "gbIdentifyingInformation";
            this.gbIdentifyingInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIdentifyingInformation.Size = new System.Drawing.Size(433, 347);
            this.gbIdentifyingInformation.TabIndex = 9;
            this.gbIdentifyingInformation.TabStop = false;
            this.gbIdentifyingInformation.Text = "Identifying Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Role(s):";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(176, 28);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(132, 30);
            this.txtEmpID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(463, 146);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 46);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(463, 199);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 46);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtEmpPhone);
            this.gbDetails.Controls.Add(this.label7);
            this.gbDetails.Controls.Add(this.txtEmpSName);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.txtEmpPass);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.txtEmpEmail);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.txtEmpFName);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(16, 450);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetails.Size = new System.Drawing.Size(629, 341);
            this.gbDetails.TabIndex = 10;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.Location = new System.Drawing.Point(467, 162);
            this.txtEmpPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(132, 30);
            this.txtEmpPhone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone:";
            // 
            // txtEmpSName
            // 
            this.txtEmpSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSName.Location = new System.Drawing.Point(467, 57);
            this.txtEmpSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpSName.Name = "txtEmpSName";
            this.txtEmpSName.Size = new System.Drawing.Size(132, 30);
            this.txtEmpSName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Surname:";
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPass.Location = new System.Drawing.Point(152, 274);
            this.txtEmpPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.Size = new System.Drawing.Size(132, 30);
            this.txtEmpPass.TabIndex = 8;
            this.txtEmpPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpEmail.Location = new System.Drawing.Point(152, 162);
            this.txtEmpEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(132, 30);
            this.txtEmpEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // txtEmpFName
            // 
            this.txtEmpFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpFName.Location = new System.Drawing.Point(155, 57);
            this.txtEmpFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpFName.Name = "txtEmpFName";
            this.txtEmpFName.Size = new System.Drawing.Size(132, 30);
            this.txtEmpFName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // grdEmployeeInfo
            // 
            this.grdEmployeeInfo.AllowUserToAddRows = false;
            this.grdEmployeeInfo.AllowUserToDeleteRows = false;
            this.grdEmployeeInfo.AllowUserToResizeColumns = false;
            this.grdEmployeeInfo.AllowUserToResizeRows = false;
            this.grdEmployeeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empid,
            this.empfname,
            this.empsname,
            this.empEmail,
            this.empPhone,
            this.empPassword});
            this.grdEmployeeInfo.Location = new System.Drawing.Point(655, 91);
            this.grdEmployeeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdEmployeeInfo.Name = "grdEmployeeInfo";
            this.grdEmployeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployeeInfo.Size = new System.Drawing.Size(561, 700);
            this.grdEmployeeInfo.TabIndex = 12;
            // 
            // empid
            // 
            this.empid.HeaderText = "Employee ID";
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            // 
            // empfname
            // 
            this.empfname.HeaderText = "First Name";
            this.empfname.Name = "empfname";
            this.empfname.ReadOnly = true;
            // 
            // empsname
            // 
            this.empsname.HeaderText = "Surname";
            this.empsname.Name = "empsname";
            // 
            // empEmail
            // 
            this.empEmail.HeaderText = "Email";
            this.empEmail.Name = "empEmail";
            this.empEmail.Visible = false;
            // 
            // empPhone
            // 
            this.empPhone.HeaderText = "Phone";
            this.empPhone.Name = "empPhone";
            this.empPhone.Visible = false;
            // 
            // empPassword
            // 
            this.empPassword.HeaderText = "Password";
            this.empPassword.Name = "empPassword";
            this.empPassword.Visible = false;
            // 
            // clbEmpRoles
            // 
            this.clbEmpRoles.FormattingEnabled = true;
            this.clbEmpRoles.Items.AddRange(new object[] {
            "Administrator",
            "Convenor",
            "Supervisor"});
            this.clbEmpRoles.Location = new System.Drawing.Point(176, 118);
            this.clbEmpRoles.Name = "clbEmpRoles";
            this.clbEmpRoles.Size = new System.Drawing.Size(132, 58);
            this.clbEmpRoles.TabIndex = 7;
            // 
            // frmEmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 807);
            this.Controls.Add(this.grdEmployeeInfo);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbIdentifyingInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(398, 360);
            this.Name = "frmEmpDetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmEmpDetails_Load);
            this.gbIdentifyingInformation.ResumeLayout(false);
            this.gbIdentifyingInformation.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbIdentifyingInformation;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.TextBox txtEmpID;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEmpPhone;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtEmpSName;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEmpPass;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmpEmail;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtEmpFName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView grdEmployeeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empsname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPassword;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbEmpRoles;


    }
}