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
    public partial class frmAssessment : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet ds;

        public frmAssessment(bool editable)
        {
            InitializeComponent();

            connection = conn.oraConn();

            //Set up current assessments in form
            getAssessments();
            populateAssGrid();
        }

        private void getAssessments()
        {
            OracleCommand cmd = new OracleCommand("UC2_11_VIEW_ASSESSMENT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("asscursor", OracleDbType.RefCursor);
            cmd.Parameters["asscursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            ds = new DataSet();

            da.Fill(ds, "asscursor", (OracleRefCursor)(cmd.Parameters["asscursor"].Value));

            connection.Close();
        }

        private void populateAssGrid()
        {
            //Empty the grid
            grdAssessmentInfo.Rows.Clear();

            //Populate grid
            int rowcnt = ds.Tables["asscursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = ds.Tables[0].Rows[i].ItemArray;
                grdAssessmentInfo.Rows.Add(new object[] {items[0], items[3], items[4] ,items[5]} );
            }
        }
    }
}
