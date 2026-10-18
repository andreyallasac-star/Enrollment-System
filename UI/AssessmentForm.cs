using BusinessLogic.Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class AssessmentForm : Form
    {
        private readonly AssessmentController _assessmentController = new AssessmentController();
        private readonly StudentSearchController _searchController = new StudentSearchController();
        public AssessmentForm()
        {
            InitializeComponent();
            txtTuitionFee.ReadOnly = true;
            txtTuitionFee.BackColor = System.Drawing.SystemColors.Control;

            txtStudentId.Leave += txtStudentId_Leave;
            txtStudentId.KeyDown += txtStudentId_KeyDown;

            btnCompute.Click += btnCompute_Click;
            btnSave.Click += btnSave_Click;

            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtOtherFee.Text = "0.00";
        }

        private void txtStudentId_Leave(object sender, EventArgs e)
        {
            FetchStudentDetails();
        }

        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                FetchStudentDetails();
            }
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
            }
            else
            {
                lblStudentName.Text = "Student not found";
                lblGrade.Text = "---";
                lblSection.Text = "---";
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string gradeLevel = lblGrade.Text;
            string schoolYear = "2026-2027";

            if (gradeLevel == "<Label>" || gradeLevel == "---")
            {
                MessageBox.Show("Please enter a valid Student ID first.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal officialTuition = _assessmentController.ComputeTuition(gradeLevel, schoolYear);
            txtTuitionFee.Text = officialTuition.ToString("F2");

            decimal otherFees = 0;
            decimal.TryParse(txtOtherFee.Text, out otherFees);

            decimal total = officialTuition + otherFees;
            lblTotalAssessment.Text = total.ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Please enter a Student ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAssessment = 0;
            decimal.TryParse(lblTotalAssessment.Text, out totalAssessment);

            if (totalAssessment <= 0)
            {
                MessageBox.Show("Please compute the fees before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newAssessment = new Assessment
            {
                StudentId = txtStudentId.Text,
                SchoolYear = "2026-2027",
                TuitionFee = Convert.ToDecimal(txtTuitionFee.Text),
                OtherFee = Convert.ToDecimal(txtOtherFee.Text),
                TotalAssessment = totalAssessment
            };

            string result = _assessmentController.SaveAssessment(newAssessment);

            if (result == "Success")
            {
                MessageBox.Show("Assessment successfully saved! The student can now proceed to the Cashier.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show(result, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtTuitionFee.Clear();
            txtOtherFee.Text = "0.00";
            txtPaymentMode.Clear();
            lblStudentName.Text = "<Label>";
            lblGrade.Text = "<Label>";
            lblSection.Text = "<Label>";
            lblTotalAssessment.Text = "<Label>";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
