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
    public partial class frmMeetingAttendance : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");


        public frmMeetingAttendance()
        {
            InitializeComponent();

            connection = conn.oraConn();
        }
        

        private void gbIdentifyingInformation_Enter(object sender, EventArgs e)
        {

        }

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void grdProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbStuID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
