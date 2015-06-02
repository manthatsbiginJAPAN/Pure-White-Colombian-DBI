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

        private string _assID;
        private string _unitID;
        private int _semester;
        private int _year;
        private string _teamID;

        public frmPeerAssessmentcs(string assid, string unitid, int sem, int year, string team)
        {
            InitializeComponent();
            connection = conn.oraConn();

            _assID = assid;
            _unitID = unitid;
            _semester = sem;
            _year = year;
            _teamID = team;


            //_parent = parent;
            //_parent.populateAssGrid(this.grdCriteriaInfo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Save?")
            {
                OracleCommand cmd = new OracleCommand("UC2_25_REGISTER_ASSCRIT", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                /*
                cmd.Parameters.Add("Criteria ID", txtCritID.Text);
                cmd.Parameters.Add("AssID", grdCriteriaInfo.Rows[grdCriteriaInfo.SelectedRows[0].Index].Cells[0].Value.ToString());
                cmd.Parameters.Add("UnitId", grdCriteriaInfo.Rows[grdCriteriaInfo.SelectedRows[0].Index].Cells[1].Value.ToString());
                cmd.Parameters.Add("Semester", grdCriteriaInfo.Rows[grdCriteriaInfo.SelectedRows[0].Index].Cells[2].Value.ToString());
                cmd.Parameters.Add("Year", grdCriteriaInfo.Rows[grdCriteriaInfo.SelectedRows[0].Index].Cells[3].Value.ToString());
                cmd.Parameters.Add("General", txtGeneralCrit.Text);
                cmd.Parameters.Add("Specific", txtSpecificCrit.Text);
                */

                cmd.Parameters.Add("Criteria ID", txtCritID.Text);
                cmd.Parameters.Add("AssID", _assID);
                cmd.Parameters.Add("UnitId", _unitID);
                cmd.Parameters.Add("Semester", _semester);
                cmd.Parameters.Add("Year", _year);
                cmd.Parameters.Add("General", txtGeneralCrit.Text);
                cmd.Parameters.Add("Specific", txtSpecificCrit.Text);


                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                displayCriteria();

                //Enable grid and buttons
                grdCriteriaInfo.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //Disable textboxes
                gbDetails.Enabled = false;

                //reset button text and textboxes (except for general aspect, as it might be useful not to re-type)
                btnAdd.Text = "Add";
                txtCritID.Clear();
                txtSpecificCrit.Clear();
            }
            else
            {
                //Disable grid and buttons
                grdCriteriaInfo.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                //enable textboxes
                gbDetails.Enabled = true;

                //change button text
                btnAdd.Text = "Save?";
            }
        }

        private void displayCriteria()
        {
            grdCriteriaInfo.Rows.Clear();

            OracleCommand cmd = new OracleCommand("UC2_27_VIEW_ASSCRIT", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("critcursor", OracleDbType.RefCursor);
            cmd.Parameters["critcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("AssID", _assID);
            cmd.Parameters.Add("UnitId", _unitID);
            cmd.Parameters.Add("Semester", _semester);
            cmd.Parameters.Add("Year", _year);
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
                object[] items = criteria.Tables[0].Rows[i].ItemArray;

                if (_assID == items[1].ToString()
                    && _unitID == items[2].ToString()
                    && _semester == Convert.ToInt32(items[3])
                    && _year == Convert.ToInt32(items[4]))
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
            if (grdCriteriaInfo.SelectedRows.Count == 0)
                return;

            if (btnEdit.Text == "Update?")
            {
                OracleCommand cmd = new OracleCommand("UC2_26_UPDATE_ASSCRIT", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Criteria ID", txtCritID.Text);
                cmd.Parameters.Add("Ass ID", _assID);
                cmd.Parameters.Add("Unit ID", _unitID);
                cmd.Parameters.Add("Semester", _semester);
                cmd.Parameters.Add("Year", _year);
                cmd.Parameters.Add("General", txtGeneralCrit.Text);
                cmd.Parameters.Add("Specific", txtSpecificCrit.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                //Enable grid and buttons
                grdCriteriaInfo.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;

                //Disable textboxes
                gbDetails.Enabled = false;

                //reset button text and textboxes (except for general aspect, as it might be useful not to re-type)
                btnEdit.Text = "Edit";
                txtCritID.Clear();
                txtSpecificCrit.Clear();

                displayCriteria();
            }
            else
            {
                //load data into textboxes
                txtCritID.Text = grdCriteriaInfo.SelectedRows[0].Cells[0].Value.ToString();
                txtGeneralCrit.Text = grdCriteriaInfo.SelectedRows[0].Cells[1].Value.ToString();
                txtSpecificCrit.Text = grdCriteriaInfo.SelectedRows[0].Cells[2].Value.ToString();

                //Disable grid and buttons
                grdCriteriaInfo.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                //enable textboxes
                gbDetails.Enabled = true;

                //change button text
                btnEdit.Text = "Update?";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Delete Criterion #" + txtCritID.Text + "?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (response == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand("UC2_28_DELETE_ASSCRIT", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                string critid = grdCriteriaInfo.SelectedRows[0].Cells[0].Value.ToString();

                cmd.Parameters.Add("Crit ID", critid);
                cmd.Parameters.Add("Ass ID", _assID);
                cmd.Parameters.Add("Unit ID", _unitID);
                cmd.Parameters.Add("Semester", _semester);
                cmd.Parameters.Add("Year", _year);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Criterion " + critid + " deleted.");

                displayCriteria();
            }
        }

        private void frmPeerAssessmentcs_Load(object sender, EventArgs e)
        {
            displayCriteria();
        }

        private void grdCriteriaInfo_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            //load data into textboxes as long as there is something selected
            if (grdCriteriaInfo.SelectedRows.Count != 0)
            {
                txtCritID.Text = grdCriteriaInfo.SelectedRows[0].Cells[0].Value.ToString();
                txtGeneralCrit.Text = grdCriteriaInfo.SelectedRows[0].Cells[1].Value.ToString();
                txtSpecificCrit.Text = grdCriteriaInfo.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
