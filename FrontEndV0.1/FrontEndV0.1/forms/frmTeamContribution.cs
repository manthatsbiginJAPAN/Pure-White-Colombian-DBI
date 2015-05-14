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
            cmd.Parameters.Add("Semseter", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[2].Value.ToString());
            cmd.Parameters.Add("Year", grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[3].Value.ToString());
            cmd.Parameters.Add("Task Desc", txtTaskDesc.Text);
            cmd.Parameters.Add("Due Date", dtDue.Value.ToString("dd/MMM/yyyy"));
            //


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void grdAssessmentsInfo_SelectionChanged(object sender, EventArgs e)
        {
            displayTasks(grdAssessmentsInfo.Rows[grdAssessmentsInfo.SelectedRows[0].Index].Cells[0].Value.ToString());
        }

        private void displayTasks(string assid)
        {
            //Doesn't quite work but it's close... im tired pls do it for me lol

            grdTaskInfo.Rows.Clear();

            OracleCommand cmd = new OracleCommand("UC2_23_VIEW_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("assid", assid);
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
                object[] items = tasks.Tables[0].Rows[i].ItemArray;
                grdTaskInfo.Rows.Add(new object[] { items[0], items[5], items[6] });
            }
        }

    }
}