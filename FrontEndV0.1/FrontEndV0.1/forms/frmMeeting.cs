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


        public frmMeeting()
        {
            InitializeComponent();

            connection = conn.oraConn();
        }


        private void frmMeeting_Load(object sender, EventArgs e)
        {
            //Fetch data
            getTeams();
            getMeetings();
            getStudentTeamAllocations();

            //Prepare and display data
            populateTeams();
            populateMeetingsGrid(this.grdMeetings);
            //populateSupervisors();
        }

        #region getData

        private void getTeams()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_3_View_Team", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("teamcursor", OracleDbType.RefCursor);
            cmd.Parameters["teamcursor"].Direction = ParameterDirection.ReturnValue;

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

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            stuteamallo = new DataSet();

            da.Fill(meets, "stuteamcursor", (OracleRefCursor)(cmd.Parameters["stuteamcursor"].Value));

            connection.Close();
        }

        private void getMeetings()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC3_1_View_Meeting", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("meetcursor", OracleDbType.RefCursor);
            cmd.Parameters["meetcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            meets = new DataSet();

            da.Fill(meets, "meetcursor", (OracleRefCursor)(cmd.Parameters["meetcursor"].Value));

            connection.Close();
        }

        #endregion

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
                teamid = teams.Tables["teamcursor"].Rows[i][0].ToString();
                unitid = teams.Tables["teamcursor"].Rows[i][2].ToString();
                sem = teams.Tables["teamcursor"].Rows[i][3].ToString();
                year = teams.Tables["teamcursor"].Rows[i][4].ToString();
                sup = teams.Tables["teamcursor"].Rows[i][5].ToString();

                if (!cbUnitID.Items.Contains(unitid.ToString()))
                    cbUnitID.Items.Add(unitid.ToString());

              //uneeded:
              //  if (!cbSemester.Items.Contains(sem))
              //      cbSemester.Items.Add(sem);
              //  if (!cbYear.Items.Contains(year))
              //      cbYear.Items.Add(year);
              //  if (!cbTeamID.Items.Contains(teamid.ToString()))
              //      cbTeamID.Items.Add(teamid.ToString());
            }
        }

        private void populateMeetingsGrid(DataGridView thegrid)
        {
            //Clear the grid
            grdMeetings.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = meets.Tables[0].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = meets.Tables[0].Rows[i].ItemArray;
                grdMeetings.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4] });
            }
        }

       /* private void populateAttendance()
        {
            clbAttendees.ClearSelected();

            //Populate the grid from the dataset
            int rowcnt = stuteamallo.Tables[0].Rows.Count;
            object attendees = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
               attendees = teams.Tables["teamcursor"].Rows[i][1].ToString();
               cbUnitID.Items.Add(unitid.ToString()
            }
        } */

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
                    //cmd.Parameters.Add("starttime", Convert.ToDateTime(txtStart.Text));
                    //cmd.Parameters.Add("finishtime", Convert.ToDateTime(txtFinish.Text));

                    if (cbSupervisor.Enabled == true) 
                    {
                        cmd.Parameters.Add("supid", cbSupervisor.SelectedItem.ToString());
                    }
                    else
                    {                     
                        cmd.Parameters.Add("supid", null);
                    }

                    if (txtClientName.Enabled == true)
                    {
                        cmd.Parameters.Add("clientname", txtClientName.Text);
                    }
                    else
                    {
                        cmd.Parameters.Add("clientname", null);
                    }


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
                    populateMeetingsGrid(this.grdMeetings);

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;

                    //Enable other buttons
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;

                    //Clear textboxes/fields
                    cbTeamID.SelectedIndex = -1;
                    cbUnitID.SelectedIndex = -1;
                    cbSemester.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;
                    txtMeetID.Clear();

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

                if (cbSupervisor.Enabled == true)
                {
                    cmd.Parameters.Add("supid", cbSupervisor.SelectedItem.ToString());
                }
                else
                {
                    cmd.Parameters.Add("supid", null);
                }

                if (txtClientName.Enabled == true)
                {
                    cmd.Parameters.Add("clientname", txtClientName.Text);
                }
                else
                {
                    cmd.Parameters.Add("clientname", null);
                }

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                //Repopulate data
                getMeetings();

                populateMeetingsGrid(this.grdMeetings);

                btnEdit.Text = "Edit";

                //Enable Buttons and grid

                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                grdMeetings.Enabled = true;

                //Clear textboxes/fields
                cbTeamID.SelectedIndex = -1;
                cbUnitID.SelectedIndex = -1;
                cbSemester.SelectedIndex = -1;
                cbYear.SelectedIndex = -1;
                txtMeetID.Clear();

                /*        cbMeetingType.SelectedIndex = -1;
                    //Need to set dates back to today
                            cbSupervisor.SelectedIndex = -1;
                            txtClientName.Clear();
                            txtMeetingMinutes.Clear();
                */

                //Enable/disable
                gbDetails.Enabled = false;
                cbUnitID.Enabled = true;
               // gbIdentifyingInformation.Enabled = true;
            }
            else
            {
                btnEdit.Text = "Save?";

                grdMeetings.Enabled = false;

                //disable buttons
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                int selectedrow = grdMeetings.SelectedCells[0].RowIndex;

                txtMeetID.Text = grdMeetings.Rows[selectedrow].Cells[0].Value.ToString();
                //if (cbTeamID.Items.Count != 0)
                //    cbTeamID.SelectedIndex = -1;
               // MessageBox.Show(cbTeamID.SelectedItem.ToString() + " == " + grdMeetings.Rows[selectedrow].Cells[1].Value.ToString());

               
                cbUnitID.SelectedItem = grdMeetings.Rows[selectedrow].Cells[2].Value.ToString();
                cbSemester.SelectedItem = grdMeetings.Rows[selectedrow].Cells[3].Value.ToString();
                cbYear.SelectedItem = grdMeetings.Rows[selectedrow].Cells[4].Value.ToString();
                cbTeamID.SelectedItem = grdMeetings.Rows[selectedrow].Cells[1].Value.ToString();

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
                        cbSupervisor.SelectedItem = items[9].ToString();
                        txtClientName.Text = items[10].ToString();
                       
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
            populateMeetingsGrid(this.grdMeetings);
        }

