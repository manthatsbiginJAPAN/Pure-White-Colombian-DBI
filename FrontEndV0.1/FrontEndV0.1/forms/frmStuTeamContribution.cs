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
    public partial class frmStuTeamContribution : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        private DataSet tasks;
        private DataSet periods;
        private DataSet hours;
        private DataSet teams;

        private string _assid;
        private string _unitid;
        private string _team;
        private int _sem;
        private int _year;


        public frmStuTeamContribution(string assid, string unitid, int sem, int year, string team)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _assid = assid;
            _unitid = unitid;
            _sem = sem;
            _year = year;
            _team = team;

            getTasks();
            populateTasks();
        }

        private void getTasks()
        {
            OracleCommand cmd = new OracleCommand("UC2_23_VIEW_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("taskcursor", OracleDbType.RefCursor);
            cmd.Parameters["taskcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("assid", _assid);
            cmd.Parameters.Add("unitid", _unitid);
            cmd.Parameters.Add("sem", _sem);
            cmd.Parameters.Add("year", _year);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            tasks = new DataSet();

            da.Fill(tasks, "taskcursor", (OracleRefCursor)(cmd.Parameters["taskcursor"].Value));

            connection.Close();
        }

        private void populateTasks()
        {
            grdTasks.Rows.Clear();

            int rowcnt = tasks.Tables["taskcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = tasks.Tables[0].Rows[i].ItemArray;
                grdTasks.Rows.Add(new object[] { items[0], items[5] });
            }
        }

        private void grdTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();

            OracleCommand cmd = new OracleCommand("UC2_39_VIEW_TASK_PERIOD", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("percursor", OracleDbType.RefCursor);
            cmd.Parameters["percursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("assid", _assid);
            cmd.Parameters.Add("taskid", grdTasks.Rows[grdTasks.SelectedRows[0].Index].Cells[0].Value.ToString());
            cmd.Parameters.Add("unitid", _unitid);
            cmd.Parameters.Add("sem", _sem);
            cmd.Parameters.Add("year", _year);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            periods = new DataSet();

            da.Fill(periods, "percursor", (OracleRefCursor)(cmd.Parameters["percursor"].Value));

            connection.Close();

            grdPeriods.Rows.Clear();
            grdStudentHours.Rows.Clear();

            int rowcnt = periods.Tables["percursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = periods.Tables[0].Rows[i].ItemArray;
                grdPeriods.Rows.Add(new object[] { items[0], items[6] });
            }

        }

        private void grdPeriods_SelectionChanged(object sender, EventArgs e)
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
            
            grdStudentHours.Rows.Clear();

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;

            //if (grdPeriods.SelectedRows.Count != 0)
            //{
            //    getStuHours();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = teams.Tables[0].Rows[i].ItemArray;
                grdStudentHours.Rows.Add(new object[] { items[0], items[1] + " " + items[2]});
            }
            //}
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= grdStudentHours.Rows.Count - 1; i++)
            {
                OracleCommand cmd = new OracleCommand("UC2_29_REGISTER_STUHOURS", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("period", Convert.ToInt32(grdPeriods.Rows[grdPeriods.SelectedRows[0].Index].Cells[0].Value));
                cmd.Parameters.Add("taskid", grdTasks.Rows[grdTasks.SelectedRows[0].Index].Cells[0].Value.ToString());
                cmd.Parameters.Add("stuid", grdStudentHours.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.Add("assid", _assid);
                cmd.Parameters.Add("unitid", _unitid);
                cmd.Parameters.Add("sem", _sem);
                cmd.Parameters.Add("year", _year);
                cmd.Parameters.Add("team", _team);
                cmd.Parameters.Add("hours", Convert.ToInt32(grdStudentHours.Rows[i].Cells[2].Value));
                cmd.Parameters.Add("datesubmitted", DateTime.Now.ToString("dd/MMM/yyyy"));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void getStuHours()
        {
            OracleCommand cmd = new OracleCommand("UC2_31_View_StuHours", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("hourcursor", OracleDbType.RefCursor);
            cmd.Parameters["hourcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("period", grdPeriods.Rows[grdPeriods.SelectedRows[0].Index].Cells[0].Value.ToString());
            cmd.Parameters.Add("taskid", grdTasks.Rows[grdTasks.SelectedRows[0].Index].Cells[0].Value.ToString());
            cmd.Parameters.Add("assID", _assid);
            cmd.Parameters.Add("unitid", _unitid);
            cmd.Parameters.Add("sem", _sem);
            cmd.Parameters.Add("year", _year);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teams = new DataSet();

            da.Fill(hours, "hourcursor", (OracleRefCursor)(cmd.Parameters["hourcursor"].Value));

            connection.Close();
        }*/

    }
}
