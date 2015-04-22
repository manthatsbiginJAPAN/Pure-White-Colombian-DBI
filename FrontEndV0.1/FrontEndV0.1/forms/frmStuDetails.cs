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
    public partial class frmStuDetails : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet ds;

        public frmStuDetails()
        {
            InitializeComponent();

            connection = conn.oraConn();
        }

        private void frmStuDetails_Load(object sender, EventArgs e)
        {
            grdStudentInfo.ClearSelection();
            getStudents();
            populateStuGrid();
        }

        private void getStudents()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_11_View_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("stucursor", OracleDbType.RefCursor);
            cmd.Parameters["stucursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            ds = new DataSet();

            da.Fill(ds, "stucursor", (OracleRefCursor)(cmd.Parameters["stucursor"].Value));

            connection.Close();
        }

        private void populateStuGrid()
        {
            //Clear the grid
            grdStudentInfo.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = ds.Tables["stucursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = ds.Tables[0].Rows[i].ItemArray;
                grdStudentInfo.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4], items[5] });
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnAdd.Text == "Save?")
            {
                //Command to add student
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC1_9_Register_Student", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("stuid", txtStuID.Text);
                    cmd.Parameters.Add("fname", txtStuFName.Text);
                    cmd.Parameters.Add("sname", txtStuSName.Text);
                    cmd.Parameters.Add("email", txtStuEmail.Text);
                    cmd.Parameters.Add("phnum", txtStuPhone.Text);
                    cmd.Parameters.Add("pword", txtStuPass.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    ds.Tables[0].Rows.Add(txtStuID.Text
                        , txtStuFName.Text
                        , txtStuSName.Text
                        , txtStuEmail.Text
                        , txtStuPhone.Text);

                    //Repopulate Grid
                    populateStuGrid();

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtStuID.Clear();
                    txtStuFName.Clear();
                    txtStuSName.Clear();
                    txtStuPhone.Clear();
                    txtStuEmail.Clear();
                    txtStuPass.Clear();

                    grdStudentInfo.Enabled = true;
                    btnAdd.Text = "Add";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //Enable buttons
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnAdd.Text = "Save?";
                grdStudentInfo.ClearSelection();
                grdStudentInfo.Enabled = false;
            }
        }


        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (txtStuID.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid Student ID. Max 10 Characters.";
            if (txtStuFName.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid first name.";
            if (txtStuSName.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid last name ID.";
            if (txtStuPhone.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid Phone Number. Max 10 digits.";
            if (txtStuEmail.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid email address.";
            if (txtStuPass.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid password.";

            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Student Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void grdStudentInfo_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdStudentInfo.SelectedCells.Count == 0)
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
            int selectedrowindex = grdStudentInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedstuid = grdStudentInfo.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            DialogResult response = MessageBox.Show("Delete Student: " + selectedstuid + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand("UC1_12_Delete_Student", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("stuid", selectedstuid);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                
                getStudents();
                populateStuGrid();
                MessageBox.Show("Student Deleted");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnEdit.Text == "Update?")
            {
                //Command to add student
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC1_10_Update_Student", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("stuid", txtStuID.Text);
                    cmd.Parameters.Add("fname", txtStuFName.Text);
                    cmd.Parameters.Add("sname", txtStuSName.Text);
                    cmd.Parameters.Add("email", txtStuEmail.Text);
                    cmd.Parameters.Add("phnum", txtStuPhone.Text);
                    cmd.Parameters.Add("pword", txtStuPass.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Grid and notify user
                    getStudents();
                    populateStuGrid();
                    MessageBox.Show("Student Updated");

                    //Disable textboxes
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtStuID.Clear();
                    txtStuFName.Clear();
                    txtStuSName.Clear();
                    txtStuPhone.Clear();
                    txtStuEmail.Clear();
                    txtStuPass.Clear();

                    grdStudentInfo.Enabled = true;
                    btnEdit.Text = "Edit";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //loading data into textboxes: find the row, load the data from the datagridset
                int selectedrowindex = grdStudentInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
                txtStuID.Text = grdStudentInfo.Rows[selectedrowindex].Cells[0].Value.ToString();
                txtStuFName.Text = grdStudentInfo.Rows[selectedrowindex].Cells[1].Value.ToString();
                txtStuSName.Text = grdStudentInfo.Rows[selectedrowindex].Cells[2].Value.ToString();
                txtStuEmail.Text = grdStudentInfo.Rows[selectedrowindex].Cells[3].Value.ToString();
                txtStuPhone.Text = grdStudentInfo.Rows[selectedrowindex].Cells[4].Value.ToString();
                txtStuPass.Text = grdStudentInfo.Rows[selectedrowindex].Cells[5].Value.ToString();

                //Enable textboxes
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                gbIdentifyingInformation.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnEdit.Text = "Update?";
                grdStudentInfo.ClearSelection();
                grdStudentInfo.Enabled = false;
            }
        }
    }
}
