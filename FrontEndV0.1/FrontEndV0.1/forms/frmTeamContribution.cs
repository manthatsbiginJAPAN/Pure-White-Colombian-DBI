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
    public partial class frmTeamContribution : Form
    {
        private frmAssessment _parent;

        public frmTeamContribution(frmAssessment parent)
        {
            InitializeComponent();

            _parent = parent;

            _parent.populateAssGrid(this.grdAssessmentsInfo);
        }


    }
}
