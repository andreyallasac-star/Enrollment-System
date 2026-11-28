using BusinessLogic.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class PaymentHistoryandReceiptsForm : Form
    {
        private readonly PaymentController _paymentController = new PaymentController();

        public PaymentHistoryandReceiptsForm()
        {
            InitializeComponent();
            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            dtpDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateTo.Value = DateTime.Now;

            ClearReceiptPanel();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text.Trim();
            string receiptId = txtReceiptId.Text.Trim();
            DateTime dateFrom = dtpDateFrom.Value;
            DateTime dateTo = dtpDateTo.Value;

            if (dateFrom.Date > dateTo.Date)
            {
                MessageBox.Show("'Date From' cannot be later than 'Date To'.", "Date Filter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable results = _paymentController.SearchPaymentHistory(studentId, receiptId, dateFrom, dateTo);

            dataGridView1.Rows.Clear();
            ClearReceiptPanel();

            if (results != null && results.Rows.Count > 0)
            {
                foreach (DataRow row in results.Rows)
                {
                    dataGridView1.Rows.Add(
                        row["ReceiptId"].ToString(),
                        Convert.ToDateTime(row["PaymentDate"]).ToString("yyyy-MM-dd"),
                        row["StudentId"].ToString(),
                        row["StudentName"].ToString(),
                        row["Section"].ToString(),
                        Convert.ToDecimal(row["AmountPaid"]).ToString("F2")
                    );
                }
            }
            else
            {
                MessageBox.Show("No payment records found for the selected filters.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.IsNewRow || row.Cells[0].Value == null) return;

                lblReceiptID.Text = row.Cells[0].Value?.ToString();
                lblDate.Text = row.Cells[1].Value?.ToString();
                lblStudentID.Text = row.Cells[2].Value?.ToString();
                lblStudentName.Text = row.Cells[3].Value?.ToString();
                lblSection.Text = row.Cells[4].Value?.ToString();
                lblAmountPaid.Text = row.Cells[5].Value?.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentId.Clear();
            txtReceiptId.Clear();
            dtpDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateTo.Value = DateTime.Now;

            dataGridView1.Rows.Clear();
            ClearReceiptPanel();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lblReceiptID.Text == "---" || !int.TryParse(lblReceiptID.Text, out int receiptId))
            {
                MessageBox.Show("Please select a receipt from the grid first.", "Print Official Invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var invoice = _paymentController.GetInvoiceDetails(receiptId);
            PrintHelper.PreviewOfficialInvoice(invoice);
        }

        private void ClearReceiptPanel()
        {
            lblReceiptID.Text = "---";
            lblDate.Text = "---";
            lblStudentID.Text = "---";
            lblStudentName.Text = "---";
            lblSection.Text = "---";
            lblAmountPaid.Text = "---";
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }
    }
}