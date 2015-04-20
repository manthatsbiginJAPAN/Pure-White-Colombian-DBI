using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontEndV0._1.forms
{
    public partial class frmLogin : Form
    {
        private frmEmpDashboard frmEmpDashboard;

        public frmLogin()
        {
            InitializeComponent();
            frmEmpDashboard = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Code here needs to be redone at some point to actually log people in
            //Will include logic to work out usertype

            if (textBox1.Text.ToLower() == "admin")
            {
                if (frmEmpDashboard == null)
                {
                    frmEmpDashboard = new frmEmpDashboard("admin");
                    frmEmpDashboard.FormClosing += frmEmpDashboardClosing;
                    frmEmpDashboard.Show();
                }
            }
        }

        private void frmEmpDashboardClosing(object sender, FormClosingEventArgs e)
        {
            frmEmpDashboard = null; 
        }

    }
}
