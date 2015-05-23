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
            connection = conn.oraConn();

            _parent = parent;
            MeetingID = meetingID;
            TeamID = teamID;
            UnitID = unitID;
            Semester = semester;
            Year = year;

            
        }

        private void frmActionItems_Load(object sender, EventArgs e)
        {
            getActionItems();
            getStudentTeamAllocations();

            populateActionsGrid();
        }

        private void getActionItems()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC3_14_View_ActionItem", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("actioncursor", OracleDbType.RefCursor);
            cmd.Parameters["actioncursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("meetid", Convert.ToInt16(MeetingID));
            cmd.Parameters.Add("teamid", TeamID);
            cmd.Parameters.Add("unitid", Convert.ToInt16(UnitID));
            cmd.Parameters.Add("semester", Convert.ToInt16(Semester));
            cmd.Parameters.Add("year", Convert.ToInt16(Year));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            actions = new DataSet();

            da.Fill(actions, "actioncursor", (OracleRefCursor)(cmd.Parameters["actioncursor"].Value));

            connection.Close();
        }

        private void getStudentTeamAllocations()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_18_View_Team_Allo", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("stuteamcursor", OracleDbType.RefCursor);
            cmd.Parameters["stuteamcursor"].Direction = ParameterDirection.ReturnValue;
//DELETE           // int selectedRow = grdMeetings.SelectedCells[0].RowIndex;
            cmd.Parameters.Add("teamid",TeamID);
            cmd.Parameters.Add("unitid", Convert.ToInt16(UnitID));
            cmd.Parameters.Add("semester", Convert.ToInt16(Semester));
            cmd.Parameters.Add("year", Convert.ToInt16(Year));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            stuteamallo = new DataSet();

            da.Fill(stuteamallo, "stuteamcursor", (OracleRefCursor)(cmd.Parameters["stuteamcursor"].Value));

            connection.Close();
        }


        private void populateActionsGrid()
        {
            //Clear the grid
            grdActionItems.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = actions.Tables[0].Rows.Count;
           

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = actions.Tables[0].Rows[i].ItemArray;
                grdActionItems.Rows.Add(new object[] { items[5], items[7], items[8], items[9] });
            }
        }

        private void populateStudents()
        {
            cbStuID.Items.Clear();

            int rowcnt = stuteamallo.Tables[0].Rows.Count;
            object student = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                student = stuteamallo.Tables["stuteamcursor"].Rows[i][1].ToString();


                if (!cbStuID.Items.Contains(student.ToString()))
                    cbStuID.Items.Add(student.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


      

    }
}
