using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FrontEndV0._1
{
    public partial class frmStudentOperations : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        public frmStudentOperations()
        {
            InitializeComponent();

            connection = conn.oraConn();

            //Set dropdown box default to student
            cmbSelection.SelectedIndex = 0;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC1_12_Delete_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("StuID for deletion", OracleDbType.Varchar2).Value = txtStuID.Text;

            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Set Command and Type
            OracleCommand cmd = new OracleCommand("UC1_9_Register_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Load Parameters
            cmd.Parameters.Add("Student ID", OracleDbType.Varchar2).Value = txtStuID.Text;
            cmd.Parameters.Add("First Name", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(0, txtStuName.Text.IndexOf(" "));
            cmd.Parameters.Add("Surname", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(txtStuName.Text.IndexOf(" ") + 1);
            cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = txtStuEmail.Text;
            cmd.Parameters.Add("Phone number", OracleDbType.Varchar2).Value = txtStuPhone.Text;
            cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = txtStuPass.Text;
            //Functions that return a value are the last parameter to be 

            //Run the command
            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            getStudent();
            //Example of what to do
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

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC1_10_Update_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = txtStuID.Text;
            cmd.Parameters.Add("PARAM2", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(0, txtStuName.Text.IndexOf(" "));
            cmd.Parameters.Add("PARAM3", OracleDbType.Varchar2).Value = txtStuName.Text.Substring(txtStuName.Text.IndexOf(" ") + 1);
            cmd.Parameters.Add("PARAM4", OracleDbType.Varchar2).Value = txtStuEmail.Text;
            cmd.Parameters.Add("PARAM5", OracleDbType.Varchar2).Value = txtStuPhone.Text;

            //OracleDataAdapter da = new OracleDataAdapter(cmd);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

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

                //MessageBox.Show(dr.GetString(0).GetType().ToString()) ;
            }

            connection.Close();
        }

        private void cmbSelection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSelection.Text == "Student" )
            {
                grpStudentControls.Visible = true;
                grpEmployeeControls.Visible = false;
                grpUnitControls.Visible = false;

            }
            else if (cmbSelection.Text == "Employee")
            {
                grpStudentControls.Visible = false;
                grpEmployeeControls.Visible = true;
                grpUnitControls.Visible = false;
            }
            else if (cmbSelection.Text == "Unit")
            {
                grpStudentControls.Visible = false;
                grpEmployeeControls.Visible = false;
                grpUnitControls.Visible = true;
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC1_5_Register_Unit", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("Unit ID", OracleDbType.Varchar2).Value = txtUnitID.Text;
            cmd.Parameters.Add("Unit Name", OracleDbType.Varchar2).Value = txtUnitName.Text;
            cmd.Parameters.Add("Unit Desc", OracleDbType.Varchar2).Value = txtUnitDesc.Text;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void btnRegisterUnitOffering_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC1_21_Register_Unit_Offering", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("Unit ID", OracleDbType.Varchar2).Value = txtUnitID.Text;
            cmd.Parameters.Add("Unit Semester", OracleDbType.Int16).Value = txtUnitSemester.Text;
            cmd.Parameters.Add("Unit Year", OracleDbType.Int16).Value = txtUnitYear.Text;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC1_3_View_Employee", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("refcursor1", OracleDbType.RefCursor);
            cmd.Parameters[0].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();


            DataSet ds = new DataSet();
            da.Fill(ds, "refcursor1", (OracleRefCursor)(cmd.Parameters["refcursor1"].Value) );

            int cnt = ds.Tables["refcursor1"].Columns.Count;

            for (int i = cnt - 1; i >= 0; i--)
            {
                MessageBox.Show("Row Name: " + ds.Tables[0].Columns[i].ToString() + " Row Type: " + ds.Tables[0].Columns[i].DataType.ToString() );
            }
           // MessageBox.Show(ds.Tables["refcursor1"].Columns[0].ToString() );
           // MessageBox.Show(ds.Tables["refcursor1"].Columns[0].DataType.ToString() );

            connection.Close();
        }

    }
}
