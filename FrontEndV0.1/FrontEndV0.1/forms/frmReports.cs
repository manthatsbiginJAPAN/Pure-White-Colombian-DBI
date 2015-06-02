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

        private void getUnitOfferings(string unitid)
        {
          //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC4_1_View_Unit_Offering", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitoffcursor", OracleDbType.RefCursor);
            cmd.Parameters["unitoffcursor"].Direction = ParameterDirection.ReturnValue;
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

            unitoffs = new DataSet();

            da.Fill(unitoffs, "unitoffcursor", (OracleRefCursor)(cmd.Parameters["unitoffcursor"].Value));

            connection.Close(); 
        }

       

        private void btnConUnitReport_Click(object sender, EventArgs e)
        {
            txtReportDisplay.Clear();

            getUnits();

            txtReportDisplay.Text = "******** List of Units: *******";

            int rowcnt = units.Tables["unitcursor"].Rows.Count;
            string unitid = "";
            string unitname = "";

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                unitid = units.Tables["unitcursor"].Rows[i][0].ToString();
                unitname = units.Tables["unitcursor"].Rows[i][1].ToString();

                //populate textbox
                txtReportDisplay.Text += System.Environment.NewLine + unitid + " " + unitname;

                for (int j = 0; j <= rowcnt - j; j++)
                {
                    getUnitOfferings(unitid);

                    int rowcnt2 = unitoffs.Tables["unitoffcursor"].Rows.Count;
                    string sem = "";
                    string year = "";
                    string confirstname = "";
                    string conlastname = "";

                    sem = unitoffs.Tables[0].Rows[j][0].ToString();
                    year = unitoffs.Tables[0].Rows[j][1].ToString();
                    confirstname = unitoffs.Tables[0].Rows[j][2].ToString();
                    conlastname = unitoffs.Tables[0].Rows[j][3].ToString();

                    txtReportDisplay.Text += System.Environment.NewLine + "     -" + sem + " " + year + " " + confirstname + " " + conlastname;
                }
            }
        }

    }
}
