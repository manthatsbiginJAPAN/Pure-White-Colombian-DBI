using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client; //Libraries to hook into Swinburne Oracle

namespace FrontEndV0._1
{
    using forms;
    public partial class frmDBLogin : Form
    {

        public frmDBLogin()
        {
            InitializeComponent();
        }       


        private void btnLogin_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Connection created successfully");
            frmEmpDashboard frm = new frmEmpDashboard();    
            //frmLogin frm = new frmLogin();
            frm.Show();
        }

    }
}
