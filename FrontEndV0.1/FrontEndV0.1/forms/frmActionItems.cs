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
            populateStudents();
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
            cmd.Parameters.Add("unitid", UnitID);
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
            cmd.Parameters.Add("teamid",TeamID);
            cmd.Parameters.Add("unitid", UnitID);
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
                cbStuID.Items.Add(student.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Save?")
            {
                //Command to add Unit
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC3_13_Add_ActionItem", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("meetingid", MeetingID);
                    cmd.Parameters.Add("teamid", TeamID);
                    cmd.Parameters.Add("unitid", UnitID);
                    cmd.Parameters.Add("semester", Semester);
                    cmd.Parameters.Add("year", Year);
                    cmd.Parameters.Add("actionnum", Convert.ToInt16(txtActionItem.Text));
                    cmd.Parameters.Add("actiondesc", txtActionDesc.Text);
                    cmd.Parameters.Add("stuid", cbStuID.SelectedItem.ToString());
                    cmd.Parameters.Add("status", cbStatus.SelectedItem.ToString());

                    //Repopulate data
                    getActionItems();
                    populateActionsGrid();

                    //Enable buttons and grid
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    grdActionItems.Enabled = true;
                }
            }
            else
            {
                btnAdd.Text = "Save?";         

                //disable buttons and grid
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                grdActionItems.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Save?")
            {
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC3_15_Update_ActionItem", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("meetingid", MeetingID);
                    cmd.Parameters.Add("teamid", TeamID);
                    cmd.Parameters.Add("unitid", UnitID);
                    cmd.Parameters.Add("semester", Semester);
                    cmd.Parameters.Add("year", Year);
                    cmd.Parameters.Add("actionnum", Convert.ToInt16(txtActionItem.Text));
                    cmd.Parameters.Add("actiondesc", txtActionDesc.Text);
                    cmd.Parameters.Add("stuid", cbStuID.SelectedItem.ToString());
                    cmd.Parameters.Add("status", cbStatus.SelectedItem.ToString());

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate data
                    getActionItems();
                    populateActionsGrid();

                    btnEdit.Text = "Edit";

                    //Enable Buttons and grid

                    btnDelete.Enabled = true;
                    btnAdd.Enabled = true;
                    grdActionItems.Enabled = true;
                }

            }
            else
            {
                btnEdit.Text = "Save?";

                grdActionItems.Enabled = false;

                //disable buttons
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                int selectedrow = grdActionItems.SelectedCells[0].RowIndex;


                gbDetails.Enabled = true;

                int rowcnt = actions.Tables["actioncursor"].Rows.Count;

                for (int i = 0; i <= rowcnt - 1; i++)
                {
                    object[] items = actions.Tables[0].Rows[i].ItemArray;

                    //Checking if selected meeting matches in the dataset
                    if (Convert.ToString(items[5]) == grdActionItems.Rows[selectedrow].Cells[0].Value.ToString())

                    {
                        //Fill form controls with data to be updated

                        txtActionItem.Text = items[5].ToString();
                        txtActionDesc.Text = items[6].ToString();
                        cbStuID.SelectedItem = items[7].ToString();
                       // dtDue.Value = Convert.ToDateTime(items[8]);
                        cbStatus.SelectedItem = items[9].ToString();
                        
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private bool FormValidated() 
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (txtActionItem.Text == null)
                ErrorMsg += Environment.NewLine + "Please enter a Action Number.";
            if (cbStuID.SelectedIndex == -1)
                ErrorMsg += Environment.NewLine + "Please select a Student ID.";
            if (txtActionDesc.Text == null)
                ErrorMsg += Environment.NewLine + "Please enter an Action Description";

            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Action Item information invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
      

    }
}
