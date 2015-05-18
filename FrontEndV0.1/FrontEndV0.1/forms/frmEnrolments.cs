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
    public partial class frmEnrolments : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet unitoffs;
        private DataSet students;
        private DataSet enrolments;
        private string User;
        private bool isAdmin;

        public frmEnrolments(string user, bool isAdministrator)
        {
            InitializeComponent();
            connection = conn.oraConn();
            User = user;
            isAdmin = isAdministrator;
        }

        private void frmEnrolments_Load(object sender, EventArgs e)
        {
            //Fetch data
            getEnrolments();
            getUnitOfferings();
            getStudents();

            //prepare and display data
            grdEnrolments.ClearSelection();
            populateEnrolmentsGrid();
            populateUnitOfferings();
            populateStuIDs();

            if (!isAdmin)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                gbDetails.Enabled = false;
                gbIdentifyingInformation.Enabled = false;
            }
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

            students = new DataSet();

            da.Fill(students, "stucursor", (OracleRefCursor)(cmd.Parameters["stucursor"].Value));

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

        private void populateUnitOfferings()
        {
            //Clear the grid
            cbUnitID.Items.Clear();
            cbSemester.Items.Clear();
            cbYear.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object unitid = new object();
            object sem = new object();
            object year = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                unitid = unitoffs.Tables["unitoffcursor"].Rows[i][0].ToString();
                sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();
                year = unitoffs.Tables["unitoffcursor"].Rows[i][2].ToString();

                //add the available unitID to the combo box
                if (!cbUnitID.Items.Contains(unitid.ToString()))
                    cbUnitID.Items.Add(unitid.ToString());
                
                //cbUnitID.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][0].ToString());
                //cbSemester.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][1].ToString());
                //cbYear.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][2]);
            }
        }


        private void populateStuIDs()
        {
            //Clear the grid
            cbStudent.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = students.Tables["stucursor"].Rows.Count;
            object itm;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                itm = students.Tables["stucursor"].Rows[i][0].ToString();
                cbStudent.Items.Add(itm);
            }
        }

        private void populateEnrolmentsGrid()
        {
            //Clear the grid
            grdEnrolments.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = enrolments.Tables[0].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //if user is an admin then load each enrolment to view, add to and edit
                if (isAdmin)
                {
                    object[] items = enrolments.Tables[0].Rows[i].ItemArray;
                    grdEnrolments.Rows.Add(new object[] { items[0], items[1], items[2], items[3]});
                }
                else //otherwise if they are not an admin, they're a student and should only load their own details to view
                {
                    if (enrolments.Tables[0].Rows[i][0].ToString().ToLower() == User.ToLower())
                    {
                        object[] items = enrolments.Tables[0].Rows[i].ItemArray;
                        grdEnrolments.Rows.Add(new object[] { items[0], items[1], items[2], items[3]});
                    }
                }
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
                    OracleCommand cmd = new OracleCommand("UC1_13_Register_Enrolment", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("stuid", cbStudent.SelectedItem.ToString());
                    cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
                    cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem.ToString()));
                    cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem.ToString()));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //unitoffs.Tables[0].Rows.Add(cbStudent.SelectedItem
                    //    , cbUnitID.SelectedItem
                    //    , cbSemester.SelectedItem
                    //    , cbYear.SelectedItem);

                    //Repopulate Dataset then Grid
                    getEnrolments();
                    populateEnrolmentsGrid();

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;

                    //Enable other buttons
                    btnDelete.Enabled = true;

                    //Clear textboxes/fields
                    cbUnitID.SelectedIndex = -1;
                    cbSemester.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;

                    grdEnrolments.Enabled = true;
                    btnAdd.Text = "Add";
                }
            }
            else
            {
                //Enable group boxes
                gbIdentifyingInformation.Enabled = true;

                //Disable other buttons
                btnDelete.Enabled = false;

                //Change button text and deselect any unit offering from grid
                btnAdd.Text = "Save?";
                grdEnrolments.ClearSelection();
            }
        }


        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (cbStudent.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Student ID.";
            if (cbUnitID.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Unit ID.";
            if (cbSemester.SelectedIndex == -1)
                ErrorMsg += Environment.NewLine + "Please select a Semester.";
            if (cbYear.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Year.";

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
            if (grdEnrolments.SelectedCells.Count == 0)
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
            int selectedrowindex = grdEnrolments.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedstuid = grdEnrolments.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            string selectedunitid = grdEnrolments.Rows[selectedrowindex].Cells[1].Value.ToString(); //fetch the ID in that row
            string selectedsemester = grdEnrolments.Rows[selectedrowindex].Cells[2].Value.ToString(); //fetch the semester in that row
            string selectedyear = grdEnrolments.Rows[selectedrowindex].Cells[3].Value.ToString(); //fetch the year in that row

            DialogResult response = MessageBox.Show("Delete Enrolment of : " + selectedstuid +
                    " for unit" + selectedunitid + 
                    ", semester " + selectedsemester +
                    ", " + selectedyear + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (response == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand("UC1_16_Delete_Enrolment", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("stuid", selectedstuid);
                cmd.Parameters.Add("unitid", selectedunitid);
                cmd.Parameters.Add("semester", selectedsemester);
                cmd.Parameters.Add("year", selectedyear);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getUnitOfferings();
                populateEnrolmentsGrid();
                MessageBox.Show("Enrolment Deleted");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //should not be available
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedIndex != -1)
                cbUnitID.Enabled = true;
        }

        private void cbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fixes it crashing when you actually add an enrolment
            if (cbUnitID.SelectedItem == null)
                return;

            if (cbUnitID.SelectedIndex != -1)
                cbSemester.Enabled = true;

            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object sem = new object();
            cbSemester.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {

                //find the semesters where the unitID matches the selected one
                if (unitoffs.Tables[0].Rows[i][0].ToString() == cbUnitID.SelectedItem.ToString())
                {
                    sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();

                    //only note one option for semesters once per instance
                    if (!cbSemester.Items.Contains(sem))
                        cbSemester.Items.Add(sem);

                    //sort the list numerically/alphabetically
                    cbSemester.Sorted = true;
                }
            }
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fixes it crashing when you actually add an enrolment
            if (cbUnitID.SelectedItem == null)
                return;

            if (cbSemester.SelectedIndex != -1)
                cbYear.Enabled = true;

            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object year = new object();
            cbYear.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
                if (unitoffs.Tables[0].Rows[i][0].ToString() == cbUnitID.SelectedItem.ToString() && unitoffs.Tables[0].Rows[i][1].ToString() == cbSemester.SelectedItem.ToString())
                {
                    year = unitoffs.Tables["unitoffcursor"].Rows[i][2].ToString();

                    //only note one option for semesters once per instance
                    if (!cbYear.Items.Contains(year))
                        cbYear.Items.Add(year);

                    //sort the list numerically/alphabetically
                    cbYear.Sorted = true;
                }
            }
        }
    }
}
