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

namespace DBATest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb;
            oradb = "Data Source=ictoraclesvm1.ict.swin.edu.au/dba;User Id=" + textBox1.Text.ToString() + ";Password=" + textBox2.Text.ToString() + ";";
            OracleConnection conn = new OracleConnection(oradb); //C# Syntax
            conn.Open();

            MessageBox.Show("Connection created successfully");
            MessageBox.Show("Bae");

            conn.Close();
        }
    }
}
