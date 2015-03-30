namespace FrontEndV0._1
{
    partial class frmStudentOperations
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
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.lblStuID = new System.Windows.Forms.Label();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuEmail = new System.Windows.Forms.Label();
            this.lblStuPhone = new System.Windows.Forms.Label();
            this.lblStuPass = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnListStudents = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStuPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(12, 29);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 22);
            this.txtStuID.TabIndex = 0;
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(12, 9);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(74, 17);
            this.lblStuID.TabIndex = 1;
            this.lblStuID.Text = "Student ID";
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(118, 29);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(100, 22);
            this.txtStuPhone.TabIndex = 3;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(15, 74);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 22);
            this.txtStuName.TabIndex = 1;
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(15, 122);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(100, 22);
            this.txtStuEmail.TabIndex = 2;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(12, 54);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(45, 17);
            this.lblStuName.TabIndex = 6;
            this.lblStuName.Text = "Name";
            // 
            // lblStuEmail
            // 
            this.lblStuEmail.AutoSize = true;
            this.lblStuEmail.Location = new System.Drawing.Point(15, 99);
            this.lblStuEmail.Name = "lblStuEmail";
            this.lblStuEmail.Size = new System.Drawing.Size(42, 17);
            this.lblStuEmail.TabIndex = 7;
            this.lblStuEmail.Text = "Email";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(119, 9);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(49, 17);
            this.lblStuPhone.TabIndex = 8;
            this.lblStuPhone.Text = "Phone";
            // 
            // lblStuPass
            // 
            this.lblStuPass.AutoSize = true;
            this.lblStuPass.Location = new System.Drawing.Point(119, 54);
            this.lblStuPass.Name = "lblStuPass";
            this.lblStuPass.Size = new System.Drawing.Size(69, 17);
            this.lblStuPass.TabIndex = 9;
            this.lblStuPass.Text = "Password";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(124, 121);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 16;
            this.lstStudents.Location = new System.Drawing.Point(269, 29);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(429, 228);
            this.lstStudents.TabIndex = 11;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // btnListStudents
            // 
            this.btnListStudents.Location = new System.Drawing.Point(269, 272);
            this.btnListStudents.Name = "btnListStudents";
            this.btnListStudents.Size = new System.Drawing.Size(149, 23);
            this.btnListStudents.TabIndex = 12;
            this.btnListStudents.Text = "Retrieve Students";
            this.btnListStudents.UseVisualStyleBackColor = true;
            this.btnListStudents.Click += new System.EventHandler(this.btnListStudents_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStuPass
            // 
            this.txtStuPass.Location = new System.Drawing.Point(124, 74);
            this.txtStuPass.Name = "txtStuPass";
            this.txtStuPass.Size = new System.Drawing.Size(100, 22);
            this.txtStuPass.TabIndex = 16;
            this.txtStuPass.UseSystemPasswordChar = true;
            // 
            // frmStudentOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 350);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnListStudents);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblStuPass);
            this.Controls.Add(this.lblStuPhone);
            this.Controls.Add(this.lblStuEmail);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.txtStuEmail);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuPass);
            this.Controls.Add(this.txtStuPhone);
            this.Controls.Add(this.lblStuID);
            this.Controls.Add(this.txtStuID);
            this.Name = "frmStudentOperations";
            this.Text = "Student Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuEmail;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.Label lblStuPass;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnListStudents;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStuPass;
    }
}