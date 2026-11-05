using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
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
        public StudentEnrollment()
        {
            InitializeComponent();

        }

        private void StudentEnrollment_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            ClearForm();
        }

        private void LoadDropdowns()
        {
            cmbSchoolYear.Items.Add("2026-2027");
            cmbSchoolYear.Items.Add("2027-2028");

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
            }
            else
            {
                MessageBox.Show("Student not found. Please check the ID or Name.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void FilterSections(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
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

            string gradeLevel = cmbGradeLevel.SelectedItem.ToString();
            string schoolYear = cmbSchoolYear.SelectedItem.ToString();

            decimal tuitionFee = _assessmentController.ComputeTuition(gradeLevel, schoolYear);

            var enrollment = new Enrollment
            {
                StudentId = lblStudentId.Text,
                SectionCode = cmbSection.SelectedItem.ToString(),
                SchoolYear = schoolYear,
                AssessedFee = tuitionFee
            };

            string result = _enrollmentController.EnrollStudent(enrollment);

            if (result == "Success")
            {
                MessageBox.Show("Student successfully enrolled!\n\nThey are now linked to their section and can proceed to Assessment.", "Core Integration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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

            cmbSchoolYear.SelectedIndex = -1;
            cmbGradeLevel.SelectedIndex = -1;
            cmbSection.Items.Clear();
        }


    }
}