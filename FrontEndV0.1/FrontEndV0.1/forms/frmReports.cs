using System;
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
            
        }

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
            txtReportDisplay.Clear();
            string pUnitId = cbUnitID.SelectedItem.ToString();
            string pSemester = cbSemester.SelectedItem.ToString();
            string pYear = cbYear.SelectedItem.ToString();

            getEnrolments(pUnitId, pSemester, pYear);

            txtReportDisplay.Text = "** List of Enrolments in:" + pUnitId + "Semester:"+ pSemester + "Year:" + pYear + " **" + Environment.NewLine;

            int enrowcnt = enrols.Tables["enrolcursor"].Rows.Count;
            for (int i = 0; i < enrowcnt; i++)
            {
                string stufirstname = enrols.Tables["enrolcursor"].Rows[i][0].ToString();
                string stulastname = enrols.Tables["enrolcursor"].Rows[i][0].ToString();

                //populate textbox
                txtReportDisplay.Text += System.Environment.NewLine + stufirstname + " " + stulastname;
            }

        }

#region selectionchanged
        private void cbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnitID.SelectedIndex != -1)
                cbSemester.Enabled = true;
            else
                return;

            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object sem = new object();
            cbSemester.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
                if (unitoffs.Tables[0].Rows[i][0].ToString() == cbUnitID.SelectedItem.ToString())
                {
                    sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();

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
            else
                return;

            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object year = new object();
            cbSemester.Items.Clear();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //find the semesters where the unitID matches the selected one
                if (unitoffs.Tables[0].Rows[i][1].ToString() == cbSemester.SelectedItem.ToString())
                {
                    year = unitoffs.Tables["unitoffcursor"].Rows[i][2].ToString();

                    if (!cbSemester.Items.Contains(year))
                        cbSemester.Items.Add(year);

                    //sort the list numerically/alphabetically
                    cbSemester.Sorted = true;
                }
            }
        }
#endregion

    }
}
