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
        private DataSet emproles;
        private DataSet students;

        private string User;
        private bool isAdmin;
        private bool isConvenor;
        private bool isSupervisor;

        public frmLogin()
        {
            InitializeComponent();
            connection = conn.oraConn();

            User = null;
            isAdmin = false;
            isConvenor = false;
            isSupervisor = false;
            frmStuDashboard = null;
            frmEmpDashboard = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validate user based on db
            User = txtUsername.Text; //record the user
            char UserLetter = Convert.ToChar(User.Substring(0, 1));
            
            //allows easy access to user accounts without having to remember passwords
            //which for the main users are set to " " as they cannot be null
            if (txtPassword.Text.Length == 0)
                txtPassword.Text = " ";

            //check if a student
            if (Char.ToLower(UserLetter) == 's' && User.ToLower() != "supervisor") //since student ids would start with an 's' like s748932
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

                    //search dataset by stuID (username), returning a row if it exists
                    int srowcnt = students.Tables[0].Rows.Count;
                    for (int i = 0; i <= srowcnt - 1; i++)
                    {
                        //search for username
                        if (User.ToLower() == students.Tables[0].Rows[i][0].ToString().ToLower())
                        {
                            //check if password matches before confirming login
                            if (txtPassword.Text == students.Tables[0].Rows[i][5].ToString())
                            {
                                frmStuDashboard = new frmStuDashboard(User);
                                frmStuDashboard.FormClosing += frmStuDashboardClosing;
                                frmStuDashboard.Show();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password, please try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtPassword.Focus();
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Student ID not recognised, please try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
            } //otherwise check if an employee
            else
            {
                //load in all employee rows
                getEmployees();

                //search dataset by empID (username), returning a row if it exists
                int erowcnt = employees.Tables[0].Rows.Count;
                for (int i = 0; i < erowcnt; i++)
                {
                    //search for username
                    //for testing: MessageBox.Show("User: " + User + ", EmpID row: " + employees.Tables[0].Rows[i][0].ToString());
                    if (User.ToLower() == employees.Tables[0].Rows[i][0].ToString().ToLower())
                    {
                        //check if password matches before confirming login
                        if (txtPassword.Text == employees.Tables[0].Rows[i][5].ToString())
                        {
                            ValidateEmployeeStatus(User);
                            frmEmpDashboard = new frmEmpDashboard(User, isAdmin, isConvenor, isSupervisor);
                            frmEmpDashboard.FormClosing += frmEmpDashboardClosing;
                            frmEmpDashboard.Show();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password, please try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Focus();
                            return;
                        }
                    }
                }
                MessageBox.Show("Employee ID not recognised, please try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            



            /*//(for ease of access, we can use admin convenor or supervisor to access these)
            if (User.ToLower() == "admin" || User.ToLower() == "convenor" || User.ToLower() == "supervisor")
            {
                frmEmpDashboard = new frmEmpDashboard(User, true, true, true);
                frmEmpDashboard.FormClosing += frmEmpDashboardClosing;
                frmEmpDashboard.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid username and password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }*/
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

        private void getEmployeeRoles()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_26_View_Employee_Role", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("emprolescursor", OracleDbType.RefCursor);
            cmd.Parameters["emprolescursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            emproles = new DataSet();
            da.Fill(emproles, "emprolescursor", (OracleRefCursor)(cmd.Parameters["emprolescursor"].Value));
            connection.Close();
        }

        private void ValidateEmployeeStatus(string empid)
        {
            //retriete employee details
            getEmployeeRoles();
            int errowcnt = emproles.Tables[0].Rows.Count;

            //set default values
            isAdmin = false; 
            isConvenor = false;
            isSupervisor = false;

            //search through all employeeroles by empid
            for (int i = 0; i < errowcnt; i++)
            {
                //find only rows for the individual employee
                if (emproles.Tables[0].Rows[i][0].ToString().ToLower() == empid.ToLower())
                {
                    //check if admin
                    if (emproles.Tables[0].Rows[i][1].ToString().ToLower() == "admin")
                        isAdmin = true;
                    //check if convenor
                    if (emproles.Tables[0].Rows[i][1].ToString().ToLower() == "convenor")
                        isConvenor = true;
                    //check if supervisor
                    if (emproles.Tables[0].Rows[i][1].ToString().ToLower() == "supervisor")
                        isSupervisor = true;
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
    }
}
