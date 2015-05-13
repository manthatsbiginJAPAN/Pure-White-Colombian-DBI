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
    public partial class frmLogin : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        private frmEmpDashboard frmEmpDashboard;
        private frmStuDashboard frmStuDashboard;
        private DataSet employees;
        private DataSet students;
        private string User;

        public frmLogin()
        {
            InitializeComponent();
            connection = conn.oraConn();

            //Form load, without yet instantiating subforms
            frmStuDashboard = null;
            frmEmpDashboard = null;
            User = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Code here needs to be redone at some point to actually log people in
            //Will include logic to work out usertype

            User = txtUsername.Text; //record the user
            char UserLetter = Convert.ToChar(User.Substring(0, 1));
            //MessageBox.Show("User is " + User + " with letter '" + UserLetter + "'");

            if (frmEmpDashboard == null)
            {
                //will validate user based on db

                //check if a student
                if (UserLetter == 's') //since student ids would start with an 's' like s748932
                {
                    if (User.ToLower() == "student") //for ease of access at the moment...
                    {
                        frmStuDashboard = new frmStuDashboard(User);
                        frmStuDashboard.FormClosing += frmStuDashboardClosing;
                        frmStuDashboard.Show();
                        return;
                    }
                    else
                    {
                        //load in all student rows
                        getStudents();
                        int rowcnt = students.Tables[0].Rows.Count;

                        //search dataset by stuID (username), returning a row if it exists
                        for (int i = 0; i <= rowcnt - 1; i++)
                        {
                            //search for username
                            if (User == students.Tables[0].Rows[i][0].ToString())
                            {
                                //check if password matches before confirming login
                                if (txtPassword.Text == students.Tables[0].Rows[i][5].ToString())
                                {
                                    frmStuDashboard = new frmStuDashboard(User);
                                    frmStuDashboard.FormClosing += frmStuDashboardClosing;
                                    frmStuDashboard.Show();
                                    return;
                                }
                                MessageBox.Show("Incorrect Password, please try again");
                            }
                            MessageBox.Show("Student Login not recognised, please try again");
                        }
                    }


                    //check if an employee
                    if (UserLetter == 'e')
                    {
                        //load in all employee rows
                        //search dataset by empID (username), returning a row if it exists
                        //check if password matches before confirming login
                    }
                }
                //(for ease of access...)
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

        private void getStudents()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_11_View_Student", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("stucursor", OracleDbType.RefCursor);
            cmd.Parameters["stucursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            students = new DataSet();

            da.Fill(students, "stucursor", (OracleRefCursor)(cmd.Parameters["stucursor"].Value));

            connection.Close();
        }

        private void getEmployees()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_3_View_Employee", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("empcursor", OracleDbType.RefCursor);
            cmd.Parameters["empcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            employees = new DataSet();

            da.Fill(employees, "empcursor", (OracleRefCursor)(cmd.Parameters["empcursor"].Value));

            connection.Close();
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
