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
       // private DataSet emps;

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
         //   getEmps();

            //Prepare and display data
            populateTeams();
            populateMeetingsGrid();
          //  populateSupervisors();
            
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

        /* DONT NEED I THINK
         * private void getEmps()
         {
             //Oracle Command to populate the dataset
             OracleCommand cmd = new OracleCommand("UC1_26_View_Employee_Role", connection);
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.Add("empcursor", OracleDbType.RefCursor);
             cmd.Parameters["empcursor"].Direction = ParameterDirection.ReturnValue;

             connection.Open();
             OracleDataAdapter da = new OracleDataAdapter(cmd);
             cmd.ExecuteNonQuery();

             emps = new DataSet();

             da.Fill(emps, "empcursor", (OracleRefCursor)(cmd.Parameters["empcursor"].Value));

             connection.Close();
         } */

        #endregion

        #region populateWithData
        /* DON'T NEED THIS EITHER
      * private void populateSupervisors()
        {
            //Clear the grid but add a blank/null option
            cbSupervisor.Items.Clear();
            //DataRow nullrow = null;
            cbSupervisor.Items.Insert(0, "[None]");

            //Populate the grid from the dataset
            int rowcnt = emps.Tables["empcursor"].Rows.Count;
           // MessageBox.Show("Available Supervisors: " + rowcnt.ToString());
            object sup;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //add only employees who are listed as convenors
                if (emps.Tables[0].Rows[i][1].ToString() == "Supervisor")
                {
                    sup = emps.Tables["empcursor"].Rows[i][0].ToString();
                    cbSupervisor.Items.Add(sup);
                }
            }
        } */

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

        private void populateMeetingsGrid()
        {
            //Clear the grid
          //  grdMeetings.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = meets.Tables["meetcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = meets.Tables[0].Rows[i].ItemArray;
                grdMeetings.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4] });
            }
            
        }

        #endregion

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

                    cmd.Parameters.Add("teamid", cbTeamID.SelectedItem.ToString());
                    cmd.Parameters.Add("meetingid", txtMeetID.Text);
                    cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
                    cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem.ToString()));
                    cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem.ToString()));
                    cmd.Parameters.Add("meettype", cbMeetingType.SelectedItem.ToString());
                    cmd.Parameters.Add("starttime", Convert.ToDateTime(txtStart.Text));
                    cmd.Parameters.Add("finishtime", Convert.ToDateTime(txtFinish.Text));
                    cmd.Parameters.Add("supid", cbSupervisor.SelectedItem.ToString());
                    cmd.Parameters.Add("clientname", txtClientName.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Dataset then Grid
                    getMeetings();
                    populateMeetingsGrid();

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;

                    //Enable other buttons
                    btnDelete.Enabled = true;

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

        private void cbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnitID.SelectedIndex != -1)
                cbSemester.Enabled = true;

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;
            object sem = new object();
            cbSemester.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
                if (teams.Tables[0].Rows[i][0].ToString() == cbUnitID.SelectedItem.ToString())
                {
                    sem = teams.Tables["teamcursor"].Rows[i][1].ToString();

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

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;
            object year = new object();
            cbYear.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the years where the semester matches the selected one
                if (teams.Tables[0].Rows[i][0].ToString() == cbUnitID.SelectedItem.ToString() && teams.Tables[0].Rows[i][1].ToString() == cbSemester.SelectedItem.ToString())
                {
                    year = teams.Tables["teamcursor"].Rows[i][2].ToString();

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

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;
            object team = new object();
            cbYear.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
 //FIX               if (tms.Tables[0].Rows[i][0].ToString() == cbUnitID.SelectedItem.ToString() && tms.Tables[0].Rows[i][1].ToString() == cbSemester.SelectedItem.ToString() && tms.Tables[0].Rows[i][2].ToString() == cbYear.SelectedItem.ToString())
                {
                    team = teams.Tables["teamcursor"].Rows[i][3].ToString();

                    //only note one option for semesters once per instance
                    if (!cbTeamID.Items.Contains(team))
                        cbTeamID.Items.Add(team);

                    //sort the list numerically/alphabetically
                    cbTeamID.Sorted = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
