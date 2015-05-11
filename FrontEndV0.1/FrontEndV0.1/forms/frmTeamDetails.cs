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
    public partial class frmTeamDetails : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        public frmTeamDetails(bool editable)
        {
            InitializeComponent();
            connection = conn.oraConn();
        }

        

    }
}
