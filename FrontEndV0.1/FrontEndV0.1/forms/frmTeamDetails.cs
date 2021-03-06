﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FrontEndV0._1.forms
{
    public partial class frmTeamDetails : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet ds;
        private DataSet teams;
        private DataSet teamallocs;
        private DataSet allallocs;
        private DataSet unitoffs;
        private DataSet projects;
        private DataSet enrolments;
        private string User;
        private bool isConvenor;
        private bool isSupervisor;

        public frmTeamDetails(string user, bool isconvenor, bool issupervisor)
        {
            InitializeComponent();
            User = user;
            isConvenor = isconvenor; //will need updating in terms of how things are enabled/disabled...
            isSupervisor = issupervisor;
            connection = conn.oraConn();

            if (!isConvenor) //if is a student
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnAddStu.Enabled = false;
                btnDeleteStu.Enabled = false;
                gbDetails.Enabled = false;
                gbIdentifyingInformation.Enabled = false;
                grdTeamAllocation.Enabled = false;
            }
        }

        private void frmTeamDetails_Load(object sender, EventArgs e)
        {
            getTeams();
            getProjects();
            getUnitOfferings();
            getEmployees();
            getEnrolments();

            populateTeamGrid();
            populateSupervisors();
            populateProjects();
            //populateUnitOfferings(); //not necessary? 
        }

        #region getData
        private void getProjects()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_7_View_Project", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("projcursor", OracleDbType.RefCursor);
            cmd.Parameters["projcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("user", User);
            string role = null;

            //current problem is with an emp being both supervisor and convenor, as only convenor-related teams are fetched...
            //Ideally it needs to load teams based on both roles...

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

        private void getTeams()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_3_View_Team", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("teamcursor", OracleDbType.RefCursor);
            cmd.Parameters["teamcursor"].Direction = ParameterDirection.ReturnValue;
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

            teams = new DataSet();

            da.Fill(teams, "teamcursor", (OracleRefCursor)(cmd.Parameters["teamcursor"].Value));

            connection.Close();
        }

        private void getEmployees()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_26_View_Employee_Role", connection);
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

        private void getTeamAllocs()
        {
            //ensure it doesn't try to execute the query for a non-existing team
            if (grdTeamInfo.Rows.Count == 0)
                return;

            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_18_View_Team_Allo", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("talloccursor", OracleDbType.RefCursor);
            cmd.Parameters["talloccursor"].Direction = ParameterDirection.ReturnValue;
            int selectedRow = grdTeamInfo.SelectedCells[0].RowIndex;
            cmd.Parameters.Add("teamid", grdTeamInfo.Rows[selectedRow].Cells[0].Value.ToString());
            cmd.Parameters.Add("unitid", grdTeamInfo.Rows[selectedRow].Cells[2].Value.ToString());
            cmd.Parameters.Add("semester", Convert.ToInt16(grdTeamInfo.Rows[selectedRow].Cells[3].Value));
            cmd.Parameters.Add("year", Convert.ToInt16(grdTeamInfo.Rows[selectedRow].Cells[4].Value));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teamallocs = new DataSet();

            da.Fill(teamallocs, "talloccursor", (OracleRefCursor)(cmd.Parameters["talloccursor"].Value));

            connection.Close();
        }

        private void getAllAllocs()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_18_View_Team_Allo_All", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("allcursor", OracleDbType.RefCursor);
            cmd.Parameters["allcursor"].Direction = ParameterDirection.ReturnValue;
            int selectedRow = grdTeamInfo.SelectedCells[0].RowIndex;
            cmd.Parameters.Add("unitid", grdTeamInfo.Rows[selectedRow].Cells[2].Value.ToString());
            cmd.Parameters.Add("semester", Convert.ToInt16(grdTeamInfo.Rows[selectedRow].Cells[3].Value));
            cmd.Parameters.Add("year", Convert.ToInt16(grdTeamInfo.Rows[selectedRow].Cells[4].Value));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            allallocs = new DataSet();

            da.Fill(allallocs, "allcursor", (OracleRefCursor)(cmd.Parameters["allcursor"].Value));

            connection.Close();
        }

        private void getEnrolments()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_15_View_Enrolment", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("enrolcursor", OracleDbType.RefCursor);
            cmd.Parameters["enrolcursor"].Direction = ParameterDirection.ReturnValue;

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            enrolments = new DataSet();

            da.Fill(enrolments, "enrolcursor", (OracleRefCursor)(cmd.Parameters["enrolcursor"].Value));

            connection.Close();
        }
        #endregion

        #region populateWithData
        private void populateUnitOfferings()
        {
            //Clear the comboboxes
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

                /*if (!cbUnitID.Items.Contains(unitid.ToString()))
                    cbUnitID.Items.Add(unitid.ToString());
                if (!cbSemester.Items.Contains(sem))
                    cbSemester.Items.Add(sem);
                if (!cbYear.Items.Contains(year))
                    cbYear.Items.Add(year);
                */
            }
        }

        private void populateTeamGrid()
        {
            //Clear the grid
            grdTeamInfo.Rows.Clear();

            //Populate the grid from the dataset

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = teams.Tables[0].Rows[i].ItemArray;
                grdTeamInfo.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4], items[5] });
            }
        }

        private void populateProjects()
        {
            //Clear the grid
            cbProjID.Items.Clear();

            //Populate the UNITID combo box from the dataset, as it should be the first selected, then semester, year, projid...
            int rowcnt = projects.Tables[0].Rows.Count;
            object unitid = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                unitid = projects.Tables[0].Rows[i][2].ToString();
                if (!cbUnitID.Items.Contains(unitid.ToString()))
                    cbUnitID.Items.Add(unitid.ToString());
            }
        }

        private void populateSupervisors()
        {
            //Clear the grid
            cbSupervisor.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = ds.Tables["empcursor"].Rows.Count;
            object items = new object();
            String roles = null;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                items = ds.Tables["empcursor"].Rows[i][0].ToString();
                roles = ds.Tables["empcursor"].Rows[i][1].ToString();
                if (!cbSupervisor.Items.Contains(items.ToString()))
                {
                    if (roles.ToLower().Equals("supervisor"))
                    {
                        cbSupervisor.Items.Add(items.ToString());
                    }
                }
            }
        }

        private void populateTeamAllocs()
        {
            //Clear the grid
            grdTeamAllocation.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = teamallocs.Tables[0].Rows.Count;
            object[] items;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                items = teamallocs.Tables[0].Rows[i].ItemArray;
                grdTeamAllocation.Rows.Add(new object[] { items[0], items[1], items[2] });
            }
            //MessageBox.Show(grdTeamAllocation.Rows.Count + " Team Member(s)");


            /*for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = teamallocs.Tables[0].Rows[i].ItemArray;
                if (items[0].ToString().Equals(txtTeamID.Text) && items[2].ToString().Equals(cbUnitID.SelectedItem.ToString())
                    && items[3].ToString().Equals(cbSemester.SelectedItem.ToString())
                    && items[4].ToString().Equals(cbYear.SelectedItem.ToString()))
                {
                    grdTeamAllocation.Rows.Add(new object[] { items[0], items[1]});
                }
            }*/
        }

        private void populateEnrolledStus()
        {
            //Clear the grid
            cbStuID.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = enrolments.Tables["enrolcursor"].Rows.Count;
            object stuid = new object();
            object unit = new object();
            object semester = new object();
            object year = new object();

            for (int i = 0; i < rowcnt; i++)
            {
                stuid = enrolments.Tables["enrolcursor"].Rows[i][0].ToString();
                unit = enrolments.Tables["enrolcursor"].Rows[i][1].ToString();
                semester = enrolments.Tables["enrolcursor"].Rows[i][2].ToString();
                year = enrolments.Tables["enrolcursor"].Rows[i][3].ToString();
                
                //find only students enrolled in this unit offering
                if (unit.Equals(cbUnitID.SelectedItem) &&
                    semester.Equals(cbSemester.SelectedItem) &&
                    year.Equals(cbYear.SelectedItem))
                {
                    //Add first
                    //cbStuID.Items.Add(stuid.ToString());
                    //MessageBox.Show(stuid.ToString() + " added");

                    //but remove if they're already in a team...
                    getAllAllocs();
                    int rwcnt = allallocs.Tables[0].Rows.Count;
                    for (int j = 0; j <= rwcnt -1; j++)
                    {
                        //if the student doesnt exist already then add them
                        
                        //MessageBox.Show(stuid.ToString() + " compared to " + allallocs.Tables[0].Rows[j][1].ToString());

                        if (allallocs.Tables[0].Rows[j][1].ToString() == stuid.ToString())
                        {
                            //if (!cbStuID.Items.Contains(stuid.ToString()))
                            if (cbStuID.Items.Contains(stuid.ToString()))
                            {
                                cbStuID.Items.Remove(stuid.ToString());
                               // MessageBox.Show(stuid.ToString() + " removed");
                            }
                            break;
                        }
                        else
                        {
                            if (!cbStuID.Items.Contains(stuid.ToString()))
                            {
                                cbStuID.Items.Add(stuid.ToString());
                               // MessageBox.Show(stuid.ToString() + " added");
                            }
                        }
                    }   
                }
            }    
        }
        #endregion

        #region BtnPress
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnAdd.Text == "Save?")
            {
                //Command to add team
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC2_1_REGISTER_TEAM", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 100;
                    
                    cmd.Parameters.Add("teamID", txtTeamID.Text);
                    cmd.Parameters.Add("projID", cbProjID.SelectedItem);
                    cmd.Parameters.Add("unitID", cbUnitID.SelectedItem);
                    cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem.ToString()));
                    cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem.ToString()));
                    cmd.Parameters.Add("empID", cbSupervisor.SelectedItem);
                    cmd.Parameters.Add("role", "Supervisor");

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    teams.Tables[0].Rows.Add(txtTeamID.Text
                        , cbProjID.SelectedItem
                        , cbUnitID.SelectedItem
                        , cbSemester.SelectedItem
                        , cbYear.SelectedItem
                        , cbSupervisor.SelectedItem);


                    //Repopulate Grid
                    populateTeamGrid();

                    //Disable buttons
                    txtTeamID.Enabled = false;
                    cbProjID.Enabled = false;
                    cbUnitID.Enabled = false;
                    cbSemester.Enabled = false;
                    cbYear.Enabled = false;
                    cbSupervisor.Enabled = false;

                    //Enable other buttons
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtTeamID.Clear();

                    btnAdd.Text = "Add";
                }
            }
            else
            {
                gbIdentifyingInformation.Enabled = true;
                //Enable buttons
                txtTeamID.Enabled = true;
                cbProjID.Enabled = true;
                cbUnitID.Enabled = true;
                cbSemester.Enabled = true;
                cbYear.Enabled = true;

                gbDetails.Enabled = true;
                cbSupervisor.Enabled = true;
                //txtStuID.Enabled = true;

                //Disable other buttons
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnAdd.Text = "Save?";
                grdTeamInfo.ClearSelection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = grdTeamInfo.SelectedCells[0].RowIndex; //find the selected row

            string selectedteamid = grdTeamInfo.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            string selectedstuid;
            string selectedunitid = grdTeamInfo.Rows[selectedrowindex].Cells[2].Value.ToString();
            string selectedsemester = grdTeamInfo.Rows[selectedrowindex].Cells[3].Value.ToString();
            string selectedyear = grdTeamInfo.Rows[selectedrowindex].Cells[4].Value.ToString();
            DialogResult response = MessageBox.Show("Delete Team: " + selectedteamid + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                int i = 0;
                foreach (DataGridViewRow student in grdTeamAllocation.Rows)
                {
                    selectedstuid = student.Cells[0].Value.ToString();
                    OracleCommand cmd1 = new OracleCommand("UC2_20_Delete_Team_Allo", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("teamid", selectedteamid);
                    cmd1.Parameters.Add("stuid", selectedstuid);
                    cmd1.Parameters.Add("unitid", selectedunitid);
                    cmd1.Parameters.Add("semester", selectedsemester);
                    cmd1.Parameters.Add("year", selectedyear);

                    connection.Open();
                    cmd1.ExecuteNonQuery();
                    connection.Close();
                    i++;
                }

                OracleCommand cmd = new OracleCommand("UC2_4_Delete_Team", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("teamid", selectedteamid);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getTeams();
                populateTeamGrid();

                getTeamAllocs();
                populateTeamAllocs();

                MessageBox.Show("Team Deleted");
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
                    OracleCommand cmd = new OracleCommand("UC2_2_Update_Team", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("teamID", txtTeamID.Text);
                    cmd.Parameters.Add("projID", cbProjID.SelectedItem);
                    cmd.Parameters.Add("unitID", cbUnitID.SelectedItem);
                    cmd.Parameters.Add("semester", cbSemester.SelectedItem);
                    cmd.Parameters.Add("year", cbYear.SelectedItem);
                    cmd.Parameters.Add("empID", cbSupervisor.SelectedItem);
                    //cmd.Parameters.Add("role", "supervisor");

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Grid and notify user
                    getTeams();
                    populateTeamGrid();
                    MessageBox.Show("Team Updated");

                    //Disable textboxes
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtTeamID.Clear();
                    cbProjID.SelectedIndex = -1;
                    cbUnitID.SelectedIndex = -1;
                    cbSemester.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;
                    cbSupervisor.SelectedIndex = -1;

                    grdTeamInfo.Enabled = true;
                    btnEdit.Text = "Edit";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //loading data into textboxes: find the row, load the data from the datagridset
                int selectedrowindex = grdTeamInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
                txtTeamID.Text = grdTeamInfo.Rows[selectedrowindex].Cells[0].Value.ToString();
                
                cbUnitID.SelectedIndex = cbUnitID.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[2].Value.ToString());
                cbSemester.SelectedIndex = cbSemester.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[3].Value.ToString());
                cbYear.SelectedIndex = cbYear.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[4].Value.ToString());
                cbSupervisor.SelectedIndex = cbSupervisor.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[5].Value.ToString());
                cbProjID.SelectedIndex = cbProjID.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[1].Value.ToString());

                //Enable textboxes
                gbIdentifyingInformation.Enabled = true;
                txtTeamID.Enabled = false;
                cbProjID.Enabled = false;
                cbUnitID.Enabled = false;
                cbSemester.Enabled = false;
                cbYear.Enabled = false;

                gbDetails.Enabled = true;
                cbSupervisor.Enabled = true;

                //Disable other buttons
                //gbIdentifyingInformation.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnEdit.Text = "Update?";
                grdTeamInfo.ClearSelection();
                grdTeamInfo.Enabled = false;
            }
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            if (grdTeamInfo.SelectedRows.Count == 0)
                return;

            //Logic and functions for save button
            if (btnAddStu.Text == "Save?")
            {
                //Command to add team
                if (FormValidated() && cbStuID.Text.Length > 0)
                {
                    OracleCommand cmd = new OracleCommand("UC2_17_Register_Team_Allo", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 100;

                    cmd.Parameters.Add("teamID", txtTeamID.Text);
                    cmd.Parameters.Add("stuID", cbStuID.Text);
                    cmd.Parameters.Add("unitID", cbUnitID.SelectedItem);
                    cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem));
                    cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Retrieve Data and Repopulate Grid
                    getTeamAllocs();
                    populateTeamAllocs();

                    //Disable fields
                    cbStuID.Enabled = false;

                    //Enable other buttons
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteStu.Enabled = true;

                    //Clear textboxes
                    txtTeamID.Clear();
                    cbStuID.SelectedIndex = -1;

                    grdTeamInfo.Enabled = true;
                    btnAddStu.Text = "Add";
                }
            }
            else
            {
                //enable fields
                cbStuID.Enabled = true;

                //Disable other buttons
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnDeleteStu.Enabled = false;

                //Change button text
                btnAddStu.Text = "Save?";

                //disable Teamgrid
                grdTeamInfo.Enabled = false;
            }
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            int selectedrowindex = grdTeamAllocation.SelectedCells[0].RowIndex; //find the selected row in teamAlloc grid
            int selectedTeamRowindex = grdTeamInfo.SelectedCells[0].RowIndex; //find the selected row in team info grid

            string selectedteamid = grdTeamInfo.Rows[selectedTeamRowindex].Cells[0].Value.ToString();//fetch the ID in that row
            string selectedstuid = grdTeamAllocation.Rows[selectedrowindex].Cells[0].Value.ToString();
            string selectedunitid = grdTeamInfo.Rows[selectedTeamRowindex].Cells[2].Value.ToString();
            string selectedsemester = grdTeamInfo.Rows[selectedTeamRowindex].Cells[3].Value.ToString();
            string selectedyear = grdTeamInfo.Rows[selectedTeamRowindex].Cells[4].Value.ToString();
            DialogResult response = MessageBox.Show("Delete Student: "+ selectedstuid +" from Team: " + selectedteamid + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand("UC2_20_Delete_Team_Allo", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("teamid", selectedteamid);
                cmd.Parameters.Add("stuid", selectedstuid);
                cmd.Parameters.Add("unitid", selectedunitid);
                cmd.Parameters.Add("semester", selectedsemester);
                cmd.Parameters.Add("year", selectedyear);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getTeamAllocs();
                populateTeamAllocs();
            }
        }

        #endregion

        private bool FormValidated()
        {
            return true;
        }

        private void grdTeamInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = grdTeamInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            txtTeamID.Text = grdTeamInfo.Rows[selectedrowindex].Cells[0].Value.ToString();
            cbUnitID.SelectedIndex = cbUnitID.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[2].Value.ToString());
            cbSemester.SelectedIndex = cbSemester.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[3].Value.ToString());
            cbYear.SelectedIndex = cbYear.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[4].Value.ToString());
            cbSupervisor.SelectedIndex = cbSupervisor.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[5].Value.ToString());
            cbProjID.SelectedIndex = cbProjID.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[1].Value.ToString());

            getEnrolments();
            getTeamAllocs();

            populateEnrolledStus();
            populateTeamAllocs();
        }

        private void grdTeamAllocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteStu.Enabled = true;
            btnAddStu.Enabled = true;
        }

        private void cbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fixes it crashing when you actually add an enrolment
            if (cbUnitID.SelectedItem == null)
                return;

            if (cbUnitID.SelectedIndex != -1)
                cbSemester.Enabled = true;

            int rowcnt = projects.Tables[0].Rows.Count;
            object sem = new object();
            cbSemester.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {

                //find the semesters where the unitID matches the selected one
                if (projects.Tables[0].Rows[i][2].ToString() == cbUnitID.SelectedItem.ToString())
                {
                    sem = projects.Tables[0].Rows[i][3].ToString();

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

            int rowcnt = projects.Tables[0].Rows.Count;
            object year = new object();
            cbYear.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
                if (projects.Tables[0].Rows[i][2].ToString() == cbUnitID.SelectedItem.ToString() && projects.Tables[0].Rows[i][3].ToString() == cbSemester.SelectedItem.ToString())
                {
                    year = projects.Tables[0].Rows[i][4].ToString();

                    //only note one option for semesters once per instance
                    if (!cbYear.Items.Contains(year))
                        cbYear.Items.Add(year);

                    //sort the list numerically/alphabetically
                    cbYear.Sorted = true;
                }
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fixes it crashing when you actually add a project
            if (cbYear.SelectedItem == null)
                return;

            if (cbYear.SelectedIndex != -1)
                cbProjID.Enabled = true;

            int rowcnt = projects.Tables[0].Rows.Count;
            object projid = new object();
            cbProjID.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
                if (projects.Tables[0].Rows[i][2].ToString() == cbUnitID.SelectedItem.ToString() && 
                    projects.Tables[0].Rows[i][3].ToString() == cbSemester.SelectedItem.ToString() &&
                    projects.Tables[0].Rows[i][4].ToString() == cbYear.SelectedItem.ToString() )
                {
                    projid = projects.Tables[0].Rows[i][0].ToString();

                    //only note one option for semesters once per instance
                    if (!cbProjID.Items.Contains(projid))
                        cbProjID.Items.Add(projid);

                    //sort the list numerically/alphabetically
                    cbProjID.Sorted = true;
                }
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (gbIdentifyingInformation.Enabled == false)
                gbIdentifyingInformation.Enabled = true;
            else
                gbIdentifyingInformation.Enabled = false;
        }
    }
}
