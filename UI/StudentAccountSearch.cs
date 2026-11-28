using BusinessLogic.Controller;
using Model;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class StudentAccountSearch : Form
    {
        private readonly StudentSearchController _searchController = new StudentSearchController();
        private readonly PaymentController _paymentController = new PaymentController();
        private StudentProfileDTO _currentProfile;

        public StudentAccountSearch()
        {
            InitializeComponent();
        }

        private void StudentAccountSearch_Load(object sender, EventArgs e)
        {
            ClearLabels();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a Student ID, LRN, or Name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var profile = _searchController.SearchStudent(keyword);

            if (profile != null)
            {
                _currentProfile = profile;
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

                btnPrintSOA.Enabled = true;
            }
            else
            {
                MessageBox.Show("No student found matching that ID, LRN, or Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearLabels();
            }
        }

        private void btnPrintSOA_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("Please search for a student first.", "Print SOA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var payments = _paymentController.GetPaymentsForAssessment(_currentProfile.StudentId, _currentProfile.AssessmentId);
            PrintHelper.PreviewStatementOfAccount(new SoaData
            {
                Profile = _currentProfile,
                Payments = payments
            });
        }

        private void ClearLabels()
        {
            _currentProfile = null;
            txtSearch.Clear();
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
            btnPrintSOA.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLabels();
        }
    }
}