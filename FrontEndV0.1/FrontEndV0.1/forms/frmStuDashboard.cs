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

    public partial class frmStuDashboard : Form
    {
        private frmStuDetails frmStuDetails;
        private frmEnrolments frmEnrolments;
        private frmProject frmProject;
        private frmTeamDetails frmTeamDetails;
        private frmMeeting frmMeeting;
        private frmStuAssessment frmStuAssessment;

        public frmStuDashboard(string user, string firstName)
        {
            InitializeComponent();
            this.Text = ("Welcome " + firstName + "!");

            //Form load, instantiate subforms
            frmStuDetails = new frmStuDetails(user, false);
            frmStuDetails.MdiParent = this;

            frmEnrolments = new frmEnrolments(user, false);
            frmEnrolments.MdiParent = this;

            frmProject = new frmProject(user, false, false);
            frmProject.MdiParent = this;

            frmTeamDetails = new frmTeamDetails(user, false, false);
            frmTeamDetails.MdiParent = this;

            frmMeeting = new frmMeeting(user, false);
            frmMeeting.MdiParent = this;

            frmStuAssessment = new frmStuAssessment(user);
            frmStuAssessment.MdiParent = this;
        }

        private void CloseAllChildForms()
        {
            if (frmStuDetails != null)
                frmStuDetails.Hide();

            if (frmEnrolments != null)
                frmEnrolments.Hide();

            if (frmMeeting != null)
                frmMeeting.Hide();

            if (frmTeamDetails != null)
                frmTeamDetails.Hide();

            if (frmProject != null)
                frmProject.Hide();

            if (frmStuAssessment != null)
                frmStuAssessment.Hide();
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            //Explicit casting sender to Form to allow use of Hide()
            Form frm = (Form)sender;
            frm.Hide();
        }

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuDetails.FormClosing += closeForm;
            frmStuDetails.Show();
        }

        private void enrolmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnrolments.FormClosing += closeForm;
            frmEnrolments.Show();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProject.FormClosing += closeForm;
            frmProject.Show();
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeamDetails.FormClosing += closeForm;
            frmTeamDetails.Show();
        }

        private void meetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeeting.FormClosing += closeForm;
            frmMeeting.Show();
        }

        private void assessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuAssessment.FormClosing += closeForm;
            frmStuAssessment.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            this.Close();
        }

    }
}
