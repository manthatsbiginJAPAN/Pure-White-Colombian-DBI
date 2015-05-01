using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FrontEndV0._1.forms
{
    public partial class frmUnitOfferings : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet unitoffs;
        private DataSet units;
        private DataSet emps;

        public frmUnitOfferings(bool editable)
        {
            InitializeComponent();

            connection = conn.oraConn();
        }

        private void frmUnitOfferings_Load(object sender, EventArgs e)
        {
            //Fetch data
            getUnitOfferings();
            getUnits();
            getEmps();

            //prepare and display data
            grdUnitOfferings.ClearSelection();
            populateUnitOfferingsGrid();
            populateUnitIDs();
            populateConvenors();
            cbConvenor.SelectedIndex = 0; //show the 'none' option for convenor as default
        }

        private void getEmps()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_3_View_Employee", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("empcursor", OracleDbType.RefCursor);
            cmd.Parameters["empcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            emps = new DataSet();

            da.Fill(emps, "empcursor", (OracleRefCursor)(cmd.Parameters["empcursor"].Value));

            connection.Close();
        }

        private void getUnits()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC1_7_View_Unit", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("unitcursor", OracleDbType.RefCursor);
            cmd.Parameters["unitcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            units = new DataSet();

            da.Fill(units, "unitcursor", (OracleRefCursor)(cmd.Parameters["unitcursor"].Value));

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

        private void populateUnitIDs()
        {
            //Clear the grid
            cbUnitID.Items.Clear();

            //Populate the grid from the dataset
            int rowcnt = units.Tables["unitcursor"].Rows.Count;
            MessageBox.Show("Available Units: " + rowcnt.ToString());
            object itm;
            
            for (int i = 0; i <= rowcnt - 1; i++)
            {
                itm = units.Tables["unitcursor"].Rows[i][0].ToString();
                cbUnitID.Items.Add(itm);
                //object[] items = units.Tables[0].Rows[i].ItemArray; 
                //grdUnitOfferings.Rows.Add(new object[] { items[0], items[2], items[3] });
            }
        }

        private void populateConvenors()
        {
            //Clear the grid but add a blank/null option
            cbConvenor.Items.Clear();
            //DataRow nullrow = null;
            cbConvenor.Items.Insert(0, "[None]");

            //Populate the grid from the dataset
            int rowcnt = emps.Tables["empcursor"].Rows.Count;
            MessageBox.Show("Available Convenors: " + rowcnt.ToString());
            object itm;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                itm = emps.Tables["empcursor"].Rows[i][0].ToString();
                cbConvenor.Items.Add(itm);
            }
        }

        private void populateUnitOfferingsGrid()
        {
            //Clear the grid
            grdUnitOfferings.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = unitoffs.Tables[0].Rows[i].ItemArray;
                grdUnitOfferings.Rows.Add(new object[] { items[0], items[1], items[2], items[3] });
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnAdd.Text == "Save?")
            {
                //Command to add Unit
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC1_21_Register_Unit_Offering", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("unitid", cbUnitID.SelectedItem.ToString());
                    cmd.Parameters.Add("semester", Convert.ToInt32(cbSemester.SelectedItem.ToString()));
                    cmd.Parameters.Add("year", Convert.ToInt32(cbYear.SelectedItem.ToString()));
                    if (cbConvenor.SelectedItem.ToString() != "[none]")
                    {
                        cmd.Parameters.Add("empid", cbConvenor.SelectedItem.ToString());

                        unitoffs.Tables[0].Rows.Add(cbUnitID.SelectedItem
                        , cbSemester.SelectedItem
                        , cbYear.SelectedItem
                        , cbConvenor.SelectedItem);
                    }
                    else
                    {
                        cmd.Parameters.Add("empid", null);

                        unitoffs.Tables[0].Rows.Add(cbUnitID.SelectedItem
                        , cbSemester.SelectedItem
                        , cbYear.SelectedItem
                        , null);
                    }
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    

                    //Repopulate Grid
                    populateUnitOfferingsGrid();

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnDelete.Enabled = true;

                    //Clear textboxes/fields
                    cbUnitID.SelectedIndex = -1;
                    cbSemester.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;

                    grdUnitOfferings.Enabled = true;
                    btnAdd.Text = "Add";
                    //Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //Enable group boxes
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                btnDelete.Enabled = false;

                //Change button text and deselect any unit offering from grid
                btnAdd.Text = "Save?";
                grdUnitOfferings.ClearSelection();
            }
        }


        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (cbUnitID.SelectedItem.ToString().Length == 0)
                ErrorMsg += Environment.NewLine + "Please select a Unit ID.";
            if (cbSemester.SelectedItem.ToString().Length == 0)
                ErrorMsg += Environment.NewLine + "Please select a Semester.";
            if (cbYear.SelectedItem.ToString().Length == 0)
                ErrorMsg += Environment.NewLine + "Please select a Year.";

            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Unit Offering Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void grdUnitOfferings_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUnitOfferings.SelectedCells.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = grdUnitOfferings.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedunitid = grdUnitOfferings.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            string selectedsemester = grdUnitOfferings.Rows[selectedrowindex].Cells[1].Value.ToString(); //fetch the semester in that row
            string selectedyear = grdUnitOfferings.Rows[selectedrowindex].Cells[2].Value.ToString(); //fetch the year in that row

            DialogResult response = MessageBox.Show("Delete Unit: " + selectedunitid +
                ", semester " + selectedsemester + ", " + selectedyear + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {   
                OracleCommand cmd = new OracleCommand("UC1_24_Delete_Unit_Offering", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("unitid", selectedunitid);
                cmd.Parameters.Add("semester", selectedsemester);
                cmd.Parameters.Add("year", selectedyear);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getUnitOfferings();
                populateUnitOfferingsGrid();
                MessageBox.Show("Unit Offering Deleted");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          //should not be available
        }

        private void cbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnitID.SelectedIndex != -1)
                cbSemester.Enabled = true;
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSemester.SelectedIndex != -1)
                cbYear.Enabled = true;
        }
    }
}
