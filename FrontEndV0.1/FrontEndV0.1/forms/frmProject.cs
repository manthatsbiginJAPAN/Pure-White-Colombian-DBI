﻿using System;
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
    public partial class frmProject : Form
    {
        private OracleConnection connection;
        private Connection conn = new Connection("s7663285", "123");
        private DataSet unitoffs;
        private DataSet projects;

        public frmProject()
        {
            InitializeComponent();
            connection = conn.oraConn();
        }



        private void frmProject_Load(object sender, EventArgs e)
        {
            getProjects();
            getUnitOfferings();

            populateProjects();
            populateUnitOfferings();
        }

        private void getProjects()
        {
            //Oracle Command to populate the dataset
            OracleCommand cmd = new OracleCommand("UC2_7_View_Project", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("projcursor", OracleDbType.RefCursor);
            cmd.Parameters["projoffcursor"].Direction = ParameterDirection.ReturnValue;

            connection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            projects = new DataSet();

            da.Fill(projects, "projoffcursor", (OracleRefCursor)(cmd.Parameters["projoffcursor"].Value));

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


        private void populateUnitOfferings()
        {
            //Clear the grid
            grdProjects.ClearSelection();

            //Populate the grid from the dataset
            int rowcnt = unitoffs.Tables["unitoffcursor"].Rows.Count;
            MessageBox.Show("Available Unit Offerings: " + rowcnt.ToString());
            string unitid;
            int sem;
            int year;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                unitid = cbUnitID.ToString();
                sem = Convert.ToInt16(cbSemester.ToString());
                year = Convert.ToInt16(cbYear.ToString());

                //unitid = unitoffs.Tables["unitoffcursor"].Rows[i][0].ToString();
                //sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();
                //year = unitoffs.Tables["unitoffcursor"].Rows[i][2].ToString();

                if (!cbUnitID.Items.Contains(unitid))
                    cbUnitID.Items.Add(unitid);
                if (!cbSemester.Items.Contains(sem))
                    cbSemester.Items.Add(sem);
                if (!cbYear.Items.Contains(year))
                    cbYear.Items.Add(year);

                //cbUnitID.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][0].ToString());
                //cbSemester.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][1].ToString());
                //cbYear.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][2]);
            }
        }


        private void populateProjects()
        {
            //Clear the grid
            grdProjects.ClearSelection();

            //Populate the grid from the dataset
            int rowcnt = projects.Tables["projcursor"].Rows.Count;
            MessageBox.Show("Available Enrolments: " + rowcnt.ToString());
            string stuid;
            string unitid;
            int sem;
            int year;

            for (int i = 0; i <= rowcnt - 1; i++)
            {
                stuid = txtProjID.Text.ToString();
                unitid = cbUnitID.ToString();
                sem = Convert.ToInt16(cbSemester.ToString());
                year = Convert.ToInt16(cbYear.ToString());

                //unitid = unitoffs.Tables["unitoffcursor"].Rows[i][0].ToString();
                //sem = unitoffs.Tables["unitoffcursor"].Rows[i][1].ToString();
                //year = unitoffs.Tables["unitoffcursor"].Rows[i][2].ToString();

                //if (!cbUnitID.Items.Contains(unitid))
                //    cbUnitID.Items.Add(unitid);
                //if (!cbSemester.Items.Contains(sem))
                //    cbSemester.Items.Add(sem);
                //if (!cbYear.Items.Contains(year))
                //    cbYear.Items.Add(year);

                //cbUnitID.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][0].ToString());
                //cbSemester.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][1].ToString());
                //cbYear.Items.Add(unitoffs.Tables["unitoffscursor"].Rows[i][2]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Logic and functions for save button
          //  if (btnAdd.Text == "Save?")
           // {
                //Command to add Unit
             //   if (FormValidated())
               // {
                    OracleCommand cmd = new OracleCommand("UC1_5_Register_Unit", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("projid", txtProjID.Text);
                    cmd.Parameters.Add("projdesc", txtProjDesc.Text);
                    cmd.Parameters.Add("unitid", cbUnitID.Text);
                    cmd.Parameters.Add("semester", cbSemester.Text);
                    cmd.Parameters.Add("year", cbYear.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    projects.Tables[0].Rows.Add(txtProjID.SelectedItem
                        , txtProjDesc.SelectedItem
                        , cbYear.SelectedItem
                        , cbConvenor.SelectedItem);

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
                //}
            //}
            //else
            //{
                //Enable buttons
              //  gbIdentifyingInformation.Enabled = true;
                //gbDetails.Enabled = true;

                //Disable other buttons
                //btnEdit.Enabled = false;
                //btnDelete.Enabled = false;

                //Change button text and deselect any unit from grid
                //btnAdd.Text = "Save?";
                //grdUnits.ClearSelection();
                //grdUnits.Enabled = false;
            //}
        }
    }
}
