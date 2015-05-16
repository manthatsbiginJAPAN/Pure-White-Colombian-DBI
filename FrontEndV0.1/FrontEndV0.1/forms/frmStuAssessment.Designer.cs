namespace FrontEndV0._1.forms
{
    partial class frmStuAssessment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.TaskDesc,
            this.DueDate,
            this.P1,
            this.P2,
            this.P3});
            this.dataGridView1.Location = new System.Drawing.Point(287, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(91, 132);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 24);
            this.cbUnit.TabIndex = 1;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(91, 93);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(33, 17);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Unit";
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "TaskId";
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            // 
            // TaskDesc
            // 
            this.TaskDesc.HeaderText = "Task Description";
            this.TaskDesc.Name = "TaskDesc";
            this.TaskDesc.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // P1
            // 
            this.P1.HeaderText = "Period One";
            this.P1.Name = "P1";
            // 
            // P2
            // 
            this.P2.HeaderText = "Period Two";
            this.P2.Name = "P2";
            // 
            // P3
            // 
            this.P3.HeaderText = "Period Three";
            this.P3.Name = "P3";
            // 
            // frmStuAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 453);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStuAssessment";
            this.Text = "frmStuAssessment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn P1;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3;
    }
}