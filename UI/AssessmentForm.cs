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
                label1.Text = profile.FullName;
                lblStudentName.Text = profile.GradeLevel;
                lblGradeYearLevel.Text = profile.Section;
            }
            else
            {
                label1.Text = "Student not found";
                lblStudentName.Text = "---";
                lblGradeYearLevel.Text = "---";
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string gradeLevel = lblStudentName.Text;
            string schoolYear = "2026-2027";

            if (gradeLevel == "<Label>" || gradeLevel == "---")
            {
                MessageBox.Show("Please enter a valid Student ID first.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal officialTuition = _assessmentController.ComputeTuition(gradeLevel, schoolYear);
            txtTuitionFee.Text = officialTuition.ToString("F2");

            decimal otherFees = 0;
            decimal.TryParse(txtOtherFee.Text, System.Globalization.NumberStyles.Any, null, out otherFees);

            decimal total = officialTuition + otherFees;
            lblStatus.Text = total.ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal totalAssessment = 0;
            decimal.TryParse(lblStatus.Text, out totalAssessment);

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
            txtPaymentMode.Clear();
            label1.Text = "<Label>";
            lblStudentName.Text = "<Label>";
            lblGradeYearLevel.Text = "<Label>";
            lblStatus.Text = "<Label>";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void lblStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
