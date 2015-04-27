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
    public partial class frmEnrolments2 : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet unitoffs;
        private DataSet enrolments;
        private DataSet students;

        public frmEnrolments2()
        {
            InitializeComponent();

            connection = conn.oraConn();
        }

        private void frmUnitOfferings_Load(object sender, EventArgs e)
        {
            //Fetch data
            getUnitOfferings();
            getEnrolments();
            getStudents();

            //prepare and display data
            grdUnitOfferings.ClearSelection();
            populateUnitOfferingsGrid();
            populateEnrolmentsGrid();
            populateStuIDs();
        }

        private void getStudents()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_3_View_Employee", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("stucursor", OracleDbType.RefCursor);
            cmd.Parameters["stucursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            students = new DataSet();

            da.Fill(students, "stucursor", (OracleRefCursor)(cmd.Parameters["stucursor"].Value));

            connection.Close();
        }

        private void getEnrolments()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_15_View_Enrolment", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("enrcursor", OracleDbType.RefCursor);
            cmd.Parameters["enrcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            enrolments = new DataSet();

            da.Fill(enrolments, "enrcursor", (OracleRefCursor)(cmd.Parameters["enrcursor"].Value));

            connection.Close();
        }

        private void getUnitOfferings()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_22_View_Unit_Offering", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitoffcursor", OracleDbType.RefCursor);
            cmd.Parameters["unitoffcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            unitoffs = new DataSet();

            da.Fill(unitoffs, "unitoffcursor", (OracleRefCursor)(cmd.Parameters["unitoffcursor"].Value));

            connection.Close();
        }

        private void populateUnitOfferingsGrid()
        {
            //Clear the grid
            grdUnitOfferings.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = unitoffs.Tables[0].Rows[i].ItemArray;
                grdUnitOfferings.Rows.Add(new object[] { items[0], items[1], items[2], items[3] });
            }
        }

        private void populateEnrolmentsGrid()
        {
            //Clear the grid
            grdEnrolments.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = enrolments.Tables["enrcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = enrolments.Tables[0].Rows[i].ItemArray;
                grdEnrolments.Rows.Add(new object[] { items[0], items[1], items[2], items[3] });
            }
        }

        private void populateStuIDs()
        {
            //Clear the grid
            cbStudent.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = students.Tables["stucursor"].Rows.Count;
            MessageBox.Show("Available Student: " + rowcnt.ToString());
            object itm;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                itm = students.Tables["stucursor"].Rows[i][0].ToString();
                cbStudent.Items.Add(itm);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnAdd.Text == "Save?")
            {
                //Command to add Unit
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC1_21_Register_Unit_Offering", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("stuid", cbStudent.SelectedItem.ToString());
                    cmd.Parameters.Add("unitid", grdEnrolments.SelectedRows[0].Cells[0].ToString());
                    cmd.Parameters.Add("semester", grdEnrolments.SelectedRows[0].Cells[1].ToString());
                    cmd.Parameters.Add("year", grdEnrolments.SelectedRows[0].Cells[2].ToString());
                    //cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
                    //cmd.Parameters.Add("semester", Convert.ToInt32(cbSemester.SelectedItem.ToString()));
                    //cmd.Parameters.Add("year", Convert.ToInt32(cbYear.SelectedItem.ToString()));
                    
                    unitoffs.Tables[0].Rows.Add(cbStudent.SelectedItem
                        , grdEnrolments.SelectedRows[0].Cells[0].ToString()
                        , grdEnrolments.SelectedRows[0].Cells[1].ToString()
                        , grdEnrolments.SelectedRows[0].Cells[2].ToString());

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Grid
                    populateUnitOfferingsGrid();

                    //Disable fields
                    cbStudent.Enabled = false;

                    //Enable other buttons
                    btnDelete.Enabled = true;

                    //Clear textboxes/fields
                    grdUnitOfferings.ClearSelection();
                    //cbUnitID.SelectedIndex = -1;
                    //cbSemester.SelectedIndex = -1;
                    //cbYear.SelectedIndex = -1;
                    

                    grdUnitOfferings.Enabled = true;
                    btnAdd.Text = "Add";
                    //Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //Enable fields
                cbStudent.Enabled = true;

                //Disable other buttons
                btnDelete.Enabled = false;

                //Change button text and deselect any unit offering from grid
                btnAdd.Text = "Save?";
                grdUnitOfferings.ClearSelection();
            }
        }


        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (cbStudent.SelectedItem.ToString().Length == 0)
                ErrorMsg += Environment.NewLine + "Please select a Student ID.";

            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Enrolment Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void grdUnitOfferings_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUnitOfferings.SelectedCells.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            int selectedrowindex = grdUnitOfferings.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedunitid = grdUnitOfferings.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            string selectedsemester = grdUnitOfferings.Rows[selectedrowindex].Cells[1].Value.ToString(); //fetch the semester in that row
            string selectedyear = grdUnitOfferings.Rows[selectedrowindex].Cells[2].Value.ToString(); //fetch the year in that row

            DialogResult response = MessageBox.Show("Delete Unit: " + selectedunitid +
                ", semester " + selectedsemester + ", " + selectedyear + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand("UC1_24_Delete_Unit_Offering", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("unitid", selectedunitid);
                cmd.Parameters.Add("semester", selectedsemester);
                cmd.Parameters.Add("year", selectedyear);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getUnitOfferings();
                populateUnitOfferingsGrid();
                MessageBox.Show("Unit Offering Deleted");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //should not be available //actually yes, but only unit offering parts can change, stuid is the same
        }

        private void frmEnrolments2_Load(object sender, EventArgs e)
        {
            //Fetch data
            getEnrolments();
            getUnitOfferings();
            getStudents();

            //prepare and display data
            grdEnrolments.ClearSelection();
            populateEnrolmentsGrid();
            populateUnitOfferingsGrid();
            populateStuIDs();
        }
    }
}
