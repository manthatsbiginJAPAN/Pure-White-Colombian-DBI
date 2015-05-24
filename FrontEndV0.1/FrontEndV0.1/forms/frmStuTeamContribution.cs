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
    public partial class frmStuTeamContribution : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        private DataSet tasks;

        private string _assid;
        private string _unitid;
        private int _sem;
        private int _year;

        public frmStuTeamContribution(string assid, string unitid, int sem, int year)
        {
            InitializeComponent();

            connection = conn.oraConn();

            _assid = assid;
            _unitid = unitid;
            _sem = sem;
            _year = year;

            getTasks();
            populateTasks();
        }

        private void getTasks()
        {
            OracleCommand cmd = new OracleCommand("UC2_23_VIEW_ASSTASK", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("taskcursor", OracleDbType.RefCursor);
            cmd.Parameters["taskcursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("assid", _assid);
            cmd.Parameters.Add("unitid", _unitid);
            cmd.Parameters.Add("sem", _sem);
            cmd.Parameters.Add("year", _year);

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            tasks = new DataSet();

            da.Fill(tasks, "taskcursor", (OracleRefCursor)(cmd.Parameters["taskcursor"].Value));

            connection.Close();
        }

        private void populateTasks()
        {
            grdTasks.Rows.Clear();

            int rowcnt = tasks.Tables["taskcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = tasks.Tables[0].Rows[i].ItemArray;
                grdTasks.Rows.Add(new object[] { items[0], items[5] });
            }
        }
    }
}
