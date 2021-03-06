﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace FrontEndV0._1.forms
{
    public partial class frmReports : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet units;
        private DataSet unitoffs;
        private DataSet unitoffs2;
        private DataSet enrols;
        private DataSet emproles;
        private DataSet projects;
        private DataSet teams;
        private DataSet teamallocs;
        private string User;
        private bool IsAdmin;

        public frmReports(string user, bool isAdmin)
        {
            InitializeComponent();
            IsAdmin = isAdmin;
            User = user;
            connection = conn.oraConn();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            getUnitOfferings();
            populatecbUnitID();
        }

        #region getdata
        private void getUnits()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_7_View_Unit", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitcursor", OracleDbType.RefCursor);
            cmd.Parameters["unitcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            units = new DataSet();

            da.Fill(units, "unitcursor", (OracleRefCursor)(cmd.Parameters["unitcursor"].Value));

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
            string role;
            if (IsAdmin)
                role = "admin";
            else
                role = "convenor";
            cmd.Parameters.Add("role", role);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            unitoffs = new DataSet();

            da.Fill(unitoffs, "unitoffcursor", (OracleRefCursor)(cmd.Parameters["unitoffcursor"].Value));

            connection.Close();
        }

        private void getThisUnitOfferings(string unitid)
        {
          //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC4_1_View_Unit_Offering", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitoffcursor2", OracleDbType.RefCursor);
            cmd.Parameters["unitoffcursor2"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("unit", unitid);
            cmd.Parameters.Add("user", User);
            string role;
            if (IsAdmin)
                role = "admin";
            else
                role = "convenor";
            cmd.Parameters.Add("role", role);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            unitoffs2 = new DataSet();

            da.Fill(unitoffs2, "unitoffcursor2", (OracleRefCursor)(cmd.Parameters["unitoffcursor2"].Value));

            connection.Close(); 
        }

        private void getEnrolments(string unitid, string semester, string year)
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC4_2_View_Enrolment ", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("enrolcursor", OracleDbType.RefCursor);
            cmd.Parameters["enrolcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("unit", unitid);
            cmd.Parameters.Add("semester", Convert.ToInt16(semester));
            cmd.Parameters.Add("year", Convert.ToInt16(year));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            enrols = new DataSet();

            da.Fill(enrols, "enrolcursor", (OracleRefCursor)(cmd.Parameters["enrolcursor"].Value));

            connection.Close();
        }

        private void getEmployeeRoles()
        {
            OracleCommand cmd = new OracleCommand("UC4_3_View_EmpRole_Sup ", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("emprolecursor", OracleDbType.RefCursor);
            cmd.Parameters["emprolecursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            emproles = new DataSet();

            da.Fill(emproles, "emprolecursor", (OracleRefCursor)(cmd.Parameters["emprolecursor"].Value));

            connection.Close();
        }

        private void getProjects()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC4_4_View_Project", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("projcursor", OracleDbType.RefCursor);
            cmd.Parameters["projcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            projects = new DataSet();

            da.Fill(projects, "projcursor", (OracleRefCursor)(cmd.Parameters["projcursor"].Value));

            connection.Close();
        }

        private void getTeams()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_3_View_Team_2", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("teamcursor", OracleDbType.RefCursor);
            cmd.Parameters["teamcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
            cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem.ToString()));
            cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem.ToString()));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teams = new DataSet();

            da.Fill(teams, "teamcursor", (OracleRefCursor)(cmd.Parameters["teamcursor"].Value));

            connection.Close();
        }

        private void getTeamAlloc(string teamID)
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_18_View_Team_Allo", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("talloccursor", OracleDbType.RefCursor);
            cmd.Parameters["talloccursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("teamid", teamID);
            cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
            cmd.Parameters.Add("semester", Convert.ToInt16(cbSemester.SelectedItem.ToString()));
            cmd.Parameters.Add("year", Convert.ToInt16(cbYear.SelectedItem.ToString()));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teamallocs = new DataSet();

            da.Fill(teamallocs, "talloccursor", (OracleRefCursor)(cmd.Parameters["talloccursor"].Value));

            connection.Close();
        }

