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
    public partial class frmStuAssessment : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private string _user;
        private bool _isConvenor;

        private DataSet enrolment;
        private DataSet assignments = null;
        private DataSet teams;
        private DataSet ds;

        private frmStuTeamContribution frmStuTeamCont;
        private frmStuPeerAssessment frmStuPeerAss;

        public frmStuAssessment(string user, bool isConvenor)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _user = user;
            _isConvenor = isConvenor;

            getEnrolment();
            getAssessments();
            //fillAssessments();
            populateAssGrid(grdAssessments);
            if (_isConvenor)
            {
                _user = getStudent();
            }
        }

        private string getStudent()
        {
            string student = "s7663285";
            return student;
        }

        private void getEnrolment()
        {
            OracleCommand cmd = new OracleCommand("UC1_15_View_Enrolment_Ind_Test", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("enrcursor", OracleDbType.RefCursor);
            cmd.Parameters["enrcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("stuid", _user);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            enrolment = new DataSet();

            da.Fill(enrolment, "enrcursor", (OracleRefCursor)(cmd.Parameters["enrcursor"].Value));

            connection.Close();
        }

        private void getAssessments()
        {
            OracleCommand cmd = new OracleCommand("UC2_11_VIEW_ASSESSMENT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("asscursor", OracleDbType.RefCursor);
            cmd.Parameters["asscursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("user", _user);
            string role = "student";
            if (_isConvenor)
                role = "convenor";
            cmd.Parameters.Add("role", role);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            ds = new DataSet();

            da.Fill(ds, "asscursor", (OracleRefCursor)(cmd.Parameters["asscursor"].Value));

            connection.Close();
        }

        public void populateAssGrid(DataGridView thegrid)
        {
            //Empty the grid
            thegrid.Rows.Clear();

            //Populate grid
            int rowcnt = ds.Tables["asscursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = ds.Tables[0].Rows[i].ItemArray;
                thegrid.Rows.Add(new object[] { items[0], items[3], items[4], items[5] });
            }
        }

        private void fillAssessments()
        {
            for (int x = 0; x < enrolment.Tables[0].Rows.Count - 1; x++)
            {
                for (int y = 0; y < assignments.Tables[0].Rows.Count - 1; y++)
                {
                    if (assignments.Tables[0].Rows[y][3].Equals(enrolment.Tables[0].Rows[x][1])
                        && assignments.Tables[0].Rows[y][4].Equals(enrolment.Tables[0].Rows[x][2])
                        && assignments.Tables[0].Rows[y][5].Equals(enrolment.Tables[0].Rows[x][3]))
                    {
                        object[] items = assignments.Tables[0].Rows[y].ItemArray;
                        grdAssessments.Rows.Add(new object[] { items[0], items[3], items[4], items[5] });
                    }
                }
            }
        }

        private void grdAssessments_SelectionChanged(object sender, EventArgs e)
        {
            if (assignments == null)
            {
                return;
            }
            for (int i = 0; i < assignments.Tables[0].Rows.Count - 1; i++)
            {
                if ( assignments.Tables[0].Rows[i][0].Equals(grdAssessments.SelectedRows[0].Cells[0].Value)
                    && assignments.Tables[0].Rows[i][3].Equals(grdAssessments.SelectedRows[0].Cells[1].Value)
                    && assignments.Tables[0].Rows[i][4].Equals(grdAssessments.SelectedRows[0].Cells[2].Value)
                    && assignments.Tables[0].Rows[i][5].Equals(grdAssessments.SelectedRows[0].Cells[3].Value) )
                {
                    txtTitle.Text = assignments.Tables[0].Rows[i][1].ToString();
                    txtDesc.Text = assignments.Tables[0].Rows[i][2].ToString();
                    txtMarkingGuide.Text = assignments.Tables[0].Rows[i][6].ToString();
                    break;
                }
            }
        }

        private String getTeam()
        {
            string team = "";
            
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_3_View_Team", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("teamcursor", OracleDbType.RefCursor);
            cmd.Parameters["teamcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("user", _user);
            cmd.Parameters.Add("role", "student");

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teams = new DataSet();

            da.Fill(teams, "teamcursor", (OracleRefCursor)(cmd.Parameters["teamcursor"].Value));

            connection.Close();

            int max = teams.Tables["teamcursor"].Rows.Count;
            for (int i = 0; i < max; i++)
            {
                for (int x = 0; x < grdAssessments.Rows.Count; x++)
                    if (teams.Tables["teamcursor"].Rows[i].ItemArray[2].Equals(grdAssessments.CurrentRow.Cells[1].Value) && teams.Tables["teamcursor"].Rows[i].ItemArray[3].Equals(grdAssessments.CurrentRow.Cells[2].Value) && teams.Tables["teamcursor"].Rows[i].ItemArray[4].Equals(grdAssessments.CurrentRow.Cells[3].Value))
                {
                    team = teams.Tables["teamcursor"].Rows[i].ItemArray[0].ToString();
                }
            }
            return team;
        }

        private void btnPeerAssessment_Click(object sender, EventArgs e)
        {
            if (grdAssessments.SelectedRows.Count == 0)
                return;

            frmStuTeamCont = new frmStuTeamContribution
                ( Convert.ToString(grdAssessments.SelectedRows[0].Cells[0].Value)
                , Convert.ToString(grdAssessments.SelectedRows[0].Cells[1].Value)
                , Convert.ToInt32(grdAssessments.SelectedRows[0].Cells[2].Value)
                , Convert.ToInt32(grdAssessments.SelectedRows[0].Cells[3].Value) 
                , getTeam());
            frmStuTeamCont.Show();
        }

        private void btnTeamContribution_Click(object sender, EventArgs e)
        {
            if (grdAssessments.SelectedRows.Count == 0)
                return;

            frmStuPeerAss = new frmStuPeerAssessment
                (Convert.ToString(grdAssessments.SelectedRows[0].Cells[0].Value)
                , Convert.ToString(grdAssessments.SelectedRows[0].Cells[1].Value)
                , Convert.ToInt32(grdAssessments.SelectedRows[0].Cells[2].Value)
                , Convert.ToInt32(grdAssessments.SelectedRows[0].Cells[3].Value)
                , getTeam()
                , _user);
            frmStuPeerAss.Show();
        }   

    }
}
