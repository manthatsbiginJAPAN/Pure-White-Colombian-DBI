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
        private frmEnrolments frmEnrolments = null;
        private frmUnitOfferings frmUnitOfferings = null;

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

            //Form load, instantiate subforms
            frmEmpDetails = new frmEmpDetails();
            frmEmpDetails.MdiParent = this;

            frmStuDetails = new frmStuDetails();
            frmStuDetails.MdiParent = this;

            frmUnits = new frmUnits();
            frmUnits.MdiParent = this;

            frmUnitOfferings = new frmUnitOfferings();
            frmUnitOfferings.MdiParent = this;

            frmEnrolments = new frmEnrolments();
            frmEnrolments.MdiParent = this;
        }

        #region Personal Details
        private void personalDetailsMenu_Click(object sender, EventArgs e)
        {
            frmEmpDetails.FormClosing += frmEmpDetailsClosing;
            frmEmpDetails.Show();
        }

        private void frmEmpDetailsClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmEmpDetails.Hide();
        }
        #endregion

        #region Admin Functions

        #region Manage Students
        private void adminDropdownManageStudents_Click(object sender, EventArgs e)
        {
            frmStuDetails.FormClosing += frmStuDetailsClosing;
            frmStuDetails.Show();
        }

        private void frmStuDetailsClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmStuDetails.Hide();
        }
        #endregion

        #region Manage Employees
        private void adminDropdownManageEmployees_Click(object sender, EventArgs e)
        {
            frmEmpDetails.FormClosing += frmEmpDetailsClosing;
            frmEmpDetails.Show();
        }

        //When Manage Employees becomes separate to employee details, put the new event handler here - Eric
        #endregion

        #region Manage Units
        private void adminDropdownManageUnits_Click(object sender, EventArgs e)
        {
            frmUnits.FormClosing += frmUnitsClosing;
            frmUnits.Show();
        }

        private void frmUnitsClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmUnits.Hide();
        }
        #endregion

        #region Manage Unit Offerings
        private void adminDropdownManageUnitOfferings_Click(object sender, EventArgs e)
        {
            frmUnitOfferings.FormClosing += frmUnitOfferingsClosing;
            frmUnitOfferings.Show();
        }

        private void frmUnitOfferingsClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmUnitOfferings.Hide();
        }
        #endregion

        #region Manage Enrolments
        private void adminDropdownManageEnrolments_Click(object sender, EventArgs e)
        {
            frmEnrolments.FormClosing += frmEnrolmentsClosing;
            frmEnrolments.Show();
        }

        private void frmEnrolmentsClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmEnrolments.Hide();
        }
        #endregion

        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
