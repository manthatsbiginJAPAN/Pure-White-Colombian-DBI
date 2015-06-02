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
        private frmAssessment frmAssessment = null;
        private frmMeeting frmMeeting = null;
        private frmTeamDetails frmTeamDetails = null;
        private frmProject frmProject = null;
        private frmReports frmReports = null;       
        private string User;

        public frmEmpDashboard(string user, string firstName, bool isAdmin, bool isConvenor, bool isSupervisor)
        {
            InitializeComponent();
            User = user;
            this.Text = ("Welcome " + firstName + "!");

            //for testing: MessageBox.Show("Form initialised. isAdmin: " + isAdmin + "; isConvenor: " + isConvenor + "; isSupervisor: " + isSupervisor);

            //Enable menus based on user's type --> except a user may have many types
            if (isAdmin) //(user == "admin")
            {
                administratorFunctionsToolStripMenuItem.Enabled = true;

                frmStuDetails = new frmStuDetails(user, isAdmin); //to be updated soon...
                frmStuDetails.MdiParent = this;

                frmUnits = new frmUnits(true);
                frmUnits.MdiParent = this;

                frmUnitOfferings = new frmUnitOfferings(user, isAdmin);
                frmUnitOfferings.MdiParent = this;

                frmEnrolments = new frmEnrolments(user, isAdmin);
                frmEnrolments.MdiParent = this;

                frmReports = new frmReports(user, isAdmin);
                frmUnits.MdiParent = this;
            }
            else
            {
                administratorFunctionsToolStripMenuItem.Enabled = false;
            }

            if (isSupervisor) //(user == "supervisor")
            {
                supervisorFunctionsToolStripMenuItem.Enabled = true;

                frmMeeting = new frmMeeting(user, isSupervisor);
                frmMeeting.MdiParent = this;

                frmAssessment = new frmAssessment(user, isConvenor, isSupervisor);
                frmAssessment.MdiParent = this;

                frmTeamDetails = new frmTeamDetails(user, isConvenor, isSupervisor);
                frmTeamDetails.MdiParent = this;

                frmProject = new frmProject(user, isConvenor, isSupervisor);
                frmProject.MdiParent = this;
            }
            else
            {
                supervisorFunctionsToolStripMenuItem.Enabled = false;
            }

            if (isConvenor) //(user == "convenor")
            {
                convenorFunctionsToolStripMenuItem.Enabled = true;

                frmAssessment = new frmAssessment(user, isConvenor, isSupervisor);
                frmAssessment.MdiParent = this;

                frmTeamDetails = new frmTeamDetails(user, isConvenor, isSupervisor);
                frmTeamDetails.MdiParent = this;

                //ensures that the frmUnits won't be overwritten if the user is also an admin
                if (!isAdmin)
                {
                    frmUnits = new frmUnits(false);
                    frmUnits.MdiParent = this;
                }

                //ensures that the frmUnitOfferings won't be overwritten if the user is also an admin
                if (!isAdmin)
                {
                    frmUnitOfferings = new frmUnitOfferings(user, isAdmin);
                    frmUnitOfferings.MdiParent = this;
                }

                frmProject = new frmProject(user, isConvenor, isSupervisor);
                frmProject.MdiParent = this;
            }
            else
            {
                convenorFunctionsToolStripMenuItem.Enabled = false;
            }

            frmEmpDetails = new frmEmpDetails(user, isAdmin);
            frmEmpDetails.MdiParent = this;
        }

        private void CloseAllChildForms()
        {
            if (frmEmpDetails != null)
                frmEmpDetails.Hide();

            if (frmStuDetails != null)
                frmStuDetails.Hide();

            if (frmUnits != null)
                frmUnits.Hide();

            if (frmEnrolments != null)
                frmEnrolments.Hide();
            
            if (frmUnitOfferings != null)
                frmUnitOfferings.Hide();

            if (frmAssessment != null)
                frmAssessment.Hide();

            if (frmMeeting != null)
                frmMeeting.Hide();

            if (frmTeamDetails != null)
                frmTeamDetails.Hide();

            if (frmProject != null)
                frmProject.Hide();

            if (frmReports != null)
                frmReports.Hide();
        }

        #region Form Toggles

        private void openUnitForm()
        {
            frmUnits.FormClosing += closeForm;
            frmUnits.Show();
        }

        private void openAssessmentForm()
        {
            frmAssessment.FormClosing += closeForm;
            frmAssessment.Show();
        }

        private void openTeamForm()
        {
            frmTeamDetails.FormClosing += closeForm;
            frmTeamDetails.Show();
        }

        private void openProjectForm()
        {
            frmProject.FormClosing += closeForm;
            frmProject.Show();
        }

        private void openUnitOfferingForm()
        {
            frmUnitOfferings.FormClosing += closeForm;
            frmUnitOfferings.Show();
        }

        private void openMeetingForm()
        {
            frmMeeting.FormClosing += closeForm;
            frmMeeting.Show();
        }

        private void openStudentForm()
        {
            frmStuDetails.FormClosing += closeForm;
            frmStuDetails.Show();
        }

        private void openEmployeeForm()
        {
            frmEmpDetails.FormClosing += closeForm;
            frmEmpDetails.Show();
        }

        private void openReportsForm()
        {
            frmReports.FormClosing += closeForm;
            frmReports.Show();
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            //Explicit casting sender to Form to allow use of Hide()
            Form frm = (Form)sender;
            frm.Hide();
        }
        #endregion

        #region Personal Details
        private void personalDetailsMenu_Click(object sender, EventArgs e)
        {
            frmEmpDetails = new frmEmpDetails(User, false);
            frmEmpDetails.MdiParent = this;
            openEmployeeForm();
        }
        #endregion

        #region Admin Functions

        #region Manage Students
        private void adminDropdownManageStudents_Click(object sender, EventArgs e)
        {
            openStudentForm();
        }

        #endregion

        #region Manage Employees
        private void adminDropdownManageEmployees_Click(object sender, EventArgs e)
        {
            frmEmpDetails = new frmEmpDetails(User, true);
            frmEmpDetails.MdiParent = this;
            openEmployeeForm();
        }

        //When Manage Employees becomes separate to employee details, put the new event handler here - Eric
        #endregion

        #region Manage Units
        private void adminDropdownManageUnits_Click(object sender, EventArgs e)
        {
            openUnitForm();
        }
        #endregion

        #region Manage Unit Offerings
        private void adminDropdownManageUnitOfferings_Click(object sender, EventArgs e)
        {
            frmUnitOfferings = new frmUnitOfferings(User, true);
            frmUnitOfferings.MdiParent = this;
            openUnitOfferingForm();
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

        #region Reports
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReportsForm();
        }
        #endregion

        #endregion

        #region Convenor Functions 
        private void convenorDropdownAssessmentMaster_Click(object sender, EventArgs e)
        {
            frmAssessment = new frmAssessment(User, true, false);
            frmAssessment.MdiParent = this;
            openAssessmentForm();
        }

        private void convenorDropdownMngTeams_Click(object sender, EventArgs e)
        {
            frmTeamDetails = new frmTeamDetails(User, true, false);
            frmTeamDetails.MdiParent = this;
            openTeamForm();
        }

        private void convenorDropdownViewUnits_Click(object sender, EventArgs e)
        {
            openUnitForm();
        }

        private void convenorDropdownUnitOfferings_Click(object sender, EventArgs e)
        {
            frmUnitOfferings = new frmUnitOfferings(User, false);
            frmUnitOfferings.MdiParent = this;
            openUnitOfferingForm();
        }
        
        private void convenorDropdownProjects_Click(object sender, EventArgs e)
        {
            frmProject = new frmProject(User, true, false);
            frmProject.MdiParent = this;
            openProjectForm();
        }

        private void allocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmStuAssessment = new frmStuAssessment(user)
            frmStuAssessment.MdiParent = this;
            openStuAssessmentForm();*/
        }

        

        #endregion

        #region Supervisor Functions
        private void convenorDropdownMngMeetings_Click(object sender, EventArgs e)
        {
            frmMeeting = new frmMeeting(User, true);
            frmMeeting.MdiParent = this;
            openMeetingForm();
        }

        private void viewAssessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssessment = new frmAssessment(User, false, true);
            frmAssessment.MdiParent = this;
            openAssessmentForm();
        }

        private void viewTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeamDetails = new frmTeamDetails(User, false, true);
            frmTeamDetails.MdiParent = this;
            openTeamForm();
        }

        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProject = new frmProject(User, true, false);
            frmProject.MdiParent = this;
            openProjectForm();
        }

        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            this.Close();
        }

        


    }
}
