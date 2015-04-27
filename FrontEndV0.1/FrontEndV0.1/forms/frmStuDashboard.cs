﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontEndV0._1.forms
{

    public partial class frmStuDashboard : Form
    {
        private frmStuDetails frmStuDetails;
        private frmAdminOperations frmAdminOps;
        private frmConvenorOperations frmConvAssessMaster;
        private frmSupervisorOperations frmSupMngMeetings;

        public frmStuDashboard(string usertype)
        {
            InitializeComponent();

            //Enable menus based on user's type --> except a user may have many types
            if (usertype == "admin")
                administratorFunctionsToolStripMenuItem.Enabled = true;

            if (usertype == "supervisor")
                supervisorFunctionsToolStripMenuItem.Enabled = true;

            if (usertype == "convenor")
                convenerFunctionsToolStripMenuItem.Enabled = true;

            //Form load, instantiate subforms
            frmStuDetails = null;
            frmAdminOps = null;
            frmConvAssessMaster = null;
            frmSupMngMeetings = null;
        }



        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStuDetails == null)
            {
                frmStuDetails = new frmStuDetails();
                frmStuDetails.FormClosing += frmStuDetailsClosing;
                frmStuDetails.MdiParent = this;
                frmStuDetails.Visible = true;
            }
        }

        private void frmStuDetailsClosing(object sender, FormClosingEventArgs e)
        {
            frmStuDetails = null;
        }

        

        private void administratorFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (frmAdminOps == null)
            {
                frmAdminOps = new frmAdminOperations();
                frmAdminOps.FormClosing += frmAdminOperationsClosing;
                frmAdminOps.MdiParent = this;
                frmAdminOps.Visible = true;
            }*/
        }

        private void frmAdminOperationsClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminOps = null;
        }

        private void frmConvOpsClosing(object sender, FormClosingEventArgs e)
        {
            frmConvAssessMaster = null;
        }

        private void frmSupOpsClosing(object sender, FormClosingEventArgs e)
        {
            frmSupMngMeetings = null;
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdminOps == null)
            {
                frmAdminOps = new frmAdminOperations();
                frmAdminOps.FormClosing += frmAdminOperationsClosing;
                frmAdminOps.MdiParent = this;
                frmAdminOps.Visible = true;
            }
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConvAssessMaster == null)
            {
                frmConvAssessMaster = new frmConvenorOperations();
                frmConvAssessMaster.FormClosing += frmConvOpsClosing;
                frmConvAssessMaster.MdiParent = this;
                frmConvAssessMaster.Visible = true;
            }
        }

        private void manageMeetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSupMngMeetings == null)
            {
                frmSupMngMeetings = new frmSupervisorOperations();
                frmSupMngMeetings.FormClosing += frmSupOpsClosing;
                frmSupMngMeetings.MdiParent = this;
                frmSupMngMeetings.Visible = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}