#endregion

        private void populatecbUnitID()
        {
            //Clear boxes
            cbUnitID.Items.Clear();

            //Populate the boxes from the dataset
            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object unitid = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                unitid = unitoffs.Tables[0].Rows[i][0].ToString();

                if (!cbUnitID.Items.Contains(unitid.ToString()))
                    cbUnitID.Items.Add(unitid.ToString());
            }
        }

        private void btnConUnitReport_Click(object sender, EventArgs e)
        {
            txtReportDisplay.Clear();
            getUnits();

            txtReportDisplay.Text = "******** List of Units, Unit Offerings and Convenors: *********" + Environment.NewLine;

            int unitrowcnt = units.Tables["unitcursor"].Rows.Count;
            string unitid = "";
            string unitname = "";

            for (int i = 0; i < unitrowcnt; i++)
            {
                unitid = units.Tables["unitcursor"].Rows[i][0].ToString();
                unitname = units.Tables["unitcursor"].Rows[i][1].ToString();

                //populate textbox
                txtReportDisplay.Text += System.Environment.NewLine + unitid + " " + unitname;
                getThisUnitOfferings(unitid);

                int offrowcnt = unitoffs2.Tables["unitoffcursor2"].Rows.Count;
                for (int j = 0; j < offrowcnt; j++)
                {

                    string sem = unitoffs2.Tables[0].Rows[j][0].ToString();
                    string year = unitoffs2.Tables[0].Rows[j][1].ToString();
                    string confirstname = unitoffs2.Tables[0].Rows[j][2].ToString();
                    string conlastname = unitoffs2.Tables[0].Rows[j][3].ToString();

                    txtReportDisplay.Text += System.Environment.NewLine + "     " + sem + " " + year + " " + confirstname + " " + conlastname;
                }
            }
            txtReportDisplay.Text += Environment.NewLine + Environment.NewLine;
            txtReportDisplay.Text += "******************* End of List ********************";
        }

       

        private void btnEnrolmentReport_Click(object sender, EventArgs e)
        {
            if (cbValidated())
                {
                  txtReportDisplay.Clear();
                   string pUnitId = null, pSemester = null, pYear = null;
                   pUnitId = cbUnitID.SelectedItem.ToString();
                   pSemester = cbSemester.SelectedItem.ToString();
                   pYear = cbYear.SelectedItem.ToString();

              /*  //validate selections
                if (cbUnitID.SelectedIndex == -1)
                    MessageBox.Show("Please select a UnitID");
                else
                    pUnitId = cbUnitID.SelectedItem.ToString();

                if (cbSemester.SelectedIndex == -1)
                    MessageBox.Show("Please select a Semester");
                else
                    pSemester = cbSemester.SelectedItem.ToString();

                if (cbYear.SelectedIndex == -1)
                    MessageBox.Show("Please select a Year");
                else
                    pYear = cbYear.SelectedItem.ToString(); */

                   getEnrolments(pUnitId, pSemester, pYear);

                txtReportDisplay.Text = "******* List of Enrolled Students in: " + pUnitId + " *******" + Environment.NewLine +  "******* Semester: "+ pSemester + ", Year: " + pYear + " *********" + Environment.NewLine;

                int enrowcnt = enrols.Tables["enrolcursor"].Rows.Count;
                for (int i = 0; i < enrowcnt; i++)
                {
                    string stufirstname = enrols.Tables["enrolcursor"].Rows[i][0].ToString();
                    string stulastname = enrols.Tables["enrolcursor"].Rows[i][1].ToString();

                    //populate textbox
                    txtReportDisplay.Text += System.Environment.NewLine + stufirstname + " " + stulastname;
                }

            }
        }

        private bool cbValidated() 
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            //validate selections
            if (cbUnitID.SelectedIndex == -1)
                ErrorMsg += Environment.NewLine + "Please select a Unit ID.";
            if (cbSemester.SelectedIndex == -1)
               ErrorMsg += Environment.NewLine + "Please select a Semester.";
            if (cbYear.SelectedItem == null)
                ErrorMsg += Environment.NewLine + "Please select a Year.";


            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Cannot Display",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSupervisorReport_Click(object sender, EventArgs e)
        {
            txtReportDisplay.Clear();
            txtReportDisplay.Text = "********* List of Supervisors *********" + Environment.NewLine;

            getEmployeeRoles();
            int enrowcnt = emproles.Tables["emprolecursor"].Rows.Count;
            for (int i = 0; i < enrowcnt; i++)
            {
                string supfirstname = emproles.Tables["emprolecursor"].Rows[i][0].ToString();
                string suplastname = emproles.Tables["emprolecursor"].Rows[i][1].ToString();

                //populate textbox
                txtReportDisplay.Text += System.Environment.NewLine + supfirstname + " " + suplastname;
            }
        }

        private void btnProjectReport_Click(object sender, EventArgs e)
        {
            txtReportDisplay.Clear();

            getProjects();

            txtReportDisplay.Text = "********* List of Projects *********" + Environment.NewLine;

            int enrowcnt = projects.Tables["projcursor"].Rows.Count;
            for (int i = 0; i < enrowcnt; i++)
            {
                string projid = projects.Tables["projcursor"].Rows[i][0].ToString();
                string projname = projects.Tables["projcursor"].Rows[i][1].ToString();

                //populate textbox
                txtReportDisplay.Text += System.Environment.NewLine + projid + " " + projname;
            }
        }

#region selectionchanged
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

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

#endregion

        private void btnTeamDetails_Click(object sender, EventArgs e)
        {
            if (cbValidated())
            {
                txtReportDisplay.Clear();
                txtReportDisplay.Text = "********* List of Teams and Members *********" + Environment.NewLine;
                txtReportDisplay.Text += "     for " + cbUnitID.SelectedItem.ToString() + ", Semester "
                    + cbSemester.SelectedItem.ToString() + ", " + cbYear.SelectedItem.ToString() + Environment.NewLine + Environment.NewLine;
                
                getTeams();
                int rowcount = teams.Tables[0].Rows.Count;
                object team = new object();
                object firstname = new object();
                object surname = new object();
                string tab = "     ";

                for (int i = 0; i < rowcount; i++)
                {
                    team = teams.Tables[0].Rows[i][0];
                    txtReportDisplay.Text += tab + team.ToString() + Environment.NewLine;

                    getTeamAlloc(team.ToString());
                    int rowcnt = teamallocs.Tables[0].Rows.Count;
                    for (int j = 0; j < rowcnt; j++)
                    {
                        firstname = teamallocs.Tables[0].Rows[j][1];
                        surname = teamallocs.Tables[0].Rows[j][2];
                        txtReportDisplay.Text += tab + tab + "-" + firstname.ToString() + " " + surname.ToString() + Environment.NewLine;
                    }
                }
                txtReportDisplay.Text += Environment.NewLine + "********* End of List *********";
            }
        }

       


    }
}
