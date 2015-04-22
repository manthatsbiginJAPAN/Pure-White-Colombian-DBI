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
        private frmStuDashboard frmStuDashboard;
        private string User;

        public frmLogin()
        {
            InitializeComponent();
            frmEmpDashboard = null;
            User = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Code here needs to be redone at some point to actually log people in
            //Will include logic to work out usertype

            if (frmEmpDashboard == null)
            {
                User = txtUsername.Text; //record the user
                //will eventually validate user based on db

                //check if a student
                if (User.ToLower() == "student")
                {
                    frmStuDashboard = new frmStuDashboard(User);
                    frmStuDashboard.FormClosing += frmStuDashboardClosing;
                    frmStuDashboard.Show();
                } //check if an employee
                else if (User.ToLower() == "admin" || User.ToLower() == "convenor" || User.ToLower() == "supervisor")
                {
                    frmEmpDashboard = new frmEmpDashboard(User);                  
                    frmEmpDashboard.FormClosing += frmEmpDashboardClosing;
                    frmEmpDashboard.Show();

                    //old code:
                    /*if (User.ToLower() == "admin")
                        frmEmpDashboard = new frmEmpDashboard("admin");

                    if (User.ToLower() == "supervisor")
                        frmEmpDashboard = new frmEmpDashboard("supervisor");

                    if (User.ToLower() == "convenor")
                        frmEmpDashboard = new frmEmpDashboard("convenor");
                    */
                }
                else
                {
                    MessageBox.Show("Please enter a valid username and password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
            }
        }

        private void frmEmpDashboardClosing(object sender, FormClosingEventArgs e)
        {
            frmEmpDashboard = null;
        }

        private void frmStuDashboardClosing(object sender, FormClosingEventArgs e)
        {
            frmStuDashboard = null;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus(); //Doesn't work but whatevs man
        }

        
        private bool IsValidUser(string username) //let's worry about the login parts later
        {
            return true;
        }

    }
}
