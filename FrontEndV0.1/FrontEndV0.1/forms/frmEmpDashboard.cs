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

    public partial class frmEmpDashboard : Form
    {
        private frmEmpDetails frmEmpDetails = null;
        private frmStuDetails frmStuDetails = null;
        private frmUnits frmUnits = null;
        private frmUnitOfferings frmUnitOfferings = null;
        private frmAdminOperations frmAdminOps = null; //not used?
        private frmConvenorOperations frmConvAssessMaster = null;
        private frmSupervisorOperations frmSupMngMeetings = null;

        public frmEmpDashboard(string usertype)
        {
            InitializeComponent();

            //Enable menus based on user's type --> except a user may have many types
            if (usertype == "admin")
                administratorFunctionsToolStripMenuItem.Enabled = true;

            if (usertype == "supervisor")
                supervisorFunctionsToolStripMenuItem.Enabled = true;

            if (usertype == "convenor")
                convenorFunctionsToolStripMenuItem.Enabled = true;

            ////Form load, instantiate subforms
            //frmEmpDetails = null;
            //frmStuDetails = null;
            //frmUnits = null;
            //frmAdminOps = null;
            //frmConvAssessMaster = null;
            //frmSupMngMeetings = null;
        }

       

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpDetails == null)
            {
                frmEmpDetails = new frmEmpDetails();
                frmEmpDetails.FormClosing += frmEmpDetailsClosing;
                frmEmpDetails.MdiParent = this;
                frmEmpDetails.Visible = true;
            }
        }

        private void frmEmpDetailsClosing(object sender, FormClosingEventArgs e)
        {

            //frmEmpDetails = null;
            //frmEmpDetails.Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmUnitsClosing(object sender, FormClosingEventArgs e)
        {
            frmUnits = null;
        }

        private void frmUnitOfferingsClosing(object sender, FormClosingEventArgs e)
        {
            frmUnits = null;
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStuDetails == null)
            {
                frmStuDetails = new frmStuDetails();
                frmStuDetails.FormClosing += frmAdminOperationsClosing;
                frmStuDetails.MdiParent = this;
                frmStuDetails.Visible = true;
            }
            else
            {
                frmStuDetails.Visible = true;
            }

            /*if (frmAdminOps == null)
            {
                frmAdminOps = new frmAdminOperations();
                frmAdminOps.FormClosing += frmAdminOperationsClosing;
                frmAdminOps.MdiParent = this;
                frmAdminOps.Visible = true;
            }*/
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

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpDetails == null)
            {
                frmEmpDetails = new frmEmpDetails();
                frmEmpDetails.FormClosing += frmEmpDetailsClosing;
                frmEmpDetails.MdiParent = this;
                frmEmpDetails.Visible = true;
            }
        }

        private void manageUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUnits == null)
            {
                frmUnits = new frmUnits();
                frmUnits.FormClosing += frmUnitsClosing;
                frmUnits.MdiParent = this;
                frmUnits.Visible = true;
            }
        }

        private void manageUnitOfferingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUnitOfferings == null)
            {
                frmUnitOfferings = new frmUnitOfferings();
                frmUnitOfferings.FormClosing += frmUnitOfferingsClosing;
                frmUnitOfferings.MdiParent = this;
                frmUnitOfferings.Visible = true;
            }
        }


    }
}
