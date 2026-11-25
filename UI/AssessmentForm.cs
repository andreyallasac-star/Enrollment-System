using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private string _currentStudentId = "";
        private bool _isEnrolled = false;

        public AssessmentForm()
        {
            InitializeComponent();
            txtTuitionFee.ReadOnly = true;
            txtTuitionFee.BackColor = System.Drawing.SystemColors.Control;
            txtOtherFee.Text = "0.00";

            SetAssessmentControlsEnabled(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FetchStudentDetails();
        }

        private void FetchStudentDetails()
        {
            string keyword = txtStudentId.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a Student ID.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var profile = _searchController.SearchStudent(keyword);

            if (profile == null)
            {
                MessageBox.Show("Student not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                return;
            }

            _currentStudentId = profile.StudentId;
            txtStudentId.Text = profile.StudentId;
            lblStudentName.Text = profile.FullName;
            lblGrade.Text = profile.GradeLevel;
            lblSection.Text = profile.Section;
            lblTotalAssessment.Text = "0.00";

            _isEnrolled = profile.SchoolYear != "Not Enrolled";
            _currentSchoolYear = _isEnrolled ? profile.SchoolYear : "";
            lblStatus.Text = _isEnrolled ? "Enrolled" : "Not Enrolled";

            if (!_isEnrolled)
            {
                txtTuitionFee.Text = "0.00";
                SetAssessmentControlsEnabled(false);
                MessageBox.Show("This student is not enrolled. Please enroll the student before assessment.", "Not Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal officialTuition = _assessmentController.ComputeTuition(profile.GradeLevel, _currentSchoolYear);
            txtTuitionFee.Text = officialTuition.ToString("F2");
            SetAssessmentControlsEnabled(true);

            if (officialTuition <= 0)
            {
                MessageBox.Show($"No tuition fee is configured for {profile.GradeLevel}. Please add a tuition fee before assessing this student.", "Tuition Fee Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            decimal tuitionFee = 0;
            decimal.TryParse(txtTuitionFee.Text, NumberStyles.Any, null, out tuitionFee);

            decimal otherFees = 0;
            if (!decimal.TryParse(txtOtherFee.Text, NumberStyles.Any, null, out otherFees) || otherFees < 0)
            {
                MessageBox.Show("Please enter a valid, non-negative amount for Other Fee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = tuitionFee + otherFees;
            lblTotalAssessment.Text = total.ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_isEnrolled || string.IsNullOrWhiteSpace(_currentStudentId))
            {
                MessageBox.Show("Please search for an enrolled student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tuitionFee = 0;
            decimal.TryParse(txtTuitionFee.Text, NumberStyles.Any, null, out tuitionFee);

            decimal otherFee = 0;
            if (!decimal.TryParse(txtOtherFee.Text, NumberStyles.Any, null, out otherFee) || otherFee < 0)
            {
                MessageBox.Show("Please enter a valid, non-negative amount for Other Fee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAssessment = tuitionFee + otherFee;
            lblTotalAssessment.Text = totalAssessment.ToString("F2");

            DialogResult confirm = MessageBox.Show(
                $"Confirm saving assessment for {lblStudentName.Text} ({_currentStudentId})?\n\n" +
                $"School Year: {_currentSchoolYear}\nTotal Assessment: PHP {totalAssessment:F2}",
                "Confirm Save Assessment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var newAssessment = new Assessment
            {
                StudentId = _currentStudentId,
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

        private void SetAssessmentControlsEnabled(bool enabled)
        {
            btnCompute.Enabled = enabled;
            btnSave.Enabled = enabled;
            txtOtherFee.Enabled = enabled;
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
            _currentStudentId = "";
            _isEnrolled = false;
            SetAssessmentControlsEnabled(false);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}