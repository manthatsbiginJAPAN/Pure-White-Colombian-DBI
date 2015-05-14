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
        private DataSet unitoffs;

        private frmTeamContribution frmTeamCont;

        public frmAssessment(bool editable)
        {
            InitializeComponent();

            connection = conn.oraConn();

            //Set up current assessments in form
            getAssessments();
            populateAssGrid(this.grdAssessmentInfo);
            
            //Fill in Comboboxes
            getUnitOfferings();
            populateUnitOfferings();
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

        private void getUnitOfferings()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_22_View_Unit_Offering", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitoffcursor", OracleDbType.RefCursor);
            cmd.Parameters["unitoffcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            unitoffs = new DataSet();

            da.Fill(unitoffs, "unitoffcursor", (OracleRefCursor)(cmd.Parameters["unitoffcursor"].Value));

            connection.Close();
        }

        private void populateUnitOfferings()
        {
            //Clear the grid
            cmbUnitId.Items.Clear();
            cmbSem.Items.Clear();
            cmbYear.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object unitid = new object();
            object sem = new object();
            object year = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                unitid = unitoffs.Tables["unitoffcursor"].Rows[i][0].ToString();
                sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();
                year = unitoffs.Tables["unitoffcursor"].Rows[i][2].ToString();

                if (!cmbUnitId.Items.Contains(unitid.ToString()))
                    cmbUnitId.Items.Add(unitid.ToString());
                if (!cmbSem.Items.Contains(sem))
                    cmbSem.Items.Add(sem);
                if (!cmbYear.Items.Contains(year))
                    cmbYear.Items.Add(year);
            }
        }

        private void cmbUnitId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbUnitId.SelectedIndex != -1)
                cmbSem.Enabled = true;

            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object sem = new object();

            {

                for (int i = 0; i <= rowcnt - 1; i++)
                {
                    sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();

                    if (!cmbSem.Items.Contains(sem))
                        cmbSem.Items.Add(sem);
                }
            }
        }

        private void cmbSem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSem.SelectedIndex != -1)
                cmbYear.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC2_9_REGISTER_ASSESSMENT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("ASSid", txtAssID.Text);
            cmd.Parameters.Add("ASSTitle", txtAssTitle.Text);
            cmd.Parameters.Add("ASSdesc", txtAssDesc.Text);
            cmd.Parameters.Add("unitID", cmbUnitId.SelectedItem.ToString());
            cmd.Parameters.Add("semester", cmbSem.SelectedItem.ToString());
            cmd.Parameters.Add("year", cmbYear.SelectedItem.ToString());
            cmd.Parameters.Add("marking guide", txtMarkingGuide.Text);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            getAssessments();
            populateAssGrid(this.grdAssessmentInfo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrow = grdAssessmentInfo.SelectedCells[0].RowIndex;
            OracleCommand cmd = new OracleCommand("UC2_12_DELETE_ASSESSMENT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("assid", grdAssessmentInfo.Rows[selectedrow].Cells[0].Value.ToString() );
            cmd.Parameters.Add("unitid", grdAssessmentInfo.Rows[selectedrow].Cells[1].Value.ToString());
            cmd.Parameters.Add("sem", grdAssessmentInfo.Rows[selectedrow].Cells[2].Value);
            cmd.Parameters.Add("year", grdAssessmentInfo.Rows[selectedrow].Cells[3].Value);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Entry Deleted");

            getAssessments();
            populateAssGrid(this.grdAssessmentInfo);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Save")
            {
                OracleCommand cmd = new OracleCommand("UC2_10_UPDATE_ASSESSMENT", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("ASSid", txtAssID.Text);
                cmd.Parameters.Add("ASSTitle", txtAssTitle.Text);
                cmd.Parameters.Add("ASSdesc", txtAssDesc.Text);
                cmd.Parameters.Add("unitID", cmbUnitId.SelectedItem.ToString());
                cmd.Parameters.Add("semester", cmbSem.SelectedItem.ToString());
                cmd.Parameters.Add("year", cmbYear.SelectedItem.ToString());
                cmd.Parameters.Add("marking guide", txtMarkingGuide.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                
            }
        }

        private void btnTeamCont_Click(object sender, EventArgs e)
        {
            frmTeamCont = new frmTeamContribution(this);
            frmTeamCont.Show();
        }
    }
}
