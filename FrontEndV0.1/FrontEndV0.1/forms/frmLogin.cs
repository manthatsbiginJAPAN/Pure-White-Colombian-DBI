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
                char UserLetter = Convert.ToChar(User.Substring(0, 1));

                //will eventually validate user based on db

                //check if a student
                if (UserLetter == 's') //since student ids would start with an 's' like s748932
                {
                    if (User.ToLower() == "student") //for ease of access at the moment...
                    {
                        frmStuDashboard = new frmStuDashboard(User);
                        frmStuDashboard.FormClosing += frmStuDashboardClosing;
                        frmStuDashboard.Show();
                    } 
                    else
                    {
                        //load in all student rows
                        //search dataset by stuID (username), returning a row if it exists
                        //check if password matches before confirming login
                    }
                }


                //check if an employee
                if (UserLetter == 'e')
                {
                    //load in all employee rows
                    //search dataset by empID (username), returning a row if it exists
                    //check if password matches before confirming login
                }

                //(for ease of access...)
                if (User.ToLower() == "admin" || User.ToLower() == "convenor" || User.ToLower() == "supervisor")
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
