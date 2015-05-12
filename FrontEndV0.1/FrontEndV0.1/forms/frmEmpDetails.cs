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
        //private DataSet emproles; //to be used for storing emp roles when we implement it...

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
                grdEmployeeInfo.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4], items[5] });
            } 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnAdd.Text == "Save?")
            {
                //Command to add employee
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC1_1_REGISTER_EMPLOYEE", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 100;

                    string empid = txtEmpID.Text;
                    cmd.Parameters.Add("empid", empid);
                    cmd.Parameters.Add("fname", txtEmpFName.Text);
                    cmd.Parameters.Add("sname", txtEmpSName.Text);
                    cmd.Parameters.Add("email", txtEmpEmail.Text);
                    cmd.Parameters.Add("phnum", txtEmpPhone.Text);
                    cmd.Parameters.Add("pword", txtEmpPass.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    for (int i = 0; i < clbEmpRoles.Items.Count; i++)
                    {
                        cmd = new OracleCommand("UC1_25_REGISTER_EMPLOYEE_ROLE", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("empid", empid);

                        //Work out which employee type to add
                        if (clbEmpRoles.GetItemChecked(i))
                        {
                            switch (i)
                            {
                                case 0:
                                    cmd.Parameters.Add("role", "Admin");
                                    connection.Open();
                                    cmd.ExecuteNonQuery();
                                    connection.Close();
                                    break;
                                case 1:
                                    cmd.Parameters.Add("role", "Convenor");
                                    connection.Open();
                                    cmd.ExecuteNonQuery();
                                    connection.Close();
                                    break;
                                case 2:
                                    cmd.Parameters.Add("role", "Supervisor");
                                    connection.Open();
                                    cmd.ExecuteNonQuery();
                                    connection.Close();
                                    break;
                            }
                        }
                    }



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

                    //Enable other buttons
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtEmpID.Clear();
                    txtEmpFName.Clear();
                    txtEmpSName.Clear();
                    txtEmpPhone.Clear();
                    txtEmpEmail.Clear();
                    txtEmpPass.Clear();

                    btnAdd.Text = "Add";
                }
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

                //Disable other buttons
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnAdd.Text = "Save?";
                grdEmployeeInfo.ClearSelection();
            }
            }
        
            


        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (txtEmpID.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid Employee ID. Max 10 Characters.";
            if (txtEmpFName.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid first name.";
            if (txtEmpSName.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid last name ID.";
            if (txtEmpPhone.Text.Length == 0)
               ErrorMsg += Environment.NewLine + "Please enter a valid Phone Number. Max 10 digits.";
            if (txtEmpEmail.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid email address.";
            if (txtEmpPass.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid password.";
                
            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Employee Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void grdEmployeeInfo_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdEmployeeInfo.SelectedCells.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = grdEmployeeInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedempid = grdEmployeeInfo.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            DialogResult response = MessageBox.Show("Delete Employee: " + selectedempid + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                foreach (object role in clbEmpRoles.Items)
                {
                    OracleCommand cmd1 = new OracleCommand("UC1_28_Delete_Employee_Role", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("empid", selectedempid);
                    cmd1.Parameters.Add("role", role.ToString());

                    connection.Open();
                    cmd1.ExecuteNonQuery();
                    connection.Close();
                }

                OracleCommand cmd = new OracleCommand("UC1_4_Delete_Employee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("empid", selectedempid);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getEmployees();
                populateEmpGrid();
                MessageBox.Show("Employee Deleted");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnEdit.Text == "Update?")
            {
                //Command to add Employee
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC1_2_Update_Employee", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("Empid", txtEmpID.Text);
                    cmd.Parameters.Add("fname", txtEmpFName.Text);
                    cmd.Parameters.Add("sname", txtEmpSName.Text);
                    cmd.Parameters.Add("email", txtEmpEmail.Text);
                    cmd.Parameters.Add("phnum", txtEmpPhone.Text);
                    cmd.Parameters.Add("pword", txtEmpPass.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Grid and notify user
                    getEmployees();
                    populateEmpGrid();
                    MessageBox.Show("Employee Updated");

                    //Disable textboxes
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtEmpID.Clear();
                    txtEmpFName.Clear();
                    txtEmpSName.Clear();
                    txtEmpPhone.Clear();
                    txtEmpEmail.Clear();
                    txtEmpPass.Clear();

                    grdEmployeeInfo.Enabled = true;
                    btnEdit.Text = "Edit";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //loading data into textboxes: find the row, load the data from the datagridset
                int selectedrowindex = grdEmployeeInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
                txtEmpID.Text = grdEmployeeInfo.Rows[selectedrowindex].Cells[0].Value.ToString();
                txtEmpFName.Text = grdEmployeeInfo.Rows[selectedrowindex].Cells[1].Value.ToString();
                txtEmpSName.Text = grdEmployeeInfo.Rows[selectedrowindex].Cells[2].Value.ToString();
                txtEmpEmail.Text = grdEmployeeInfo.Rows[selectedrowindex].Cells[3].Value.ToString();
                txtEmpPhone.Text = grdEmployeeInfo.Rows[selectedrowindex].Cells[4].Value.ToString();
                txtEmpPass.Text = grdEmployeeInfo.Rows[selectedrowindex].Cells[5].Value.ToString();

                //Enable textboxes
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                gbIdentifyingInformation.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnEdit.Text = "Update?";
                grdEmployeeInfo.ClearSelection();
                grdEmployeeInfo.Enabled = false;
            }
        }
    }
}

