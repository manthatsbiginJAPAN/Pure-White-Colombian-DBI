using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace FrontEndV0._1.forms
{
    public partial class frmReport : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        // private DataSet ds;
        private bool editable;

        public frmReport(bool Editable)
        {
           // InitializeComponent();
            editable = Editable;
            connection = conn.oraConn();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

    }
}
