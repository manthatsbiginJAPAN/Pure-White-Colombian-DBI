using System;
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
    public partial class frmActionItems : Form
    {

        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        private DataSet actions;
        private DataSet teams;
        private DataSet stuteamallo;

        private string MeetingID;
        private string TeamID;
        private string UnitID;
        private string Semester;
        private string Year;

        private frmMeeting _parent;

        public frmActionItems(frmMeeting parent, string meetingID, string teamID, string unitID, string semester, string year)
        {
            InitializeComponent();

            _parent = parent;
            MeetingID = meetingID;
            TeamID = teamID;
            UnitID = unitID;
            Semester = semester;
            Year = year;
            
        }

        private void getActionItems()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC3_14_View_ActionItem", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("actioncursor", OracleDbType.RefCursor);
            cmd.Parameters["actioncursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            actions = new DataSet();

            da.Fill(actions, "actioncursor", (OracleRefCursor)(cmd.Parameters["actioncursor"].Value));

            connection.Close();
        }

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
           // int selectedRow = grdMeetings.SelectedCells[0].RowIndex;
         //   cmd.Parameters.Add("teamid", grdMeetings.Rows[selectedRow].Cells[1].Value.ToString());
           // cmd.Parameters.Add("unitid", grdMeetings.Rows[selectedRow].Cells[2].Value.ToString());
          //  cmd.Parameters.Add("semester", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[3].Value));
          //  cmd.Parameters.Add("year", Convert.ToInt16(grdMeetings.Rows[selectedRow].Cells[4].Value));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            stuteamallo = new DataSet();

            da.Fill(stuteamallo, "stuteamcursor", (OracleRefCursor)(cmd.Parameters["stuteamcursor"].Value));

            connection.Close();
        }
        private void frmActionItems_Load(object sender, EventArgs e)
        {
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


      

    }
}
