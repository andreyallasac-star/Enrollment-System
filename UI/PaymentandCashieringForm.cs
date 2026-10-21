using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;
using System.Data;


namespace UI
{
    public partial class PaymentandCashieringForm : Form
    {
        private readonly PaymentController _paymentController = new PaymentController();
        private readonly StudentSearchController _searchController = new StudentSearchController();

        private decimal _currentBalance = 0;
        private decimal _totalAssessment = 0;
        private decimal _totalPaid = 0;
        private string _studentGrade = "";
        public PaymentandCashieringForm()
        {
            InitializeComponent();

            cmbPaymentMethod.Items.AddRange(new string[] { "Cash", "GCash", "Bank Transfer" });


            ClearForm();

        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            string studentId = txtSearchStudent.Text.Trim();
            if (string.IsNullOrWhiteSpace(studentId)) return;

            var profile = _searchController.SearchStudent(studentId);
            if (profile == null)
            {
                MessageBox.Show("Student not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                return;
            }

            lblID.Text = profile.StudentId;
            lblName.Text = profile.FullName;
            lblSection.Text = profile.Section;
            _studentGrade = profile.GradeLevel;

            var assessment = _paymentController.GetStudentAssessment(studentId);
            if (assessment == null)
            {
                MessageBox.Show("No active assessment found for this student. They must be assessed before paying.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _totalAssessment = 0;
            }
            else
            {
                _totalAssessment = assessment.TotalAssessment;
            }

            _totalPaid = _paymentController.GetTotalPaid(studentId);

            _currentBalance = _totalAssessment - _totalPaid;

            lblAssessment.Text = _totalAssessment.ToString("F2");
            lblPaid.Text = _totalPaid.ToString("F2");
            lblBalance.Text = _currentBalance.ToString("F2");

            txtPaymentAmount.Clear();
            lblRemaining.Text = _currentBalance.ToString("F2");
            lblReceipt.Text = "---";

            dataGridView1.Rows.Clear();
            var history = _paymentController.GetPaymentHistory(studentId);

            if (history != null)
            {
                foreach (DataRow row in history.Rows)
                {
                    dataGridView1.Rows.Add(
                        lblName.Text,
                        _studentGrade,
                        lblSection.Text,
                        Convert.ToDateTime(row["PaymentDate"]).ToString("yyyy-MM-dd"),
                        row["PaymentMethod"].ToString(),
                        Convert.ToDecimal(row["AmountPaid"]).ToString("F2"),
                        row["ReceiptId"].ToString()
                    );
                }
            }
        }

        private void txtPaymentAmount_TextChanged(object sender, EventArgs e)
        {
            decimal paymentAmount = 0;
            decimal.TryParse(txtPaymentAmount.Text, System.Globalization.NumberStyles.Any, null, out paymentAmount);

            decimal remaining = _currentBalance - paymentAmount;
            lblRemaining.Text = remaining.ToString("F2");

            if (remaining < 0)
                lblRemaining.ForeColor = System.Drawing.Color.Red;
            else
                lblRemaining.ForeColor = System.Drawing.Color.Black;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "---" || lblID.Text == "<Label>")
            {
                MessageBox.Show("Please search and select a valid student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal paymentAmount = 0;
            decimal.TryParse(txtPaymentAmount.Text, System.Globalization.NumberStyles.Any, null, out paymentAmount);

            var payment = new Payment
            {
                StudentId = lblID.Text,
                AmountPaid = paymentAmount,
                PaymentMethod = cmbPaymentMethod.SelectedItem?.ToString(),
                ProcessedBy = "admin"
            };

            var result = _paymentController.ProcessPayment(payment, _currentBalance);

            if (result.Success)
            {
                MessageBox.Show(result.Message + $"\n\nOfficial Receipt ID: {result.ReceiptId}", "Transaction Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblReceipt.Text = result.ReceiptId.ToString();

                dataGridView1.Rows.Add(
                    lblName.Text,
                    _studentGrade,
                    lblSection.Text,
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    cmbPaymentMethod.SelectedItem.ToString(),
                    paymentAmount.ToString("F2"),
                    result.ReceiptId
                );

                btnSearchID.PerformClick();
            }
            else
            {
                MessageBox.Show(result.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSearchStudent.Clear();
            txtPaymentAmount.Clear();

            lblID.Text = "---";
            lblName.Text = "---";
            lblSection.Text = "---";
            lblAssessment.Text = "0.00";
            lblPaid.Text = "0.00";
            lblBalance.Text = "0.00";
            lblRemaining.Text = "0.00";
            lblReceipt.Text = "---";

            if (cmbPaymentMethod.Items.Count > 0)
                cmbPaymentMethod.SelectedIndex = 0; // Default to Cash

            dtpPayment.Value = DateTime.Now;

            _currentBalance = 0;
            _totalAssessment = 0;
            _totalPaid = 0;
            _studentGrade = "";
        }
    }
}
