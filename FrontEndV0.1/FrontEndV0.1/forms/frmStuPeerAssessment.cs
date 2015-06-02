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

        private string _assid;
        private string _unitid;
        private string _team;
        private int _sem;
        private int _year;

        public frmStuPeerAssessment(string assid, string unitid, int sem, int year, string team)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _assid = assid;
            _unitid = unitid;
            _sem = sem;
            _year = year;
            _team = team;

            getCriterion();
            populateCriterion();

            //getRatings();
            //populateRatings();
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
                grdAspects.Rows.Add(new object[] {items[1], items[8]});
            }
        }

        private void getRatings()
        {
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
        }

        private void populateRatings()
        {
            grdStudentRatings.Rows.Clear();

            int rowcnt = ratings.Tables["ratingcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = ratings.Tables[0].Rows[i].ItemArray;
                grdStudentRatings.Rows.Add(new object[] { items[0], items[5] });
            }
        }
    }
}
