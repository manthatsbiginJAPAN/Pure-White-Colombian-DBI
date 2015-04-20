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
        private frmEmpDetails frmEmpDetails;
        private frmAdminOperations frmAdminOps;
        private frmConvenorOperations frmConvOps;
        private frmSupervisorOperations frmSupOps;

        public frmEmpDashboard()
        {
            InitializeComponent();

            //Form load, instantiate subforms
            frmEmpDetails = null;
            frmAdminOps = null;
            frmConvOps = null;
            frmSupOps = null;
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
            frmEmpDetails = null;
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

        private void convenerFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConvOps == null)
            {
                frmConvOps = new frmConvenorOperations();
                frmConvOps.FormClosing += frmConvOpsClosing;
                frmConvOps.MdiParent = this;
                frmConvOps.Visible = true;
            }
        }

        private void frmConvOpsClosing(object sender, FormClosingEventArgs e)
        {
            frmConvOps = null;
        }

        private void supervisorFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSupOps == null)
            {
                frmSupOps = new frmSupervisorOperations();
                frmSupOps.FormClosing += frmSupOpsClosing;
                frmSupOps.MdiParent = this;
                frmSupOps.Visible = true;
            }
        }

        private void frmSupOpsClosing(object sender, FormClosingEventArgs e)
        {
            frmSupOps = null;
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


    }
}
