using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace FrontEndV0._1
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            OracleConnection connection = frmDBLogin.oraConn;

            OracleCommand cmd = new OracleCommand("UC1_9_Register_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = txtStuID.Text;

            string firstname = txtStuName.Text.Substring(0, txtStuName.Text.IndexOf(" "));
            string surname = txtStuName.Text.Substring(txtStuName.Text.IndexOf(" ") + 1);

            cmd.Parameters.Add("PARAM2", OracleDbType.Varchar2).Value = firstname;
            cmd.Parameters.Add("PARAM3", OracleDbType.Varchar2).Value = surname;
            cmd.Parameters.Add("PARAM4", OracleDbType.Varchar2).Value = txtStuEmail.Text;
            cmd.Parameters.Add("PARAM5", OracleDbType.Varchar2).Value =txtStuPhone.Text;
            cmd.Parameters.Add("PARAM6", OracleDbType.Varchar2).Value = txtStuPass.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            connection.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
