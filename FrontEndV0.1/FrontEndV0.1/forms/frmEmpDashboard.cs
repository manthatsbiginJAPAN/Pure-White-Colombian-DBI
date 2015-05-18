﻿using System;
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

        public frmEmpDashboard(string user, bool isAdmin, bool isConvenor, bool isSupervisor)
        {
            InitializeComponent();

            //for testing: MessageBox.Show("Form initialised. isAdmin: " + isAdmin + "; isConvenor: " + isConvenor + "; isSupervisor: " + isSupervisor);

            //Enable menus based on user's type --> except a user may have many types
            if (isAdmin) //(user == "admin")
            {
                administratorFunctionsToolStripMenuItem.Enabled = true;

                frmStuDetails = new frmStuDetails(user, isAdmin); //to be updated soon...
                frmStuDetails.MdiParent = this;

                frmUnits = new frmUnits(true);
                frmUnits.MdiParent = this;

                frmUnitOfferings = new frmUnitOfferings(true);
                frmUnitOfferings.MdiParent = this;

                frmEnrolments = new frmEnrolments(user, isAdmin);
                frmEnrolments.MdiParent = this;
            }
            else
            {
                administratorFunctionsToolStripMenuItem.Enabled = false;
            }

            if (isSupervisor) //(user == "supervisor")
            {
                supervisorFunctionsToolStripMenuItem.Enabled = true;

                frmMeeting = new frmMeeting();
                frmMeeting.MdiParent = this;

                frmAssessment = new frmAssessment(true);
                frmAssessment.MdiParent = this;

                frmTeamDetails = new frmTeamDetails(false);
                frmTeamDetails.MdiParent = this;

                frmProject = new frmProject(user, false, false);
                frmProject.MdiParent = this;
            }
            else
            {
                supervisorFunctionsToolStripMenuItem.Enabled = false;
            }

            if (isConvenor) //(user == "convenor")
            {
                convenorFunctionsToolStripMenuItem.Enabled = true;

                frmAssessment = new frmAssessment(true);
                frmAssessment.MdiParent = this;

                frmTeamDetails = new frmTeamDetails(true);
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
                    frmUnitOfferings = new frmUnitOfferings(false);
                    frmUnitOfferings.MdiParent = this;
                }

                frmProject = new frmProject(user, false, true);
                frmProject.MdiParent = this;
            }
            else
            {
                convenorFunctionsToolStripMenuItem.Enabled = false;
            }

            frmEmpDetails = new frmEmpDetails(user, isAdmin);
            frmEmpDetails.MdiParent = this;
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

        #endregion

        #region Convenor Functions 
        private void convenorDropdownAssessmentMaster_Click(object sender, EventArgs e)
        {
            openAssessmentForm();
        }

        private void convenorDropdownMngTeams_Click(object sender, EventArgs e)
        {
            openTeamForm();
        }

        private void convenorDropdownViewUnits_Click(object sender, EventArgs e)
        {
            openUnitForm();
        }

        private void convenorDropdownUnitOfferings_Click(object sender, EventArgs e)
        {
            openUnitOfferingForm();
        }
        
        private void convenorDropdownProjects_Click(object sender, EventArgs e)
        {
            openProjectForm();
        }

        #endregion

        #region Supervisor Functions
        private void convenorDropdownMngMeetings_Click(object sender, EventArgs e)
        {
            openMeetingForm();
        }

        private void viewAssessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAssessmentForm();
        }

        private void viewTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTeamForm();
        }

        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openProjectForm();
        }

        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
