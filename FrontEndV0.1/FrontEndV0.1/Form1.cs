using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client; //Libaries to hook into Swinburne Oracle

namespace FrontEndV0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string oradb;
            oradb = "Data Source=ictoraclesvm1.ict.swin.edu.au/dba;User Id=" + txtUser.Text.ToString() + ";Password=" + txtPass.Text.ToString() + ";";
            OracleConnection conn = new OracleConnection(oradb); //C# Syntax
            conn.Open();

            MessageBox.Show("Connection created successfully");

            conn.Close();
        }

    }
}
