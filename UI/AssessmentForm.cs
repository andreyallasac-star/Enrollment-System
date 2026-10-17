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
                label1.Text = profile.FullName;
                label2.Text = profile.GradeLevel;
                label3.Text = profile.Section;
            }
            else
            {
                label1.Text = "Student not found";
                label2.Text = "---";
                label3.Text = "---";
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string gradeLevel = label2.Text;
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
            label5.Text = total.ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Please enter a Student ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAssessment = 0;
            decimal.TryParse(label5.Text, out totalAssessment);

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
            label1.Text = "<Label>";
            label2.Text = "<Label>";
            label3.Text = "<Label>";
            label5.Text = "<Label>";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
