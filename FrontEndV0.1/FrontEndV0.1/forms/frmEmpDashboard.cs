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

        public frmEmpDashboard()
        {
            InitializeComponent();

            //Form load, instantiate subforms
            frmEmpDetails = null;
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

        }

        private void convenerFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supervisorFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
