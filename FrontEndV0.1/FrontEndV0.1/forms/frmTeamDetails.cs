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
        private DataSet ds;
        private DataSet teams;
        private DataSet unitoffs;
        private DataSet projects;

        public frmTeamDetails(bool editable)
        {
            InitializeComponent();
            connection = conn.oraConn();
        }

        private void frmTeamDetails_Load(object sender, EventArgs e)
        {
            getTeams();
            getProjects();
            getUnitOfferings();
            getEmployees();

            populateTeamGrid();
            populateSupervisors();
            populateProjects();
            populateUnitOfferings();
        }

        #region getData
        private void getProjects()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_7_View_Project", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("projcursor", OracleDbType.RefCursor);
            cmd.Parameters["projcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            projects = new DataSet();

            da.Fill(projects, "projcursor", (OracleRefCursor)(cmd.Parameters["projcursor"].Value));

            connection.Close();
        }

        private void getUnitOfferings()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_22_View_Unit_Offering", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitoffcursor", OracleDbType.RefCursor);
            cmd.Parameters["unitoffcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            unitoffs = new DataSet();

            da.Fill(unitoffs, "unitoffcursor", (OracleRefCursor)(cmd.Parameters["unitoffcursor"].Value));

            connection.Close();
        }

        private void getTeams()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_3_View_Team", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("teamcursor", OracleDbType.RefCursor);
            cmd.Parameters["teamcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            teams = new DataSet();

            da.Fill(teams, "teamcursor", (OracleRefCursor)(cmd.Parameters["teamcursor"].Value));

            connection.Close();
        }

        private void getEmployees()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_26_View_Employee_Role", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("empcursor", OracleDbType.RefCursor);
            cmd.Parameters["empcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            ds = new DataSet();

            da.Fill(ds, "empcursor", (OracleRefCursor)(cmd.Parameters["empcursor"].Value));

            connection.Close();
        }
        #endregion

        #region populateWithData
        private void populateUnitOfferings()
        {
            //Clear the comboboxes
            cbUnitID.Items.Clear();
            cbSemester.Items.Clear();
            cbYear.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            object unitid = new object();
            object sem = new object();
            object year = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                unitid = unitoffs.Tables["unitoffcursor"].Rows[i][0].ToString();
                sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();
                year = unitoffs.Tables["unitoffcursor"].Rows[i][2].ToString();

                if (!cbUnitID.Items.Contains(unitid.ToString()))
                    cbUnitID.Items.Add(unitid.ToString());
                if (!cbSemester.Items.Contains(sem))
                    cbSemester.Items.Add(sem);
                if (!cbYear.Items.Contains(year))
                    cbYear.Items.Add(year);
            }
        }

        private void populateTeamGrid()
        {
            //Clear the grid
            grdTeamInfo.Rows.Clear();

            //Populate the grid from the dataset

            int rowcnt = teams.Tables["teamcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = teams.Tables[0].Rows[i].ItemArray;
                grdTeamInfo.Rows.Add(new object[] { items[0], items[1], items[2], items[3], items[4], items[5] });
            }
        }

        private void populateProjects()
        {
            //Clear the grid
            cbProjID.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = projects.Tables["projcursor"].Rows.Count;
            object items = new object();

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                items = projects.Tables["projcursor"].Rows[i][0].ToString();
                if (!cbProjID.Items.Contains(items.ToString()))
                    cbProjID.Items.Add(items.ToString());
            }
        }

        private void populateSupervisors()
        {
            //Clear the grid
            cbSupervisor.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = ds.Tables["empcursor"].Rows.Count;
            object items = new object();
            String roles = null;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                items = ds.Tables["empcursor"].Rows[i][0].ToString();
                roles = ds.Tables["empcursor"].Rows[i][1].ToString();
                if (!cbSupervisor.Items.Contains(items.ToString()))
                {
                    if (roles.ToLower().Equals("supervisor"))
                    {
                        cbSupervisor.Items.Add(items.ToString());
                    }
                }
            }
        }
        #endregion

        #region BtnPress
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnAdd.Text == "Save?")
            {
                //Command to add team
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC2_1_REGISTER_TEAM", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 100;

                    cmd.Parameters.Add("teamID", txtTeamID.Text);
                    cmd.Parameters.Add("projID", cbProjID.SelectedItem);
                    cmd.Parameters.Add("unitID", cbUnitID.SelectedItem);
                    cmd.Parameters.Add("semester", cbSemester.SelectedItem);
                    cmd.Parameters.Add("year", cbYear.SelectedItem);
                    cmd.Parameters.Add("empID", cbSupervisor.SelectedItem);
                    cmd.Parameters.Add("role", "supervisor");

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    teams.Tables[0].Rows.Add(txtTeamID.Text
                        , cbProjID.SelectedItem
                        , cbUnitID.SelectedItem
                        , cbSemester.SelectedItem
                        , cbYear.SelectedItem
                        , cbSupervisor.SelectedItem);


                    //Repopulate Grid
                    populateTeamGrid();

                    //Disable buttons
                    txtTeamID.Enabled = false;
                    cbProjID.Enabled = false;
                    cbUnitID.Enabled = false;
                    cbSemester.Enabled = false;
                    cbYear.Enabled = false;
                    cbSupervisor.Enabled = false;

                    //Enable other buttons
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtTeamID.Clear();

                    btnAdd.Text = "Add";
                }
            }
            else
            {
                gbIdentifyingInformation.Enabled = true;
                //Enable buttons
                txtTeamID.Enabled = true;
                cbProjID.Enabled = true;
                cbUnitID.Enabled = true;
                cbSemester.Enabled = true;
                cbYear.Enabled = true;
                cbSupervisor.Enabled = true;
                txtStuID.Enabled = true;

                //Disable other buttons
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnAdd.Text = "Save?";
                grdTeamInfo.ClearSelection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = grdTeamInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedteamid = grdTeamInfo.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            DialogResult response = MessageBox.Show("Delete Team: " + selectedteamid + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                /*foreach (object student in clbEmpRoles.Items)
                {
                    OracleCommand cmd1 = new OracleCommand("UC1_28_Delete_Employee_Role", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("empid", selectedempid);
                    cmd1.Parameters.Add("role", role.ToString());

                    connection.Open();
                    cmd1.ExecuteNonQuery();
                    connection.Close();
                }*/

                OracleCommand cmd = new OracleCommand("UC2_4_Delete_Team", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("teamid", selectedteamid);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getTeams();
                populateTeamGrid();
                MessageBox.Show("Team Deleted");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnEdit.Text == "Update?")
            {
                //Command to add Employee
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC2_2_Update_Team", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("teamID", txtTeamID.Text);
                    cmd.Parameters.Add("projID", cbProjID.SelectedItem);
                    cmd.Parameters.Add("unitID", cbUnitID.SelectedItem);
                    cmd.Parameters.Add("semester", cbSemester.SelectedItem);
                    cmd.Parameters.Add("year", cbYear.SelectedItem);
                    cmd.Parameters.Add("empID", cbSupervisor.SelectedItem);
                    //cmd.Parameters.Add("role", "supervisor");

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Grid and notify user
                    getTeams();
                    populateTeamGrid();
                    MessageBox.Show("Team Updated");

                    //Disable textboxes
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtTeamID.Clear();
                    cbProjID.SelectedIndex = -1;
                    cbUnitID.SelectedIndex = -1;
                    cbSemester.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;
                    cbSupervisor.SelectedIndex = -1;

                    grdTeamInfo.Enabled = true;
                    btnEdit.Text = "Edit";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //loading data into textboxes: find the row, load the data from the datagridset
                int selectedrowindex = grdTeamInfo.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
                txtTeamID.Text = grdTeamInfo.Rows[selectedrowindex].Cells[0].Value.ToString();
                cbProjID.SelectedIndex = cbProjID.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[1].Value.ToString());
                cbUnitID.SelectedIndex = cbUnitID.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[2].Value.ToString());
                cbSemester.SelectedIndex = cbSemester.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[3].Value.ToString());
                cbYear.SelectedIndex = cbYear.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[4].Value.ToString());
                cbSupervisor.SelectedIndex = cbSupervisor.FindString(grdTeamInfo.Rows[selectedrowindex].Cells[5].Value.ToString());
                
                //Enable textboxes
                gbIdentifyingInformation.Enabled = true;
                txtTeamID.Enabled = false;
                cbProjID.Enabled = false;
                cbUnitID.Enabled = false;
                cbSemester.Enabled = false;
                cbYear.Enabled = false;

                gbDetails.Enabled = true;
                cbSupervisor.Enabled = true;

                //Disable other buttons
                //gbIdentifyingInformation.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any employee from grid
                btnEdit.Text = "Update?";
                grdTeamInfo.ClearSelection();
                grdTeamInfo.Enabled = false;
            }
        }
        #endregion

        private bool FormValidated()
        {
            return true;
        }

    }
}
