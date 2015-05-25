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
    public partial class frmAgenda : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");

        private DataSet agendas;

        private string MeetingID;
        private string TeamID;
        private string UnitID;
        private string Semester;
        private string Year;

        private frmMeeting _parent;

        public frmAgenda(frmMeeting parent, string meetingID, string teamID, string unitID, string semester, string year)
        {
            InitializeComponent();
            connection = conn.oraConn();

            _parent = parent;
            MeetingID = meetingID;
            TeamID = teamID;
            UnitID = unitID;
            Semester = semester;
            Year = year;
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            getAgendaItems();

            populateAgendasGrid();
        }

        private void getAgendaItems()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC3_10_View_AgendaItem", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("agendacursor", OracleDbType.RefCursor);
            cmd.Parameters["agendacursor"].Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("meetid", Convert.ToInt16(MeetingID));
            cmd.Parameters.Add("teamid", TeamID);
            cmd.Parameters.Add("unitid", UnitID);
            cmd.Parameters.Add("semester", Convert.ToInt16(Semester));
            cmd.Parameters.Add("year", Convert.ToInt16(Year));

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            agendas = new DataSet();

            da.Fill(agendas, "agendacursor", (OracleRefCursor)(cmd.Parameters["agendacursor"].Value));

            connection.Close();
        }

        private void populateAgendasGrid()
        {
            //Clear the grid
            grdAgendaItems.Rows.Clear();

            //Populate the grid from the dataset
            int rowcnt = agendas.Tables[0].Rows.Count;


            for (int i = 0; i <= rowcnt - 1; i++)
            {
                object[] items = agendas.Tables[0].Rows[i].ItemArray;
                grdAgendaItems.Rows.Add(new object[] { items[5], items[6]});
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Save?")
            {
                //Command to add Unit
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC3_9_Add_AgendaItem", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("meetingid", Convert.ToInt16(MeetingID));
                    cmd.Parameters.Add("teamid", TeamID);
                    cmd.Parameters.Add("unitid", UnitID);
                    cmd.Parameters.Add("semester", Semester);
                    cmd.Parameters.Add("year", Year);
                    cmd.Parameters.Add("agendanum", Convert.ToInt16(txtAgendaNum.Text));
                    cmd.Parameters.Add("agendadesc", txtAgendaDesc.Text);

                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Added AgendaItem " + txtAgendaNum.Text);

                    //Repopulate data
                    getAgendaItems();
                    populateAgendasGrid();

                    //disable textboxes
                    txtAgendaDesc.Enabled = false;
                    txtAgendaNum.Enabled = false;
                    //clear textboxes
                    txtAgendaNum.Clear();
                    txtAgendaDesc.Clear();

                    //Enable buttons and grid
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    grdAgendaItems.Enabled = true;
                    btnAdd.Enabled = true;
                    btnAdd.Text = "Add";

                }
            }           
            else
            {
                btnAdd.Text = "Save?";
                btnAdd.Enabled = true;

                //enable textboxes and comboboxes
                txtAgendaNum.Enabled = true;
                txtAgendaDesc.Enabled = true;

                
                //disable buttons and grid
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                grdAgendaItems.Enabled = false;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Save?")
            {
                if (FormValidated())
                {
                    OracleCommand cmd = new OracleCommand("UC3_11_Update_AgendaItem", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("meetingid", Convert.ToInt16(MeetingID));
                    cmd.Parameters.Add("teamid", TeamID);
                    cmd.Parameters.Add("unitid", UnitID);
                    cmd.Parameters.Add("semester", Semester);
                    cmd.Parameters.Add("year", Year);
                    cmd.Parameters.Add("agendanum", Convert.ToInt16(txtAgendaNum.Text));
                    cmd.Parameters.Add("agendadesc", txtAgendaDesc.Text);

                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    

                    //Repopulate data
                    getAgendaItems();
                    populateAgendasGrid();

                    //disable textboxes
                    txtAgendaDesc.Enabled = false;
                    txtAgendaNum.Enabled = false;
                    //clear textboxes
                    txtAgendaNum.Clear();
                    txtAgendaDesc.Clear();

                    //Enable buttons and grid
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    grdAgendaItems.Enabled = true;
                    btnAdd.Enabled = true;
                    btnEdit.Text = "Edit";
                }

            }

            else
            {
                btnEdit.Text = "Save?";

                //enable textboxes and comboboxes
                //txtAgendaNum.Enabled = true;
                txtAgendaDesc.Enabled = true;

                
                //enable / disable buttons and grid
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = false;
                grdAgendaItems.Enabled = false;

                int selectedrow = grdAgendaItems.SelectedCells[0].RowIndex;


                int rowcnt = agendas.Tables["agendacursor"].Rows.Count;

                for (int i = 0; i <= rowcnt - 1; i++)
                {
                    object[] items = agendas.Tables[0].Rows[i].ItemArray;

                    //Checking if selected meeting matches in the dataset
                    if (Convert.ToString(items[5]) == grdAgendaItems.Rows[selectedrow].Cells[0].Value.ToString())
                    {
                        //Fill form controls with data to be updated

                        txtAgendaNum.Text = items[5].ToString();
                        txtAgendaDesc.Text = items[6].ToString();


                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("UC3_12_Delete_AgendaItem", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            string agendaid = grdAgendaItems.SelectedRows[0].Cells[0].Value.ToString();

            cmd.Parameters.Add("meetingid", Convert.ToInt16(MeetingID));
            cmd.Parameters.Add("teamid", TeamID);
            cmd.Parameters.Add("unitid", UnitID);
            cmd.Parameters.Add("semester", Semester);
            cmd.Parameters.Add("year", Year);
            cmd.Parameters.Add("agendanum", agendaid);


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Agenda Item " + agendaid + " deleted.");

            getAgendaItems();
            populateAgendasGrid();

        }

        private bool FormValidated()
        {
            //Track a cummulative error message, appending when a particular condition is not met
            string ErrorMsg = null;

            if (txtAgendaNum.Text == null)
                ErrorMsg += Environment.NewLine + "Please enter a Agenda Number.";

            if (txtAgendaDesc.Text == null)
                ErrorMsg += Environment.NewLine + "Please enter an Agenda Description";

            if (ErrorMsg != null)
            {
                MessageBox.Show(ErrorMsg, "Agenda Item information invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
