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
    public partial class frmAgenda : Form
    {
        private string MeetingID;

        public frmAgenda(string meetingID, string TeamID, )
        {
            InitializeComponent();
            MeetingID = meetID;
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {

        }
    }
}
