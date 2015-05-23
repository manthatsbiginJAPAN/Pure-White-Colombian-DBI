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
    public partial class frmProject : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet unitoffs;
        private DataSet projects;
        private string User;
        private bool isConvenor;
        private bool isSupervisor;

        public frmProject(string user, bool isconvenor, bool issupervisor)
        {
            InitializeComponent();
            User = user;
            isConvenor = isconvenor;
            isSupervisor = issupervisor;
            connection = conn.oraConn();
        }


        private void frmProject_Load(object sender, EventArgs e)
        {
            getProjects();
            getUnitOfferings();

            populateProjects();
            populateUnitOfferings();

            if (!isConvenor)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                gbDetails.Enabled = false;
                gbIdentifyingInformation.Enabled = false;
            }
        }

        private void getProjects()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_7_View_Project", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("projcursor", OracleDbType.RefCursor);
            cmd.Parameters["projcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("user", User);
            string role = null;
            if (isSupervisor)
                role = "supervisor";
            if (isConvenor)
                role = "convenor";
            if (role == null)
                role = "student";
            cmd.Parameters.Add("role", role);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            projects = new DataSet();

            da.Fill(projects, "projcursor", (OracleRefCursor)(cmd.Parameters["projcursor"].Value));

            connection.Close();
        }

        private void getUnitOfferings()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_22_View_Unit_Offering", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitoffcursor", OracleDbType.RefCursor);
            cmd.Parameters["unitoffcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("user", User);
            string role = null;
            if (isSupervisor)
                role = "supervisor";
            if (isConvenor)
                role = "convenor";
            if (role == null)
                role = "student";
            cmd.Parameters.Add("role", role);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            unitoffs = new DataSet();

            da.Fill(unitoffs, "unitoffcursor", (OracleRefCursor)(cmd.Parameters["unitoffcursor"].Value));

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
            }
        }


        private void populateProjects()
        {
            //Clear the grid
            grdProjects.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = projects.Tables[0].Rows.Count;
            object[] items;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //if user is an admin then load each enrolment to view, add to and edit
                //if (!isStudent)
                {
                    items = projects.Tables[0].Rows[i].ItemArray;
                    grdProjects.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4] });
                }
                //else //otherwise if they are not an admin, they're a student and should only load their own details to view
                //{
                //    if (projects.Tables[0].Rows[i][0].ToString().ToLower() == User.ToLower())
                //    {
                //        items = projects.Tables[0].Rows[i].ItemArray;
                //        grdProjects.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4] });
                //    }
                //}
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
                    OracleCommand cmd = new OracleCommand("UC2_5_Register_Project", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("projid", txtProjID.Text);
                    cmd.Parameters.Add("projdesc", txtProjDesc.Text);
                    cmd.Parameters.Add("unitid", cbUnitID.Text);
                    cmd.Parameters.Add("semester", cbSemester.Text);
                    cmd.Parameters.Add("year", cbYear.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    projects.Tables[0].Rows.Add(txtProjID.Text
                        , txtProjDesc.Text
                        , cbUnitID.SelectedItem
                        , cbSemester.SelectedItem
                        , cbYear.SelectedItem);

                    //Repopulate Grid
                    populateProjects();

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtProjID.Clear();
                    txtProjDesc.Clear();
                    cbUnitID.SelectedIndex = -1;
                    cbSemester.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;

                    grdProjects.Enabled = true;
                    btnAdd.Text = "Add";
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

                //Change button text and deselect any unit from grid
                btnAdd.Text = "Save?";
                grdProjects.ClearSelection();
                grdProjects.Enabled = false;
            }
        }

        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (txtProjID == null)
                ErrorMsg += Environment.NewLine + "Please enter a Project ID.";
            if (cbUnitID.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Unit ID.";
            if (cbSemester.SelectedIndex == -1)
                ErrorMsg += Environment.NewLine + "Please select a Semester.";
            if (cbYear.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Year.";

            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Project Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
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
            //Fixes it crashing when you actually add a project
            if (cbSemester.SelectedItem == null)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //allows you to edit only the project description

            //Logic and functions for save button
            if (btnEdit.Text == "Update?")
            {
                //Command to add Employee
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC2_6_Update_Project", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("Projid", txtProjID.Text);
                    cmd.Parameters.Add("ProjDesc", txtProjDesc.Text);
                    cmd.Parameters.Add("UnitID", cbUnitID.Text);
                    cmd.Parameters.Add("Semester", Convert.ToInt16(cbSemester.Text));
                    cmd.Parameters.Add("Year", Convert.ToInt16(cbYear.Text));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Grid and notify user
                    getProjects();
                    populateProjects();
                    MessageBox.Show("Project Updated");

                    //Disable textboxes
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear text- and combo-boxes
                    txtProjID.Clear();
                    txtProjDesc.Clear();
                    cbUnitID.SelectedIndex = -1;
                    cbSemester.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;

                    grdProjects.Enabled = true;
                    btnEdit.Text = "Edit";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //loading data into textboxes: find the row, load the data from the datagridset
                int selectedrowindex = grdProjects.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
                txtProjID.Text = grdProjects.Rows[selectedrowindex].Cells[0].Value.ToString();
                txtProjDesc.Text = grdProjects.Rows[selectedrowindex].Cells[1].Value.ToString();
                cbUnitID.SelectedItem = grdProjects.Rows[selectedrowindex].Cells[2].Value;
                cbSemester.SelectedItem = grdProjects.Rows[selectedrowindex].Cells[3].Value.ToString();
                cbYear.SelectedItem = grdProjects.Rows[selectedrowindex].Cells[4].Value.ToString();

                //Enable textboxes
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                gbIdentifyingInformation.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnEdit.Text = "Update?";
                grdProjects.ClearSelection();
                grdProjects.Enabled = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = grdProjects.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedprojid = grdProjects.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            string selectedunitid = grdProjects.Rows[selectedrowindex].Cells[2].Value.ToString(); //fetch the ID in that row
            string selectedsemester = grdProjects.Rows[selectedrowindex].Cells[3].Value.ToString(); //fetch the semester in that row
            string selectedyear = grdProjects.Rows[selectedrowindex].Cells[4].Value.ToString(); //fetch the year in that row

            DialogResult response = MessageBox.Show("Delete Project of " + selectedprojid +
                    " for unit " + selectedunitid +
                    ", semester " + selectedsemester +
                    ", " + selectedyear + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (response == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand("UC2_8_Delete_Project", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("projid", selectedprojid);
                cmd.Parameters.Add("unitid", selectedunitid);
                cmd.Parameters.Add("semester", selectedsemester);
                cmd.Parameters.Add("year", selectedyear);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getUnitOfferings();
                getProjects();
                populateProjects();
                MessageBox.Show("Project Deleted");
            }
        }
    }
}
