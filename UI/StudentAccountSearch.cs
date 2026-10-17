using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class StudentAccountSearch : Form
    {
        private readonly StudentSearchController _searchController = new StudentSearchController();
        public StudentAccountSearch()
        {
            InitializeComponent();
            this.Load += StudentAccountSearch_Load;
            btnSearch.Click += btnSearch_Click;
        }

        private void StudentAccountSearch_Load(object sender, EventArgs e)
        {
            ClearLabels();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a Student ID or Name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var profile = _searchController.SearchStudent(keyword);

            if (profile != null)
            {
                lblStudentID.Text = profile.StudentId;
                lblStudentName.Text = profile.FullName;
                lblDateofBirth.Text = profile.DateOfBirth;
                lblGender.Text = profile.Gender;
                lblAddress.Text = profile.Address;
                lblSchoolYear.Text = profile.SchoolYear;
                lblGradeLevel.Text = profile.GradeLevel;
                lblSection.Text = profile.Section;

                lblTotalAssessment.Text = profile.TotalAssessment.ToString("N2");
                lblTotalPaid.Text = profile.TotalPaid.ToString("N2");
                lblRemainingBalance.Text = profile.RemainingBalance.ToString("N2");
            }
            else
            {
                MessageBox.Show("No student found matching that ID or Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearLabels();
            }
        }

        private void ClearLabels()
        {
            lblStudentID.Text = "---";
            lblStudentName.Text = "---";
            lblDateofBirth.Text = "---";
            lblGender.Text = "---";
            lblAddress.Text = "---";
            lblSchoolYear.Text = "---";
            lblGradeLevel.Text = "---";
            lblSection.Text = "---";
            lblTotalAssessment.Text = "0.00";
            lblTotalPaid.Text = "0.00";
            lblRemainingBalance.Text = "0.00";
        }
    }
}
