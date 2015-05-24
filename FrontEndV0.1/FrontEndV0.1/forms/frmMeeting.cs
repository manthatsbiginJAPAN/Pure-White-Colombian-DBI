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
    public partial class frmMeeting : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet teams;
        private DataSet meets;
        private DataSet stuteamallo;
        private DataSet attendees;
        private string User;
        private string supervisorID;
        private bool isSupervisor;

        private frmAgenda frmAgenda;
        private frmActionItems frmActionItems;

        public frmMeeting(string user, bool issupervisor)
        {
            InitializeComponent();
            connection = conn.oraConn();
            User = user;
            isSupervisor = issupervisor;

            if (!isSupervisor)
                supervisorID = null;
            else
                supervisorID = user;
        }


        private void frmMeeting_Load(object sender, EventArgs e)
        {
            //Fetch data
            getTeams();
            getMeetings();

            //Prepare and display data
            populateTeams();
            populateMeetingsGrid();

            if (!isSupervisor)
                chkApproved.Enabled = false;
            else
                chkApproved.Enabled = true;
        }

        #region getData

        private void getTeams()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_3_View_Team", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("teamcursor", OracleDbType.RefCursor);
            cmd.Parameters["teamcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("user", User);
            string role = null;

            //current problem is with an emp being both supervisor and convenor...
            //Ideally it needs to load based on both roles...

            if (isSupervisor)
                role = "supervisor";
            else
                role = "student";
            cmd.Parameters.Add("role", role);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teams = new DataSet();

            da.Fill(teams, "teamcursor", (OracleRefCursor)(cmd.Parameters["teamcursor"].Value));

            connection.Close();
        }

        private void getStudentTeamAllocations()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_18_View_Team_Allo", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("stuteamcursor", OracleDbType.RefCursor);
            cmd.Parameters["stuteamcursor"].Direction = ParameterDirection.ReturnValue;
            int selectedRow = grdMeetings.SelectedCells[0].RowIndex;
            cmd.Parameters.Add("teamid", grdMeetings.Rows[selectedRow].Cells[1].Value.ToString());
            cmd.Parameters.Add("unitid", grdMeetings.Rows[selectedRow].Cells[2].Value.ToString());
            cmd.Parameters.Add("semester", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[3].Value));
            cmd.Parameters.Add("year", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[4].Value));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            stuteamallo = new DataSet();

            da.Fill(stuteamallo, "stuteamcursor", (OracleRefCursor)(cmd.Parameters["stuteamcursor"].Value));

            connection.Close();
        }

        private void getAttendees()
        {
            //the command to check that 
            OracleCommand cmd = new OracleCommand("UC3_7_View_Meeting_Attend", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("attcursor", OracleDbType.RefCursor);
            cmd.Parameters["attcursor"].Direction = ParameterDirection.ReturnValue;
            int selectedRow = grdMeetings.SelectedCells[0].RowIndex;
            cmd.Parameters.Add("meetid", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[0].Value.ToString()));
            cmd.Parameters.Add("teamid", grdMeetings.Rows[selectedRow].Cells[1].Value.ToString());
            cmd.Parameters.Add("unitid", grdMeetings.Rows[selectedRow].Cells[2].Value.ToString());
            cmd.Parameters.Add("semester", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[3].Value));
            cmd.Parameters.Add("year", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[4].Value));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            attendees = new DataSet();
            da.Fill(attendees, "attcursor", (OracleRefCursor)(cmd.Parameters["attcursor"].Value));
            connection.Close();
        }

        private void getMeetings()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC3_1_View_Meeting", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("meetcursor", OracleDbType.RefCursor);
            cmd.Parameters["meetcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("user", User);
            string role = null;

            //current problem is with an emp being both supervisor and convenor...
            //Ideally it needs to load based on both roles...

            if (isSupervisor)
                role = "supervisor";
            else
                role = "student";
            cmd.Parameters.Add("role", role);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            meets = new DataSet();

            da.Fill(meets, "meetcursor", (OracleRefCursor)(cmd.Parameters["meetcursor"].Value));

            connection.Close();
        }

        #endregion

        private bool CheckStudentAttended(object stuid)
        {
            int rowcount = attendees.Tables[0].Rows.Count;
            for (int i = 0; i < rowcount; i++)
            {
                if (attendees.Tables[0].Rows[i][5].ToString().ToLower() == stuid.ToString().ToLower())
                    return true;    
            }
            return false;
        }

        #region populateWithData

        private void populateTeams()
        {
            //Clear boxes
            cbTeamID.Items.Clear();

            //Populate the boxes from the dataset
            int rowcnt = teams.Tables["teamcursor"].Rows.Count;
            object teamid = new object();
            object unitid = new object();
            object sem = new object();
            object year = new object();
            object sup = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                teamid = teams.Tables[0].Rows[i][0].ToString();
                unitid = teams.Tables[0].Rows[i][2].ToString();
                sem = teams.Tables[0].Rows[i][3].ToString();
                year = teams.Tables[0].Rows[i][4].ToString();
                sup = teams.Tables[0].Rows[i][5].ToString();

                if (!cbUnitID.Items.Contains(unitid.ToString())) //..what is this for?
                    cbUnitID.Items.Add(unitid.ToString());
            }
            //note the supervisorID for later use when adding meetings
            supervisorID = sup.ToString();
        }

        private void populateMeetingsGrid()
        {
            //Clear the grid
            grdMeetings.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = meets.Tables[0].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = meets.Tables[0].Rows[i].ItemArray;
                grdMeetings.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4], items[5],
                                                    items[6], items[7], items[8], items[9], items[10], items[11] } );
            }
        }

        private void populateAttendees()
        {
            grdAttendees.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = stuteamallo.Tables[0].Rows.Count;
            object[] items = new object[4];

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                 // = stuteamallo.Tables[0].Rows[i].ItemArray;
                items[0] = CheckStudentAttended(stuteamallo.Tables[0].Rows[i][0]);
                items[1] = stuteamallo.Tables[0].Rows[i][0];
                items[2] = stuteamallo.Tables[0].Rows[i][1];
                items[3] = stuteamallo.Tables[0].Rows[i][2];

                grdAttendees.Rows.Add(new object[] { items[0], items[1], items[2], items[3] });
            }
        }

        #endregion

        #region Add/Edit/DEL buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Logic and functions for save button
            if (btnAdd.Text == "Save?")
            {
                //Command to add Unit
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC3_2_Register_Meeting", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("meetingid", Convert.ToInt16(txtMeetID.Text));
                    cmd.Parameters.Add("teamid", cbTeamID.SelectedItem.ToString());         
                    cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
                    cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem.ToString()));
                    cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem.ToString()));
                    cmd.Parameters.Add("meettype", cbMeetingType.SelectedItem.ToString());
                    cmd.Parameters.Add("starttime", dtStartTime.Value.ToString("dd/MMM/yyyy"));
                    cmd.Parameters.Add("finishtime", dtFinishTime.Value.ToString("dd/MMM/yyyy"));
                    cmd.Parameters.Add("minutes", txtMeetingMinutes.Text);

                    if (cbMeetingType.SelectedItem.ToString().ToLower() != "student")
                        cmd.Parameters.Add("supid", supervisorID);
                    else
                        cmd.Parameters.Add("supid", null);

                    if (txtClientName.Enabled == true)
                        cmd.Parameters.Add("clientname", txtClientName.Text);
                    else
                        cmd.Parameters.Add("clientname", null);

                    if (chkApproved.Checked)
                        cmd.Parameters.Add("approved", "y");
                    else
                        cmd.Parameters.Add("approved", "n");

                    /*hard-coded test data
                    cmd.Parameters.Add("meetingid", txtMeetID.Text);
                    cmd.Parameters.Add("teamid", "Team1");
                    cmd.Parameters.Add("unitid", "INF10101");
                    cmd.Parameters.Add("semester", 1);
                    cmd.Parameters.Add("year", 2015);
                    cmd.Parameters.Add("meettype", "Student");
                    cmd.Parameters.Add("starttime", dtStartTime.Value.ToString("dd/MMM/yyyy"));
                    cmd.Parameters.Add("finishtime", dtFinishTime.Value.ToString("dd/MMM/yyyy"));
                    cmd.Parameters.Add("minutes", txtMeetingMinutes.Text);
                    cmd.Parameters.Add("supid", null);
                    cmd.Parameters.Add("clientname", null);
                    */

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Dataset then Grid
                    getMeetings();
                    populateMeetingsGrid();

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;

                    grdMeetings.Enabled = true;
                    btnAdd.Text = "Add";
                }
            }

            else
            {
                //Enable group boxes
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;

                //clear all fields
                cbUnitID.SelectedIndex = -1;
                cbSemester.SelectedIndex = -1;
                cbYear.SelectedIndex = -1;
                cbTeamID.SelectedIndex = -1;
                txtMeetID.Clear();
                cbMeetingType.SelectedIndex = -1;
                txtSupervisor.Clear();
                txtClientName.Clear();
                chkApproved.Checked = false;
                txtMeetingMinutes.Clear();

                //Change button text and deselect any unit offering from grid
                btnAdd.Text = "Save?";
                grdMeetings.ClearSelection();
                grdMeetings.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Save?")
            {
                OracleCommand cmd = new OracleCommand("UC3_3_Update_Meeting", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("meetingid", Convert.ToInt16(txtMeetID.Text));
                cmd.Parameters.Add("teamid", cbTeamID.SelectedItem.ToString());
                cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
                cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem.ToString()));
                cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem.ToString()));
                cmd.Parameters.Add("meettype", cbMeetingType.SelectedItem.ToString());
                cmd.Parameters.Add("starttime", dtStartTime.Value.ToString("dd/MMM/yyyy"));
                cmd.Parameters.Add("finishtime", dtFinishTime.Value.ToString("dd/MMM/yyyy"));
                cmd.Parameters.Add("minutes", txtMeetingMinutes.Text);

                if (cbMeetingType.SelectedItem.ToString().ToLower() != "student")
                    cmd.Parameters.Add("supid", supervisorID);
                else
                    cmd.Parameters.Add("supid", null);

                if (txtClientName.Enabled)
                    cmd.Parameters.Add("clientname", txtClientName.Text);
                else
                    cmd.Parameters.Add("clientname", null);
                
                if (chkApproved.Checked)
                    cmd.Parameters.Add("approved", "y");
                else
                    cmd.Parameters.Add("approved", "n");

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                //Repopulate data
                getMeetings();

                populateMeetingsGrid();

                btnEdit.Text = "Edit";

                //Enable Buttons and grid

                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                grdMeetings.Enabled = true;

                //Enable/disable
                gbDetails.Enabled = false;
                cbUnitID.Enabled = true;
            }
            else
            {
                btnEdit.Text = "Save?";

                grdMeetings.Enabled = false;

                //disable buttons
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                int selectedrow = grdMeetings.SelectedCells[0].RowIndex;

                //txtMeetID.Text = grdMeetings.Rows[selectedrow].Cells[0].Value.ToString();
                
                //if (cbTeamID.Items.Count != 0)
                //    cbTeamID.SelectedIndex = -1;
                // MessageBox.Show(cbTeamID.SelectedItem.ToString() + " == " + grdMeetings.Rows[selectedrow].Cells[1].Value.ToString());

                /*
                cbUnitID.SelectedItem = grdMeetings.Rows[selectedrow].Cells[2].Value.ToString();
                cbSemester.SelectedItem = grdMeetings.Rows[selectedrow].Cells[3].Value.ToString();
                cbYear.SelectedItem = grdMeetings.Rows[selectedrow].Cells[4].Value.ToString();
                cbTeamID.SelectedItem = grdMeetings.Rows[selectedrow].Cells[1].Value.ToString();
                */

                gbDetails.Enabled = true;

                int rowcnt = meets.Tables["meetcursor"].Rows.Count;

                for (int i = 0; i <= rowcnt - 1; i++)
                {
                    object[] items = meets.Tables[0].Rows[i].ItemArray;

                    //Checking if selected meeting matches in the dataset
                    if (Convert.ToString(items[0]) == grdMeetings.Rows[selectedrow].Cells[0].Value.ToString()
                        && Convert.ToString(items[1]) == grdMeetings.Rows[selectedrow].Cells[1].Value.ToString()
                        && Convert.ToString(items[2]) == grdMeetings.Rows[selectedrow].Cells[2].Value.ToString()
                        && Convert.ToString(items[3]) == grdMeetings.Rows[selectedrow].Cells[3].Value.ToString()
                        && Convert.ToString(items[4]) == grdMeetings.Rows[selectedrow].Cells[4].Value.ToString())
                    {
                        //Fill form controls with data to be updated
                        gbIdentifyingInformation.Enabled = false;
                     
                        cbMeetingType.Enabled = true;
              

                        cbMeetingType.SelectedItem = items[5].ToString();
                        dtStartTime.Value = Convert.ToDateTime(items[6]);
                        dtFinishTime.Value = Convert.ToDateTime(items[7]);
                        txtMeetingMinutes.Text = items[8].ToString();
                        txtSupervisor.Text = items[9].ToString();

                        txtClientName.Text = items[10].ToString();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdMeetings.Rows.Count == 0)
                return;

            int selectedrow = grdMeetings.SelectedCells[0].RowIndex;
            OracleCommand cmd = new OracleCommand("UC3_4_Delete_Meeting", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("meetid", Convert.ToInt16(grdMeetings.Rows[selectedrow].Cells[0].Value));
            cmd.Parameters.Add("teamid", grdMeetings.Rows[selectedrow].Cells[1].Value.ToString());
            cmd.Parameters.Add("unitid", grdMeetings.Rows[selectedrow].Cells[2].Value.ToString());
            cmd.Parameters.Add("semester", grdMeetings.Rows[selectedrow].Cells[3].Value.ToString());
            cmd.Parameters.Add("year", grdMeetings.Rows[selectedrow].Cells[4].Value.ToString());

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Entry Deleted");

            getMeetings();
            populateMeetingsGrid();
        }

#endregion 

        private bool FormValidated() //UPDATE
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (cbUnitID.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Unit ID.";
            if (cbSemester.SelectedIndex == -1)
                ErrorMsg += Environment.NewLine + "Please select a Semester.";
            if (cbYear.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Year.";
            if (cbTeamID.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Team ID.";
            if (txtMeetID.Text == null)
                ErrorMsg += Environment.NewLine + "Please enter a Meeting Number.";
            if (cbMeetingType.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Meeting Type.";
            if ((Convert.ToDateTime(dtFinishTime.Text)) < (Convert.ToDateTime(dtStartTime.Text)))
                ErrorMsg += Environment.NewLine + "Finish time cannot be before start time";


            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Meeting Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        #region Selections Changed

        private void grdMeetings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //load meeting details into fields from gridbox
            int selectedrowindex = grdMeetings.SelectedCells[0].RowIndex;
            cbUnitID.SelectedIndex = cbUnitID.FindString(grdMeetings.Rows[selectedrowindex].Cells[2].Value.ToString());
            cbSemester.SelectedIndex = cbSemester.FindString(grdMeetings.Rows[selectedrowindex].Cells[3].Value.ToString());
            cbYear.SelectedIndex = cbYear.FindString(grdMeetings.Rows[selectedrowindex].Cells[4].Value.ToString());
            cbTeamID.SelectedIndex = cbTeamID.FindString(grdMeetings.Rows[selectedrowindex].Cells[1].Value.ToString());
            txtMeetID.Text = grdMeetings.Rows[selectedrowindex].Cells[0].Value.ToString();
            cbMeetingType.SelectedIndex = cbMeetingType.FindString(grdMeetings.Rows[selectedrowindex].Cells[5].Value.ToString());
            dtStartTime.Value = Convert.ToDateTime(grdMeetings.Rows[selectedrowindex].Cells[6].Value);
            dtFinishTime.Value = Convert.ToDateTime(grdMeetings.Rows[selectedrowindex].Cells[7].Value);
            txtMeetingMinutes.Text = grdMeetings.Rows[selectedrowindex].Cells[8].Value.ToString();
            txtSupervisor.Text = grdMeetings.Rows[selectedrowindex].Cells[9].Value.ToString();
            txtClientName.Text = grdMeetings.Rows[selectedrowindex].Cells[10].Value.ToString();
            
            
            //check if selected meeting is approved, if so, then prevent 'students' from editing
            if (grdMeetings.Rows[selectedrowindex].Cells[11].Value.ToString().ToLower() == "y")
            {
                chkApproved.Checked = true;

                if (!isSupervisor) //prevent students from editing approved meetings
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
            else
            {
                chkApproved.Checked = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void cbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnitID.SelectedIndex != -1)
                cbSemester.Enabled = true;
            else
                return;

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;
            object sem = new object();
            cbSemester.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
                if (teams.Tables[0].Rows[i][2].ToString() == cbUnitID.SelectedItem.ToString())
                {
                    sem = teams.Tables["teamcursor"].Rows[i][3].ToString();

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
            if (cbSemester.SelectedIndex != -1)
                cbYear.Enabled = true;
            else
                return;

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;
            object year = new object();
            cbYear.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the years where the semester matches the selected one
                if (teams.Tables[0].Rows[i][2].ToString() == cbUnitID.SelectedItem.ToString() && teams.Tables[0].Rows[i][3].ToString() == cbSemester.SelectedItem.ToString())
                {
                    year = teams.Tables["teamcursor"].Rows[i][4].ToString();

                    if (!cbYear.Items.Contains(year))
                        cbYear.Items.Add(year);

                    //sort the list numerically/alphabetically
                    cbYear.Sorted = true;
                }
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.SelectedIndex != -1)
                cbTeamID.Enabled = true;
            else
                return;

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;
            object team = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the years where the semester matches the selected one
                if (teams.Tables[0].Rows[i][2].ToString() == cbUnitID.SelectedItem.ToString() && teams.Tables[0].Rows[i][3].ToString() == cbSemester.SelectedItem.ToString() && teams.Tables[0].Rows[i][4].ToString() == cbYear.SelectedItem.ToString())
                {
                    team = teams.Tables["teamcursor"].Rows[i][0].ToString();

                    //only note one option for semesters once per instance
                    if (!cbTeamID.Items.Contains(team))
                        cbTeamID.Items.Add(team);

                    //sort the list numerically/alphabetically
                    cbTeamID.Sorted = true;
                }
            }
        }

        

        private void cbTeamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeamID.SelectedIndex != -1)
                txtMeetID.Enabled = true;
            cbMeetingType.Enabled = true;

        }

        private void txtMeetID_TextChanged(object sender, EventArgs e)
        {
            cbMeetingType.Enabled = true;
        }

        private void cbMeetingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtStartTime.Enabled = true;
            dtFinishTime.Enabled = true;
            txtMeetingMinutes.Enabled = true;

            if (cbMeetingType.SelectedItem.ToString().ToLower() == "supervisor") // null reference exception here needs to be handled
            {
                txtSupervisor.Text = supervisorID;
                txtClientName.Enabled = false;
            }
            

            if (cbMeetingType.SelectedItem.ToString().ToLower() == "client")
            {
                txtClientName.Enabled = true;
                txtSupervisor.Clear();
            }

            if (cbMeetingType.SelectedItem.ToString().ToLower() == "student")
            {
                txtClientName.Enabled = false;
                txtSupervisor.Clear();
            }
        }

        #endregion

        private void btnActionItems_Click(object sender, EventArgs e)
        {
            if (FormValidated())
            {
                frmActionItems = new frmActionItems(this, txtMeetID.Text.ToString(), cbTeamID.SelectedItem.ToString(), cbUnitID.SelectedItem.ToString(), cbSemester.SelectedItem.ToString(), cbYear.SelectedItem.ToString());
                frmActionItems.Show();
            }
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            if (FormValidated())
            {
                frmAgenda = new frmAgenda(this, txtMeetID.Text.ToString(), cbTeamID.SelectedItem.ToString(), cbUnitID.SelectedItem.ToString(), cbSemester.SelectedItem.ToString(), cbYear.SelectedItem.ToString());
                frmAgenda.Show();
            }
        }

        private void btnLoadAttendees_Click(object sender, EventArgs e)
        {
            //should work much like the typical edit/save button...
            if (grdMeetings.Rows.Count == 0)
            {
                MessageBox.Show("No selected meeting");
                return;
            }

          
            if (btnLoadAttendees.Text == "Save?")
            {
                int rowcount = grdAttendees.Rows.Count;
                for (int i = 0; i < rowcount; i++)
                {
                    if (grdAttendees.Rows[i].Cells[0].Value.Equals(true))
                    {
                        OracleCommand cmd = new OracleCommand("UC3_5_Add_Meeting_Attend", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        int selectedRow = grdMeetings.SelectedCells[0].RowIndex;
                        cmd.Parameters.Add("meetid", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[0].Value.ToString()));
                        cmd.Parameters.Add("teamid", grdMeetings.Rows[selectedRow].Cells[1].Value.ToString());
                        cmd.Parameters.Add("unitid", grdMeetings.Rows[selectedRow].Cells[2].Value.ToString());
                        cmd.Parameters.Add("semester", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[3].Value));
                        cmd.Parameters.Add("year", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[4].Value));
                        cmd.Parameters.Add("stuid", grdAttendees.Rows[i].Cells[1].Value);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        OracleCommand cmd = new OracleCommand("UC3_6_Delete_Meeting_Attend", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        int selectedRow = grdMeetings.SelectedCells[0].RowIndex;
                        cmd.Parameters.Add("meetid", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[0].Value.ToString()));
                        cmd.Parameters.Add("teamid", grdMeetings.Rows[selectedRow].Cells[1].Value.ToString());
                        cmd.Parameters.Add("unitid", grdMeetings.Rows[selectedRow].Cells[2].Value.ToString());
                        cmd.Parameters.Add("semester", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[3].Value));
                        cmd.Parameters.Add("year", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[4].Value));
                        cmd.Parameters.Add("stuid", grdAttendees.Rows[i].Cells[1].Value);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                grdMeetings.Enabled = true;
                grdAttendees.Rows.Clear();
                gbButtons.Enabled = true;
                btnLoadAttendees.Text = "Load";
            }
            else
            {
                getStudentTeamAllocations();
                getAttendees();
                populateAttendees();

                //Change button text and disable Meetings grid so the user can't acidentally change selected meeting
                btnLoadAttendees.Text = "Save?";
                grdMeetings.Enabled = false;
                gbButtons.Enabled = false;
            }
        }

        private void grdMeetings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
