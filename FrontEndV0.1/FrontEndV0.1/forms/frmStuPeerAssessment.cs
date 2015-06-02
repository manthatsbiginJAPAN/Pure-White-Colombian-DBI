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
    public partial class frmStuPeerAssessment : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        private DataSet criterion;
        private DataSet ratings;
        private DataSet teams;

        private string _assid;
        private string _unitid;
        private string _team;
        private int _sem;
        private int _year;
        private string _user;

        public frmStuPeerAssessment(string assid, string unitid, int sem, int year, string team, string user)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _assid = assid;
            _unitid = unitid;
            _sem = sem;
            _year = year;
            _team = team;
            _user = user;

            getCriterion();
            populateCriterion();
            
        }

        private void getCriterion()
        {
            OracleCommand cmd = new OracleCommand("UC2_27_View_AssCrit", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("critcursor", OracleDbType.RefCursor);
            cmd.Parameters["critcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("assid", _assid);
            cmd.Parameters.Add("unitid", _unitid);
            cmd.Parameters.Add("sem", _sem);
            cmd.Parameters.Add("year", _year);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            criterion = new DataSet();

            da.Fill(criterion, "critcursor", (OracleRefCursor)(cmd.Parameters["critcursor"].Value));

            connection.Close();
        }

        private void populateCriterion()
        {
            grdAspects.Rows.Clear();

            int rowcnt = criterion.Tables["critcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = criterion.Tables[0].Rows[i].ItemArray;
                grdAspects.Rows.Add(new object[] { items[0], items[5], items[6]});
            }
        }

        private void getRatings()
        {
            grdStudentRatings.Rows.Clear();
            getTeam();

            OracleCommand cmd = new OracleCommand("UC2_35_View_StuRatings", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("ratingcursor", OracleDbType.RefCursor);
            cmd.Parameters["ratingcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("assid", _assid);
            cmd.Parameters.Add("criterionid", grdAspects.Rows[grdAspects.SelectedRows[0].Index].Cells[0].Value.ToString());
            cmd.Parameters.Add("unitid", _unitid);
            cmd.Parameters.Add("sem", _sem);
            cmd.Parameters.Add("year", _year);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            ratings = new DataSet();

            da.Fill(ratings, "ratingcursor", (OracleRefCursor)(cmd.Parameters["ratingcursor"].Value));

            connection.Close();

            int rowcnt = ratings.Tables["ratingcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = ratings.Tables[0].Rows[i].ItemArray;
                grdStudentRatings.Rows[i].Cells[2].Value = items[8];
            }
        }

        private void getTeam()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();

            OracleCommand cmd = new OracleCommand("UC2_18_VIEW_TEAM_ALLO", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("teamcursor", OracleDbType.RefCursor);
            cmd.Parameters["teamcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("teamid", _team);
            cmd.Parameters.Add("unitid", _unitid);
            cmd.Parameters.Add("sem", _sem);
            cmd.Parameters.Add("year", _year);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teams = new DataSet();

            da.Fill(teams, "teamcursor", (OracleRefCursor)(cmd.Parameters["teamcursor"].Value));

            connection.Close();

            for (int i = 0; i < teams.Tables["teamcursor"].Rows.Count; i++)
            {
                object[] items = teams.Tables[0].Rows[i].ItemArray;
                grdStudentRatings.Rows.Add(new object[] { items[0], items[1] + " " + items[2] });
            }
        }

        private void grdAspects_SelectionChanged(object sender, EventArgs e)
        {
            getRatings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < grdStudentRatings.Rows.Count; i++)
                {

                    OracleCommand cmd = new OracleCommand("UC2_33_REGISTER_STURATINGS", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("critid", grdAspects.Rows[grdAspects.SelectedRows[0].Index].Cells[0].Value.ToString());
                    cmd.Parameters.Add("stuid", _user);
                    cmd.Parameters.Add("assid", _assid);
                    cmd.Parameters.Add("unitid", _unitid);
                    cmd.Parameters.Add("sem", _sem);
                    cmd.Parameters.Add("year", _year);
                    cmd.Parameters.Add("teamid", _team);
                    cmd.Parameters.Add("targetstuid", grdStudentRatings.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.Add("rating", Convert.ToInt32(grdStudentRatings.Rows[i].Cells[2].Value));
                    cmd.Parameters.Add("datesubmitted", DateTime.Now.ToString("dd/MMM/yyyy"));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Submission already made for this assignment");
            }
        }
    }
}
