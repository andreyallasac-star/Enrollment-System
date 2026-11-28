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
    public partial class PaymentandCashieringForm : Form
    {
        private readonly PaymentController _paymentController = new PaymentController();
        private readonly StudentSearchController _searchController = new StudentSearchController();

        private decimal _currentBalance = 0;
        private decimal _totalAssessment = 0;
        private decimal _totalPaid = 0;
        private string _studentGrade = "";
        private int _currentAssessmentId = 0;
        private readonly string _processedBy;

        public PaymentandCashieringForm(string processedBy = "admin")
        {
            _processedBy = string.IsNullOrWhiteSpace(processedBy) ? "admin" : processedBy;
            InitializeComponent();
            dataGridView1.GridColor = System.Drawing.Color.Black;

            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Items.AddRange(new string[] { "Cash (Full Payment)", "Installment" });

            ClearForm();
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyPaymentMode();
        }

        private void ApplyPaymentMode()
        {
            bool canPay = _currentAssessmentId > 0 && _currentBalance > 0;
            btnConfirm.Enabled = canPay;
            txtPaymentAmount.Enabled = canPay;

            if (!canPay)
            {
                txtPaymentAmount.ReadOnly = false;
                txtPaymentAmount.BackColor = Color.White;
                txtPaymentAmount.Clear();
                return;
            }

            string selectedMode = cmbPaymentMethod.SelectedItem?.ToString();
            if (selectedMode == "Cash (Full Payment)")
            {
                txtPaymentAmount.Text = _currentBalance.ToString("F2");
                txtPaymentAmount.ReadOnly = true;
                txtPaymentAmount.BackColor = SystemColors.Control;
            }
            else
            {
                txtPaymentAmount.ReadOnly = false;
                txtPaymentAmount.BackColor = Color.White;
                txtPaymentAmount.Clear();
            }
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchStudent.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword)) return;

            var profile = _searchController.SearchStudent(keyword);
            if (profile == null)
            {
                MessageBox.Show("Student not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                return;
            }

            string studentId = profile.StudentId;
            lblID.Text = studentId;
            lblName.Text = profile.FullName;
            lblSection.Text = profile.Section;
            _studentGrade = profile.GradeLevel;

            int? paidLookupAssessmentId = null;

            var assessment = _paymentController.GetStudentAssessment(studentId);
            if (assessment == null)
            {
                var latest = _paymentController.GetLatestAssessment(studentId);
                if (latest != null && latest.Status == "Paid")
                {
                    _currentAssessmentId = 0;
                    _totalAssessment = latest.TotalAssessment;
                    paidLookupAssessmentId = latest.AssessmentId;
                    MessageBox.Show("This student is already fully paid.", "Fully Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _currentAssessmentId = 0;
                    _totalAssessment = 0;
                    MessageBox.Show("No active assessment found for this student. They must be assessed before paying.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                _currentAssessmentId = assessment.AssessmentId;
                _totalAssessment = assessment.TotalAssessment;
                paidLookupAssessmentId = assessment.AssessmentId;
            }

            _totalPaid = paidLookupAssessmentId.HasValue
                ? _paymentController.GetTotalPaid(studentId, paidLookupAssessmentId.Value)
                : 0;
            _currentBalance = Math.Max(0, _totalAssessment - _totalPaid);

            lblAssessment.Text = _totalAssessment.ToString("F2");
            lblPaid.Text = _totalPaid.ToString("F2");
            lblBalance.Text = _currentBalance.ToString("F2");

            lblRemaining.Text = _currentBalance.ToString("F2");
            lblReceipt.Text = "---";

            ApplyPaymentMode();

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

            if (_currentAssessmentId <= 0 || _currentBalance <= 0)
            {
                MessageBox.Show("This student has no unpaid balance to pay.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string method = cmbPaymentMethod.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(method))
            {
                MessageBox.Show("Please select a payment method.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPaymentAmount.Text, System.Globalization.NumberStyles.Any, null, out decimal paymentAmount) || paymentAmount <= 0)
            {
                MessageBox.Show("Payment amount must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (paymentAmount > _currentBalance)
            {
                MessageBox.Show("Payment cannot exceed the current balance.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (method == "Cash (Full Payment)" && paymentAmount < _currentBalance)
            {
                MessageBox.Show("Cash (Full Payment) must pay the full remaining balance. Select Installment for partial payments.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Confirm payment of PHP {paymentAmount:F2} via {method} for {lblName.Text} ({lblID.Text})?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var payment = new Payment
            {
                StudentId = lblID.Text,
                AssessmentId = _currentAssessmentId,
                AmountPaid = paymentAmount,
                PaymentMethod = method,
                ProcessedBy = _processedBy
            };

            var result = _paymentController.ProcessPayment(payment, _currentBalance, _currentAssessmentId);

            if (result.Success)
            {
                int issuedReceiptId = result.ReceiptId;
                btnSearchID.PerformClick();
                lblReceipt.Text = issuedReceiptId.ToString();

                DialogResult printNow = MessageBox.Show(
                    $"{result.Message}\n\nOfficial Invoice / Receipt No.: INV-{issuedReceiptId:D6} (OR #{issuedReceiptId})\n\n" +
                    "Would you like to preview / print the Official Receipt & Billing Invoice now?",
                    "Transaction Complete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (printNow == DialogResult.Yes)
                {
                    var invoice = _paymentController.GetInvoiceDetails(issuedReceiptId);
                    PrintHelper.PreviewOfficialInvoice(invoice);
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "---" && lblID.Text != "<Label>")
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to clear the current student and payment fields?",
                    "Confirm Clear",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;
            }

            ClearForm();
        }

        private void ClearForm()
        {
            txtSearchStudent.Clear();
            txtPaymentAmount.ReadOnly = false;
            txtPaymentAmount.BackColor = Color.White;
            txtPaymentAmount.Clear();

            lblID.Text = "---";
            lblName.Text = "---";
            lblSection.Text = "---";
            lblAssessment.Text = "0.00";
            lblPaid.Text = "0.00";
            lblBalance.Text = "0.00";
            lblRemaining.Text = "0.00";
            lblReceipt.Text = "---";

            _currentBalance = 0;
            _totalAssessment = 0;
            _totalPaid = 0;
            _studentGrade = "";
            _currentAssessmentId = 0;

            if (cmbPaymentMethod.Items.Count > 0)
                cmbPaymentMethod.SelectedIndex = 0;

            dtpPayment.Value = DateTime.Now;

            btnConfirm.Enabled = true;
            txtPaymentAmount.Enabled = true;

            dataGridView1.Rows.Clear();
        }
    }
}