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
        public frmEmpDashboard()
        {
            InitializeComponent();
        }

       

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmEmpDetails frm = new frmEmpDetails();
            frm.Show();
            frm.MdiParent = this;
            //frm.
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
