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
        private string _Username;

        public string Username
        {
            get
            {
                return _Username;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
            frmEmpDashboard = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //only this way until we implement others' logins
            if (txtUsername.Text.ToLower() == "admin")
            {
                //verify password here...
                _Username = "admin"; //note who will be logged in

                

                if (frmEmpDashboard == null)
                {
                    frmEmpDashboard = new frmEmpDashboard();
                    frmEmpDashboard.FormClosing += frmEmpDashboardClosing;
                    frmEmpDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login, please try again");
                txtPassword.Focus();
            }
        }

        private void frmEmpDashboardClosing(object sender, FormClosingEventArgs e)
        {
            frmEmpDashboard = null; 
        }

    }
}
