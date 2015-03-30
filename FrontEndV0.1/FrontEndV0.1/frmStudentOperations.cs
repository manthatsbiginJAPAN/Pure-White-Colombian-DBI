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
    public partial class frmStudentOperations : Form
    {
        private OracleConnection connection;

        public frmStudentOperations()
        {
            InitializeComponent();

            connection = frmDBLogin.oraConn;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Set Command and Type
            OracleCommand cmd = new OracleCommand("UC1_9_Register_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Load Parameters
            cmd.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = txtStuID.Text;
            cmd.Parameters.Add("PARAM2", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(0, txtStuName.Text.IndexOf(" "));
            cmd.Parameters.Add("PARAM3", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(txtStuName.Text.IndexOf(" ") + 1);
            cmd.Parameters.Add("PARAM4", OracleDbType.Varchar2).Value = txtStuEmail.Text;
            cmd.Parameters.Add("PARAM5", OracleDbType.Varchar2).Value = txtStuPhone.Text;
            cmd.Parameters.Add("PARAM6", OracleDbType.Varchar2).Value = txtStuPass.Text;

            //Run the command
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            getStudent();
        }



        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = lstStudents.SelectedItem.ToString().Substring(7, 7);
            //Assuming stuID can only be 7 chars at this point

            OracleCommand cmd = new OracleCommand("SELECT stuid, firstname, lastname, email, contactno FROM STUDENT where stuid = " + select, connection);
            cmd.CommandType = CommandType.Text;

            connection.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            txtStuID.Text = dr.GetString(0);
            txtStuName.Text = dr.GetString(1) + " " + dr.GetString(2);
            txtStuEmail.Text = dr.GetString(3);
            txtStuPhone.Text = dr.GetString(4);

            connection.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC1_10_Update_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = txtStuID.Text;
            cmd.Parameters.Add("PARAM2", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(0, txtStuName.Text.IndexOf(" "));
            cmd.Parameters.Add("PARAM3", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(txtStuName.Text.IndexOf(" ") + 1);
            cmd.Parameters.Add("PARAM4", OracleDbType.Varchar2).Value = txtStuEmail.Text;
            cmd.Parameters.Add("PARAM5", OracleDbType.Varchar2).Value = txtStuPhone.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();
        }


        private void getStudent()
        {
            lstStudents.Items.Clear();

            OracleCommand cmd = new OracleCommand("SELECT stuid, firstname, lastname, email, contactno FROM STUDENT", connection);
            cmd.CommandType = CommandType.Text;

            connection.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lstStudents.Items.Add(
                    "StuID: " + dr.GetString(0)
                    + " Name: " + dr.GetString(1) + " " + dr.GetString(2)
                    + " Email: " + dr.GetString(3)
                    + " Phone: " + dr.GetString(4)
                    );
            }

            connection.Close();
        }
    }
}
