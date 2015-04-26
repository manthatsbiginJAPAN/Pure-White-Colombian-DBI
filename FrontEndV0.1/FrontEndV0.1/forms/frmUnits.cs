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
    public partial class frmUnits : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet ds;

        public frmUnits()
        {
            InitializeComponent();

            connection = conn.oraConn();
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            grdUnits.ClearSelection();
            getUnits();
            populateUnitGrid();
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

            ds = new DataSet();

            da.Fill(ds, "unitcursor", (OracleRefCursor)(cmd.Parameters["unitcursor"].Value));

            connection.Close();
        }

        private void populateUnitGrid()
        {
            //Clear the grid
            grdUnits.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = ds.Tables["unitcursor"].Rows.Count;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = ds.Tables[0].Rows[i].ItemArray;
                grdUnits.Rows.Add(new object[] { items[0], items[1], items[2]});
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
                    OracleCommand cmd = new OracleCommand("UC1_5_Register_Unit", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("unitid", txtUnitID.Text);
                    cmd.Parameters.Add("name", txtName.Text);
                    cmd.Parameters.Add("desc", txtDescription.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    ds.Tables[0].Rows.Add(txtUnitID.Text
                        , txtName.Text
                        , txtDescription.Text);

                    //Repopulate Grid
                    populateUnitGrid();

                    //Disable buttons
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtUnitID.Clear();
                    txtName.Clear();
                    txtDescription.Clear();
                   
                    grdUnits.Enabled = true;
                    btnAdd.Text = "Add";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //Enable buttons
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any unit from grid
                btnAdd.Text = "Save?";
                grdUnits.ClearSelection();
                grdUnits.Enabled = false;
            }
        }


        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (txtUnitID.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid Unit ID. Max 10 Characters.";
            if (txtName.Text.Length == 0)
                ErrorMsg += Environment.NewLine + "Please enter a valid Unit name.";
            
            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Unit Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void grdUnits_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUnits.SelectedCells.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = grdUnits.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
            string selectedunitid = grdUnits.Rows[selectedrowindex].Cells[0].Value.ToString(); //fetch the ID in that row
            DialogResult response = MessageBox.Show("Delete Unit: " + selectedunitid + "?", //confirm with user
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand("UC1_8_Delete_Unit", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("unitid", selectedunitid);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                getUnits();
                populateUnitGrid();
                MessageBox.Show("Unit Deleted");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Logic and functions for save button
            if (btnEdit.Text == "Update?")
            {
                //Command to add Unit
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC1_6_Update_Unit", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("Unitid", txtUnitID.Text);
                    cmd.Parameters.Add("fname", txtName.Text);
                    cmd.Parameters.Add("sname", txtDescription.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //Repopulate Grid and notify user
                    getUnits();
                    populateUnitGrid();
                    MessageBox.Show("Unit Updated");

                    //Disable textboxes
                    gbIdentifyingInformation.Enabled = false;
                    gbDetails.Enabled = false;

                    //Enable other buttons
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    //Clear textboxes
                    txtUnitID.Clear();
                    txtName.Clear();
                    txtDescription.Clear();
                    
                    grdUnits.Enabled = true;
                    btnEdit.Text = "Edit";
                    Console.WriteLine(btnAdd.Text); //wut
                }
            }
            else
            {
                //loading data into textboxes: find the row, load the data from the datagridset
                int selectedrowindex = grdUnits.SelectedCells[0].RowIndex; //find the selected row (is only ever one)
                txtUnitID.Text = grdUnits.Rows[selectedrowindex].Cells[0].Value.ToString();
                txtName.Text = grdUnits.Rows[selectedrowindex].Cells[1].Value.ToString();
                txtDescription.Text = grdUnits.Rows[selectedrowindex].Cells[2].Value.ToString();

                //Enable textboxes
                gbIdentifyingInformation.Enabled = true;
                gbDetails.Enabled = true;

                //Disable other buttons
                //gbIdentifyingInformation.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                //Change button text and deselect any unit from grid
                btnEdit.Text = "Update?";
                grdUnits.ClearSelection();
                grdUnits.Enabled = false;
            }
        }
    }
}
