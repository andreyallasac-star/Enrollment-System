using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class AssessmentForm : Form
    {
        private readonly AssessmentController _assessmentController = new AssessmentController();
        private readonly StudentSearchController _searchController = new StudentSearchController();
        private string _currentSchoolYear = "";
        public AssessmentForm()
        {
            InitializeComponent();
            txtTuitionFee.ReadOnly = true;
            txtTuitionFee.BackColor = System.Drawing.SystemColors.Control;
            txtOtherFee.Text = "0.00";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FetchStudentDetails();
        }

        private void FetchStudentDetails()
        {
            string studentId = txtStudentId.Text.Trim();
            if (string.IsNullOrWhiteSpace(studentId)) return;

            var profile = _searchController.SearchStudent(studentId);

            if (profile != null)
            {
                lblStudentName.Text = profile.FullName;
                lblGrade.Text = profile.GradeLevel;
                lblSection.Text = profile.Section;

                _currentSchoolYear = profile.SchoolYear;

                lblStatus.Text = (profile.SchoolYear == "Not Enrolled") ? "Not Enrolled" : "Enrolled";
            }
            else
            {
                MessageBox.Show("Student not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string gradeLevel = lblGrade.Text;

            if (gradeLevel == "<Label>" || gradeLevel == "---" || gradeLevel == "N/A")
            {
                MessageBox.Show("Please enter a valid, enrolled Student ID first.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal officialTuition = _assessmentController.ComputeTuition(gradeLevel, _currentSchoolYear);
            txtTuitionFee.Text = officialTuition.ToString("F2");

            decimal otherFees = 0;
            decimal.TryParse(txtOtherFee.Text, out otherFees);

            decimal total = officialTuition + otherFees;
            lblTotalAssessment.Text = total.ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal totalAssessment = 0;
            decimal.TryParse(lblTotalAssessment.Text, out totalAssessment);

            decimal tuitionFee = 0;
            decimal.TryParse(txtTuitionFee.Text, out tuitionFee);

            decimal otherFee = 0;
            decimal.TryParse(txtOtherFee.Text, out otherFee);

            var newAssessment = new Assessment
            {
                StudentId = txtStudentId.Text,
                SchoolYear = _currentSchoolYear,
                TuitionFee = tuitionFee,
                OtherFee = otherFee,
                TotalAssessment = totalAssessment
            };

            string result = _assessmentController.SaveAssessment(newAssessment);

            if (result == "Success")
            {
                MessageBox.Show("Assessment successfully saved!\n\nThe student can now proceed to the Cashier.", "Core Integration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show(result, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtTuitionFee.Clear();
            txtOtherFee.Text = "0.00";

            dateTimePicker1.Value = DateTime.Now;

            lblStudentName.Text = "<Label>";
            lblGrade.Text = "<Label>";
            lblSection.Text = "<Label>";
            lblStatus.Text = "<Label>";
            lblTotalAssessment.Text = "<Label>";

            _currentSchoolYear = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
