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
            lblDiscountAmount.Text = "0.00";
            lblTotalAssessment.Text = "0.00";

            LoadDiscounts();
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;

            SetAssessmentControlsEnabled(false);
        }

        private void LoadDiscounts()
        {
            var discounts = _assessmentController.GetActiveDiscounts();
            if (discounts == null || discounts.Count == 0)
            {
                discounts = new List<Discount>
                {
                    new Discount { DiscountId = 0, DiscountName = "None", DiscountPercent = 0m, IsActive = true }
                };
            }

            cmbDiscount.DataSource = null;
            cmbDiscount.DataSource = discounts;
            cmbDiscount.DisplayMember = "DisplayText";
            cmbDiscount.ValueMember = "DiscountPercent";
            cmbDiscount.SelectedIndex = 0;
        }

        private Discount GetSelectedDiscount()
        {
            if (cmbDiscount.SelectedItem is Discount selected)
                return selected;

            return new Discount { DiscountId = 0, DiscountName = "None", DiscountPercent = 0m, IsActive = true };
        }

        private bool TryCalculateAssessment(bool showValidationErrors, out decimal tuitionFee, out decimal otherFee, out Discount selectedDiscount, out decimal discountAmount, out decimal totalAssessment)
        {
            tuitionFee = 0m;
            decimal.TryParse(txtTuitionFee.Text, NumberStyles.Any, null, out tuitionFee);

            otherFee = 0m;
            selectedDiscount = GetSelectedDiscount();
            discountAmount = 0m;
            totalAssessment = 0m;

            if (!decimal.TryParse(txtOtherFee.Text, NumberStyles.Any, null, out otherFee) || otherFee < 0)
            {
                if (showValidationErrors)
                    MessageBox.Show("Please enter a valid, non-negative amount for Other Fee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            discountAmount = Math.Round(tuitionFee * (selectedDiscount.DiscountPercent / 100m), 2);
            totalAssessment = Math.Max(0m, tuitionFee + otherFee - discountAmount);

            lblDiscountAmount.Text = discountAmount.ToString("F2");
            lblTotalAssessment.Text = totalAssessment.ToString("F2");
            return true;
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isEnrolled || string.IsNullOrWhiteSpace(_currentStudentId))
                return;

            TryCalculateAssessment(false, out _, out _, out _, out _, out _);
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
            lblDiscountAmount.Text = "0.00";
            lblTotalAssessment.Text = "0.00";
            if (cmbDiscount.Items.Count > 0) cmbDiscount.SelectedIndex = 0;

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
            TryCalculateAssessment(true, out _, out _, out _, out _, out _);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_isEnrolled || string.IsNullOrWhiteSpace(_currentStudentId))
            {
                MessageBox.Show("Please search for an enrolled student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryCalculateAssessment(true, out decimal tuitionFee, out decimal otherFee, out Discount selectedDiscount, out decimal discountAmount, out decimal totalAssessment))
                return;

            DialogResult confirm = MessageBox.Show(
                $"Confirm saving assessment for {lblStudentName.Text} ({_currentStudentId})?\n\n" +
                $"School Year: {_currentSchoolYear}\n" +
                $"Tuition Fee: PHP {tuitionFee:F2}\n" +
                $"Other Fee: PHP {otherFee:F2}\n" +
                $"Discount: {selectedDiscount.DisplayText} (-PHP {discountAmount:F2})\n" +
                $"Total Assessment: PHP {totalAssessment:F2}",
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
                DiscountName = selectedDiscount.DiscountName,
                DiscountAmount = discountAmount,
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
            cmbDiscount.Enabled = enabled;
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtTuitionFee.Clear();
            txtOtherFee.Text = "0.00";

            dateTimePicker1.Value = DateTime.Now;

            lblStudentName.Text = "---";
            lblGrade.Text = "---";
            lblSection.Text = "---";
            lblStatus.Text = "---";
            lblDiscountAmount.Text = "0.00";
            lblTotalAssessment.Text = "0.00";

            if (cmbDiscount.Items.Count > 0)
                cmbDiscount.SelectedIndex = 0;

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