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
    public partial class frmPeerAssessmentcs : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        private DataSet criteria;

        private frmAssessment _parent;

        public frmPeerAssessmentcs(frmAssessment parent)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _parent = parent;

            _parent.populateAssGrid(this.grdAssessmentsInfo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC2_25_REGISTER_ASSCRIT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("Criteria ID", txtCritID.Text);
            cmd.Parameters.Add("AssID", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[0].Value.ToString());
            cmd.Parameters.Add("UnitId", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[1].Value.ToString());
            cmd.Parameters.Add("Semester", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[2].Value.ToString());
            cmd.Parameters.Add("Year", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[3].Value.ToString());
            cmd.Parameters.Add("General", txtGeneralCrit.Text);
            cmd.Parameters.Add("Specific", txtSpecificCrit.Text);


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            displayCriteria();
        }

        private void displayCriteria()
        {
            grdCriteriaInfo.Rows.Clear();

            OracleCommand cmd = new OracleCommand("UC2_27_VIEW_ASSCRIT", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("critcursor", OracleDbType.RefCursor);
            cmd.Parameters["critcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("AssID", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[0].Value.ToString());
            cmd.Parameters.Add("UnitId", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[1].Value.ToString());
            cmd.Parameters.Add("Semester", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[2].Value.ToString());
            cmd.Parameters.Add("Year", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[3].Value.ToString());
            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            criteria = new DataSet();
            da.Fill(criteria, "critcursor", (OracleRefCursor)(cmd.Parameters["critcursor"].Value));
            connection.Close();

            int rowcnt = criteria.Tables["critcursor"].Rows.Count;
            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //only add tasks where they belong to the current selected assessment
                string AssID = grdAssessmentsInfo.SelectedRows[0].Cells[0].Value.ToString();
                string UnitID = grdAssessmentsInfo.SelectedRows[0].Cells[1].Value.ToString();
                int Semester = Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[2].Value);
                int Year = Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[3].Value);
                object[] items = criteria.Tables[0].Rows[i].ItemArray;

                if (AssID == items[1].ToString()
                    && UnitID == items[2].ToString()
                    && Semester == Convert.ToInt32(items[3])
                    && Year == Convert.ToInt32(items[4]))
                {
                    grdCriteriaInfo.Rows.Add(new object[] { items[0], items[5], items[6] });
                }
            }
        }

        private void grdAssessmentsInfo_SelectionChanged(object sender, EventArgs e)
        {
            displayCriteria();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Save")
            {
                OracleCommand cmd = new OracleCommand("UC2_26_UPDATE_ASSCRIT", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Criteria ID", txtCritID.Text);
                cmd.Parameters.Add("Ass ID", grdAssessmentsInfo.SelectedRows[0].Cells[0].Value.ToString());
                cmd.Parameters.Add("Unit ID", grdAssessmentsInfo.SelectedRows[0].Cells[1].Value.ToString());
                cmd.Parameters.Add("Semester", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[2].Value));
                cmd.Parameters.Add("Year", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[3].Value));
                cmd.Parameters.Add("General", txtGeneralCrit.Text);
                cmd.Parameters.Add("Specific", txtSpecificCrit.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                btnEdit.Text = "Edit";

                txtCritID.Enabled = true;
                grdAssessmentsInfo.Enabled = true;

                displayCriteria();
            }
            else
            {
                txtCritID.Text = grdCriteriaInfo.SelectedRows[0].Cells[0].Value.ToString();
                txtCritID.Enabled = false;

                txtGeneralCrit.Text = grdCriteriaInfo.SelectedRows[0].Cells[1].Value.ToString();
                txtSpecificCrit.Text = grdCriteriaInfo.SelectedRows[0].Cells[2].Value.ToString();


                btnEdit.Text = "Save";

                grdAssessmentsInfo.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC2_28_DELETE_ASSCRIT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            string critid = grdCriteriaInfo.SelectedRows[0].Cells[0].Value.ToString();

            cmd.Parameters.Add("Crit ID", critid);
            cmd.Parameters.Add("Ass ID", grdAssessmentsInfo.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.Add("Unit ID", grdAssessmentsInfo.SelectedRows[0].Cells[1].Value.ToString());
            cmd.Parameters.Add("Semester", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[2].Value));
            cmd.Parameters.Add("Year", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[3].Value));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Criterion " + critid + " deleted.");

            displayCriteria();
        }

    }
}
