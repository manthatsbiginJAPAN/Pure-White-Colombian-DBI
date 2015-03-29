namespace FrontEndV0._1
{
    partial class frmAddStudent
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
            this.txtStuPass = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuEmail = new System.Windows.Forms.Label();
            this.lblStuPhone = new System.Windows.Forms.Label();
            this.lblStuPass = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(82, 115);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 22);
            this.txtStuID.TabIndex = 0;
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(82, 95);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(74, 17);
            this.lblStuID.TabIndex = 1;
            this.lblStuID.Text = "Student ID";
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(400, 115);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(100, 22);
            this.txtStuPhone.TabIndex = 2;
            // 
            // txtStuPass
            // 
            this.txtStuPass.Location = new System.Drawing.Point(506, 115);
            this.txtStuPass.Name = "txtStuPass";
            this.txtStuPass.Size = new System.Drawing.Size(100, 22);
            this.txtStuPass.TabIndex = 3;
            this.txtStuPass.UseSystemPasswordChar = true;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(188, 115);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 22);
            this.txtStuName.TabIndex = 4;
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(294, 115);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(100, 22);
            this.txtStuEmail.TabIndex = 5;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(185, 95);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(45, 17);
            this.lblStuName.TabIndex = 6;
            this.lblStuName.Text = "Name";
            // 
            // lblStuEmail
            // 
            this.lblStuEmail.AutoSize = true;
            this.lblStuEmail.Location = new System.Drawing.Point(294, 92);
            this.lblStuEmail.Name = "lblStuEmail";
            this.lblStuEmail.Size = new System.Drawing.Size(42, 17);
            this.lblStuEmail.TabIndex = 7;
            this.lblStuEmail.Text = "Email";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(400, 92);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(49, 17);
            this.lblStuPhone.TabIndex = 8;
            this.lblStuPhone.Text = "Phone";
            // 
            // lblStuPass
            // 
            this.lblStuPass.AutoSize = true;
            this.lblStuPass.Location = new System.Drawing.Point(503, 92);
            this.lblStuPass.Name = "lblStuPass";
            this.lblStuPass.Size = new System.Drawing.Size(69, 17);
            this.lblStuPass.TabIndex = 9;
            this.lblStuPass.Text = "Password";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(81, 212);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 374);
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
            this.Name = "frmAddStudent";
            this.Text = "frmAddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.TextBox txtStuPass;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuEmail;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.Label lblStuPass;
        private System.Windows.Forms.Button btnAddStudent;
    }
}