#endregion 

        private bool FormValidated()
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
            //txtStart.Enabled = true;
            //txtFinish.Enabled = true;
            dtStartTime.Enabled = true;
            dtFinishTime.Enabled = true;
            txtMeetingMinutes.Enabled = true;

            if (cbMeetingType.SelectedItem.ToString() == "Supervisor")
            {
                cbSupervisor.Enabled = true;
                cbSupervisor.SelectedIndex = -1;

                txtClientName.Enabled = false;

                int rowcnt = teams.Tables["teamcursor"].Rows.Count;
                object team = new object();


                for (int i = 0; i <= rowcnt - 1; i++)
                {
                    if (teams.Tables[0].Rows[i][2].ToString() == cbUnitID.SelectedItem.ToString() && teams.Tables[0].Rows[i][3].ToString() == cbSemester.SelectedItem.ToString() && teams.Tables[0].Rows[i][4].ToString() == cbYear.SelectedItem.ToString() && teams.Tables[0].Rows[i][0].ToString() == cbTeamID.SelectedItem.ToString())
                    {
                        team = teams.Tables["teamcursor"].Rows[i][5].ToString();

                        //only note one option for supervisor once per instance
                        if (!cbSupervisor.Items.Contains(team))
                            cbSupervisor.Items.Add(team);

                        //sort the list numerically/alphabetically
                        cbSupervisor.Sorted = true;
                    }
                    else
                    {
                        continue;
                    }

                }
            }

            if (cbMeetingType.SelectedItem.ToString() == "Client")
            {
                txtClientName.Enabled = true;
                cbSupervisor.Enabled = false;
                cbSupervisor.SelectedIndex = -1;
            }

            if (cbMeetingType.SelectedItem.ToString() == "Student")
            {
                txtClientName.Enabled = false;
                cbSupervisor.Enabled = false;
            }

            //Populate the combo box from the dataset
            int rowcount = stuteamallo.Tables["stuteamcursor"].Rows.Count;
            object attendees = new object();

            for (int i = 0; i <= rowcount - 1; i++)
            {
                if (stuteamallo.Tables[0].Rows[i][0].ToString() == cbTeamID.SelectedItem.ToString()) 
                    {
                     attendees = teams.Tables["stuteamcursor"].Rows[i][1].ToString();
                     clbAttendees.Items.Add(attendees.ToString());
                }
            } 
        }

        #endregion

    


        #region ChildForms



        #endregion

 

    }
}
