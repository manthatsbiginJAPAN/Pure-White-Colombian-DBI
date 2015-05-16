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

        public frmTeamContribution(frmAssessment parent)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _parent = parent;

            _parent.populateAssGrid(this.grdAssessmentsInfo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC2_21_REGISTER_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("Task ID", txtTaskId.Text);
            cmd.Parameters.Add("AssID", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[0].Value.ToString());
            cmd.Parameters.Add("UnitId", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[1].Value.ToString());
            cmd.Parameters.Add("Semester", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[2].Value.ToString());
            cmd.Parameters.Add("Year", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[3].Value.ToString());
            cmd.Parameters.Add("Task Desc", txtTaskDesc.Text);
            cmd.Parameters.Add("Due Date", dtDue.Value.ToString("dd/MMM/yyyy"));


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
            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            tasks = new DataSet();
            da.Fill(tasks, "taskcursor", (OracleRefCursor)(cmd.Parameters["taskcursor"].Value));
            connection.Close();

            int rowcnt = tasks.Tables["taskcursor"].Rows.Count;
            for (int i = 0; i <= rowcnt - 1; i++)
            {
                //only add tasks where they belong to the current selected assessment
                string AssID = grdAssessmentsInfo.SelectedRows[0].Cells[0].Value.ToString();
                string UnitID = grdAssessmentsInfo.SelectedRows[0].Cells[1].Value.ToString();
                int Semester = Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[2].Value);
                int Year = Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[3].Value);
                object[] items = tasks.Tables[0].Rows[i].ItemArray;

                if (AssID == items[1].ToString() 
                    && UnitID == items[2].ToString() 
                    && Semester == Convert.ToInt32(items[3]) 
                    && Year == Convert.ToInt32(items[4]))
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
                cmd.Parameters.Add("Ass ID", grdAssessmentsInfo.SelectedRows[0].Cells[0].Value.ToString());
                cmd.Parameters.Add("Unit ID", grdAssessmentsInfo.SelectedRows[0].Cells[1].Value.ToString());
                cmd.Parameters.Add("Semester", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[2].Value));
                cmd.Parameters.Add("Year", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[3].Value));
                cmd.Parameters.Add("Task Desc", txtTaskDesc.Text);
                cmd.Parameters.Add("Due Date", dtDue.Value.ToString("dd/MMM/yyyy"));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                btnEdit.Text = "Edit";

                txtTaskId.Enabled = true;
                grdAssessmentsInfo.Enabled = true;

                displayTasks();
            }
            else
            {
                txtTaskId.Text = grdTaskInfo.SelectedRows[0].Cells[0].Value.ToString();
                txtTaskId.Enabled = false;

                txtTaskDesc.Text = grdTaskInfo.SelectedRows[0].Cells[1].Value.ToString();
                dtDue.Value = Convert.ToDateTime(grdTaskInfo.SelectedRows[0].Cells[2].Value);

                btnEdit.Text = "Save";

                grdAssessmentsInfo.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC2_24_DELETE_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            string taskid = grdTaskInfo.SelectedRows[0].Cells[0].Value.ToString();

            cmd.Parameters.Add("Task ID", taskid);
            cmd.Parameters.Add("Ass ID", grdAssessmentsInfo.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.Add("Unit ID", grdAssessmentsInfo.SelectedRows[0].Cells[1].Value.ToString());
            cmd.Parameters.Add("Semester", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[2].Value));
            cmd.Parameters.Add("Year", Convert.ToInt32(grdAssessmentsInfo.SelectedRows[0].Cells[3].Value));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Task " + taskid + " deleted.");

            displayTasks();
        }

    }
}