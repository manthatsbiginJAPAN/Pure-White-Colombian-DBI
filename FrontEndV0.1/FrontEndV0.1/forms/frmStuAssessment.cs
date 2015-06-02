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
    public partial class frmStuAssessment : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private string _user;

        private DataSet enrolment;
        private DataSet assignments;

        private frmStuTeamContribution frmStuTeamCont;
        private frmStuPeerAssessment frmStuPeerAss;

        public frmStuAssessment(string user)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _user = user;

            getEnrolment();
            getAssessments();
            fillAssessments();
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
            string role = "student"; //used currently for testing
            cmd.Parameters.Add("role", role);
            connection.Open();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            assignments = new DataSet();

            da.Fill(assignments, "asscursor", (OracleRefCursor)(cmd.Parameters["asscursor"].Value));

            connection.Close();
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

        private void btnPeerAssessment_Click(object sender, EventArgs e)
        {
            if (grdAssessments.Rows.Count == 0)
                return;

            frmStuTeamCont = new frmStuTeamContribution
                ( Convert.ToString(grdAssessments.SelectedRows[0].Cells[0].Value)
                , Convert.ToString(grdAssessments.SelectedRows[0].Cells[1].Value)
                , Convert.ToInt32(grdAssessments.SelectedRows[0].Cells[2].Value)
                , Convert.ToInt32(grdAssessments.SelectedRows[0].Cells[3].Value) );
            frmStuTeamCont.Show();
        }

        private void btnTeamContribution_Click(object sender, EventArgs e)
        {
            if (grdAssessments.Rows.Count == 0)
                return;

            frmStuPeerAss = new frmStuPeerAssessment();
            frmStuPeerAss.Show();
        }   

    }
}
