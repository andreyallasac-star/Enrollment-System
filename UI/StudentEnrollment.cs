using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class StudentEnrollment : Form
    {
        private readonly StudentSearchController _searchController = new StudentSearchController();
        private readonly SectionController _sectionController = new SectionController();
        private readonly EnrollmentController _enrollmentController = new EnrollmentController();
        private readonly AssessmentController _assessmentController = new AssessmentController();

        private string _currentStudentType = "";

        public StudentEnrollment()
        {
            InitializeComponent();
            cmbSection.SelectedIndexChanged += cmbSection_SelectedIndexChanged;
        }

        private void StudentEnrollment_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            ClearForm();
        }

        private void LoadDropdowns()
        {
            cmbSchoolYear.Items.Clear();
            foreach (var year in _sectionController.GetDistinctSchoolYears())
            {
                cmbSchoolYear.Items.Add(year);
            }

            cmbGradeLevel.Items.Clear();
            cmbGradeLevel.Items.AddRange(new string[] { "Grade 7", "Grade 8", "Grade 9", "Grade 10" });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void SearchStudent()
        {
            string keyword = txtStudentId.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword)) return;

            var profile = _searchController.SearchStudent(keyword);
            if (profile != null)
            {
                lblStudentId.Text = profile.StudentId;
                lblStudentName.Text = profile.FullName;
                lblDateOfBirth.Text = profile.DateOfBirth;
                lblGender.Text = profile.Gender;
                lblGradeLevel.Text = profile.GradeLevel;
                lblSection.Text = profile.Section;
                _currentStudentType = profile.StudentType ?? "";

                var activeEnrollment = _enrollmentController.GetActiveEnrollment(profile.StudentId);
                btnCancelEnrollment.Enabled = activeEnrollment != null;

                if (activeEnrollment != null)
                {
                    chkPSA.Checked = activeEnrollment.HasPSA;
                    chkForm138.Checked = activeEnrollment.HasForm138;
                    chkGoodMoral.Checked = activeEnrollment.HasGoodMoral;
                    chkForm137.Checked = activeEnrollment.HasForm137;
                    chkConditional.Checked = activeEnrollment.RequirementsStatus != "Complete";
                }
                else
                {
                    chkPSA.Checked = false;
                    chkForm138.Checked = false;
                    chkGoodMoral.Checked = false;
                    chkForm137.Checked = false;
                    chkConditional.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Student not found. Please check the ID, LRN, or Name.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void FilterSections(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
            ResetCapacityLabel();

            string selectedGrade = cmbGradeLevel.SelectedItem?.ToString();
            string selectedYear = cmbSchoolYear.SelectedItem?.ToString();

            if (selectedGrade == null || selectedYear == null) return;

            var sections = _sectionController.GetAllSections()
                .Where(s => s.GradeLevel == selectedGrade && s.SchoolYear == selectedYear && s.Status == "Active")
                .ToList();

            foreach (var sec in sections)
            {
                cmbSection.Items.Add(sec.SectionCode);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sectionCode = cmbSection.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(sectionCode))
            {
                ResetCapacityLabel();
                return;
            }

            var cap = _enrollmentController.GetSectionCapacity(sectionCode);
            if (cap.Capacity > 0)
            {
                if (cap.IsFull)
                {
                    lblSectionCapacity.Text = $"Capacity: {cap.CurrentCount} / {cap.Capacity} (FULL)";
                    lblSectionCapacity.ForeColor = Color.Red;
                }
                else
                {
                    lblSectionCapacity.Text = $"Capacity: {cap.CurrentCount} / {cap.Capacity}";
                    lblSectionCapacity.ForeColor = Color.ForestGreen;
                }
            }
            else
            {
                ResetCapacityLabel();
            }
        }

        private void ResetCapacityLabel()
        {
            lblSectionCapacity.Text = "Capacity: ---";
            lblSectionCapacity.ForeColor = Color.FromArgb(51, 65, 85);
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (lblStudentId.Text == "---")
            {
                MessageBox.Show("Please search and select a valid student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSection.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid section from the dropdown.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var missing = new List<string>();
            if (!chkPSA.Checked) missing.Add("- PSA Birth Certificate");
            if (!chkForm138.Checked) missing.Add("- Report Card (Form 138)");
            if (!chkGoodMoral.Checked) missing.Add("- Certificate of Good Moral");
            if (_currentStudentType == "Transferee" && !chkForm137.Checked) missing.Add("- Form 137 / Transfer Credentials (Transferee)");

            string reqStatus = missing.Count == 0 ? "Complete" : "Pending (To Follow)";

            if (missing.Count > 0 && !chkConditional.Checked)
            {
                MessageBox.Show(
                    "Missing required documents:\n\n" + string.Join("\n", missing) +
                    "\n\nCheck 'Allow Conditional (Docs To Follow)' if approved for late submission.",
                    "Missing Requirements",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string gradeLevel = cmbGradeLevel.SelectedItem.ToString();
            string schoolYear = cmbSchoolYear.SelectedItem.ToString();
            string sectionCode = cmbSection.SelectedItem.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Confirm enrollment for {lblStudentName.Text} ({lblStudentId.Text})?\n\n" +
                $"School Year: {schoolYear}\nGrade Level: {gradeLevel}\nSection: {sectionCode}\n" +
                $"Requirements: {reqStatus}",
                "Confirm Enrollment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            decimal tuitionFee = _assessmentController.ComputeTuition(gradeLevel, schoolYear);

            var enrollment = new Enrollment
            {
                StudentId = lblStudentId.Text,
                SectionCode = sectionCode,
                SchoolYear = schoolYear,
                AssessedFee = tuitionFee,
                HasPSA = chkPSA.Checked,
                HasForm138 = chkForm138.Checked,
                HasGoodMoral = chkGoodMoral.Checked,
                HasForm137 = chkForm137.Checked,
                RequirementsStatus = reqStatus
            };

            string result = _enrollmentController.EnrollStudent(enrollment);

            if (result == "Success")
            {
                MessageBox.Show($"Student successfully enrolled ({reqStatus})!", "Enrollment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelEnrollment_Click(object sender, EventArgs e)
        {
            if (lblStudentId.Text == "---")
            {
                MessageBox.Show("Please search for an enrolled student first.", "Cancel Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to CANCEL / VOID the active enrollment of {lblStudentName.Text} ({lblStudentId.Text})?\n\n" +
                "This will release their section slot and void any unpaid assessment for this school year.",
                "Confirm Cancel / Void Enrollment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var res = _enrollmentController.CancelEnrollment(lblStudentId.Text, "Cancelled / Student withdrew enrollment");
            if (res.Success)
            {
                MessageBox.Show(res.Message, "Enrollment Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show(res.Message, "Cancellation Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lblStudentId.Text != "---")
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to clear the enrollment form?",
                    "Confirm Clear",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;
            }

            ClearForm();
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            lblStudentId.Text = "---";
            lblStudentName.Text = "---";
            lblDateOfBirth.Text = "---";
            lblGender.Text = "---";
            lblGradeLevel.Text = "---";
            lblSection.Text = "---";
            _currentStudentType = "";

            cmbSchoolYear.SelectedIndex = -1;
            cmbGradeLevel.SelectedIndex = -1;
            cmbSection.Items.Clear();
            ResetCapacityLabel();

            chkPSA.Checked = false;
            chkForm138.Checked = false;
            chkGoodMoral.Checked = false;
            chkForm137.Checked = false;
            chkConditional.Checked = false;
            btnCancelEnrollment.Enabled = false;
        }
    }
}