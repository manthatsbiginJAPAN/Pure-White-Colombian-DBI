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
    public partial class frmTeamContribution : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        
        private DataSet tasks;
        private frmAssessment _parent;

        private string _assID;
        private string _unitID;
        private int _semester;
        private int _year;

        public frmTeamContribution(string AssID, string UnitID, int Semester, int Year)
        {
            InitializeComponent();

            connection = conn.oraConn();
            _assID = AssID;
            _unitID = UnitID;
            _semester = Semester;
            _year = Year;

            //_parent = parent;

            //_parent.populateAssGrid(this.grdAssessmentsInfo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC2_21_REGISTER_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("Task ID", txtTaskId.Text);
            cmd.Parameters.Add("AssID", _assID);
            cmd.Parameters.Add("UnitId", _unitID);
            cmd.Parameters.Add("Semester", _semester);
            cmd.Parameters.Add("Year", _year);
            cmd.Parameters.Add("Task Desc", txtTaskDesc.Text);
            cmd.Parameters.Add("Due Date", dtDue.Value.ToString("dd/MMM/yyyy"));
            cmd.Parameters.Add("Periods", Convert.ToInt16(txtPeriods.Text));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            displayTasks();
        }

        private void grdAssessmentsInfo_SelectionChanged(object sender, EventArgs e)
        {
            displayTasks();
        }

        private void displayTasks()
        {
            grdTaskInfo.Rows.Clear();

            OracleCommand cmd = new OracleCommand("UC2_23_VIEW_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;         
            cmd.Parameters.Add("taskcursor", OracleDbType.RefCursor);
            cmd.Parameters["taskcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("AssID", _assID);
            cmd.Parameters.Add("UnitId", _unitID);
            cmd.Parameters.Add("Semester", _semester);
            cmd.Parameters.Add("Year", _year);
            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            tasks = new DataSet();
            da.Fill(tasks, "taskcursor", (OracleRefCursor)(cmd.Parameters["taskcursor"].Value));
            connection.Close();

            int rowcnt = tasks.Tables["taskcursor"].Rows.Count;
            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //only add tasks where they belong to the current assessment
                object[] items = tasks.Tables[0].Rows[i].ItemArray;

                if (_assID == items[1].ToString() 
                    && _unitID== items[2].ToString() 
                    && _semester == Convert.ToInt32(items[3]) 
                    && _year == Convert.ToInt32(items[4]))
                {
                    grdTaskInfo.Rows.Add(new object[] { items[0], items[5], items[6] });
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Save")
            {
                OracleCommand cmd = new OracleCommand("UC2_22_UPDATE_ASSTASK", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Task ID", txtTaskId.Text);
                cmd.Parameters.Add("Ass ID", _assID);
                cmd.Parameters.Add("Unit ID", _unitID);
                cmd.Parameters.Add("Semester", _semester);
                cmd.Parameters.Add("Year", _year);
                cmd.Parameters.Add("Task Desc", txtTaskDesc.Text);
                cmd.Parameters.Add("Due Date", dtDue.Value.ToString("dd/MMM/yyyy"));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                btnEdit.Text = "Edit";

                txtTaskId.Enabled = true;

                displayTasks();
            }
            else
            {
                txtTaskId.Text = grdTaskInfo.SelectedRows[0].Cells[0].Value.ToString();
                txtTaskId.Enabled = false;

                txtTaskDesc.Text = grdTaskInfo.SelectedRows[0].Cells[1].Value.ToString();
                dtDue.Value = Convert.ToDateTime(grdTaskInfo.SelectedRows[0].Cells[2].Value);

                btnEdit.Text = "Save";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC2_24_DELETE_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            string taskid = grdTaskInfo.SelectedRows[0].Cells[0].Value.ToString();

            cmd.Parameters.Add("Task ID", taskid);
            cmd.Parameters.Add("Ass ID", _assID);
            cmd.Parameters.Add("Unit ID", _unitID);
            cmd.Parameters.Add("Semester", _semester);
            cmd.Parameters.Add("Year", _year);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Task " + taskid + " deleted.");

            displayTasks();
        }
    }
}