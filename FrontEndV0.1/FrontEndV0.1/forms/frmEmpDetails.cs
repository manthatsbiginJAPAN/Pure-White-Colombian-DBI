using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FrontEndV0._1.forms
{
    public partial class frmEmpDetails : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet ds;

        public frmEmpDetails()
        {
            InitializeComponent();

            connection = conn.oraConn();
        }

        private void frmEmpDetails_Load(object sender, EventArgs e)
        {
            getEmployees();
            populateEmpGrid();
        }

        private void getEmployees()
        {

            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_3_View_Employee", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("empcursor", OracleDbType.RefCursor);
            cmd.Parameters["empcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            ds = new DataSet();

            da.Fill(ds, "empcursor", (OracleRefCursor)(cmd.Parameters["empcursor"].Value));

            connection.Close();
        }

        private void populateEmpGrid()
        {
            //Clear the grid
            grdEmployeeInfo.Rows.Clear();
          
            //Populate the grid from the dataset

            int rowcnt = ds.Tables["empcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = ds.Tables[0].Rows[i].ItemArray;
                grdEmployeeInfo.Rows.Add(new object[] { items[0], items[1], items[2] });
            } 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnAdd.Text == "Save")
            {
                //Command to add employee
                OracleCommand cmd = new OracleCommand("UC1_1_REGISTER_EMPLOYEE", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("empid", txtEmpID.Text);
                cmd.Parameters.Add("fname", txtEmpFName.Text);
                cmd.Parameters.Add("sname", txtEmpSName.Text);
                cmd.Parameters.Add("email", txtEmpEmail.Text);
                cmd.Parameters.Add("phnum", txtEmpPhone.Text);
                cmd.Parameters.Add("pword", txtEmpPass.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                ds.Tables[0].Rows.Add(txtEmpID.Text
                    , txtEmpFName.Text
                    , txtEmpSName.Text
                    , txtEmpEmail.Text
                    , txtEmpPhone.Text);

                //Repopulate Grid
                populateEmpGrid();

                //Disable buttons
                txtEmpID.Enabled = false;
                txtEmpFName.Enabled = false;
                txtEmpSName.Enabled = false;
                txtEmpEmail.Enabled = false;
                txtEmpPhone.Enabled = false;
                txtEmpPass.Enabled = false;

                btnAdd.Text = ">> Add >>";
                Console.WriteLine(btnAdd.Text);
            }
            else
            {
                //Enable buttons
                txtEmpID.Enabled = true;
                txtEmpFName.Enabled = true;
                txtEmpSName.Enabled = true;
                txtEmpEmail.Enabled = true;
                txtEmpPhone.Enabled = true;
                txtEmpPass.Enabled = true;

                btnAdd.Text = "Save";
                grdEmployeeInfo.ClearSelection();
            }
        }


    }
}
