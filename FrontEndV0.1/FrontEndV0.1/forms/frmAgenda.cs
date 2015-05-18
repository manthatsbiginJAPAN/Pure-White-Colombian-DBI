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
        private string TeamID;
        private string UnitID;
        private string Semester;
        private string Year;

        public frmAgenda(string meetingID, string teamID, string unitID, string semester, string year)
        {
            InitializeComponent();
            MeetingID = meetingID;
            TeamID = teamID;
            UnitID = unitID;
            Semester = semester;
            Year = year;
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {

        }
    }
}
