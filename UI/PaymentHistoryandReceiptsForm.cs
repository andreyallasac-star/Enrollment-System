using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace UI
{
    public partial class PaymentHistoryandReceiptsForm : Form
    {
        private readonly PaymentController _paymentController = new PaymentController();
        private PrintDocument printReceipt = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();
        public PaymentHistoryandReceiptsForm()
        {
            InitializeComponent();
            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

            dtpDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateTo.Value = DateTime.Now;


            printReceipt.PrintPage += new PrintPageEventHandler(printReceipt_PrintPage);

            ClearReceiptPanel();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text.Trim();
            string receiptId = txtReceiptId.Text.Trim();
            DateTime dateFrom = dtpDateFrom.Value;
            DateTime dateTo = dtpDateTo.Value;

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
            if (lblReceiptID.Text == "---" || string.IsNullOrWhiteSpace(lblReceiptID.Text))
            {
                MessageBox.Show("Please select a receipt from the grid first.", "Print Receipt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            printPreview.Document = printReceipt;
            printPreview.StartPosition = FormStartPosition.CenterScreen;

            printPreview.Width = 500;
            printPreview.Height = 500;
            printPreview.ShowDialog();
            
        }

        private void printReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Segoe UI", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 12, FontStyle.Italic);
            Font regularFont = new Font("Consolas", 12, FontStyle.Regular);
            Font boldFont = new Font("Consolas", 12, FontStyle.Bold);

            int startX = 50;
            int startY = 50;
            int lineSpacing = 30;

            e.Graphics.DrawString("OFFICIAL RECEIPT", headerFont, Brushes.Black, startX, startY);
            e.Graphics.DrawString("Student Enrollment System", subHeaderFont, Brushes.Black, startX, startY + 30);
            e.Graphics.DrawString("-------------------------------------------------", regularFont, Brushes.Black, startX, startY + 60);

            e.Graphics.DrawString("Receipt ID : " + lblReceiptID.Text, boldFont, Brushes.Black, startX, startY + 100);
            e.Graphics.DrawString("Date       : " + lblDate.Text, regularFont, Brushes.Black, startX, startY + 100 + lineSpacing);

            e.Graphics.DrawString("Student ID : " + lblStudentID.Text, boldFont, Brushes.Black, startX, startY + 100 + (lineSpacing * 2));
            e.Graphics.DrawString("Name       : " + lblStudentName.Text, regularFont, Brushes.Black, startX, startY + 100 + (lineSpacing * 3));
            e.Graphics.DrawString("Section    : " + lblSection.Text, regularFont, Brushes.Black, startX, startY + 100 + (lineSpacing * 4));

            e.Graphics.DrawString("-------------------------------------------------", regularFont, Brushes.Black, startX, startY + 100 + (lineSpacing * 5));

            e.Graphics.DrawString("TOTAL PAID : PHP " + lblAmountPaid.Text, headerFont, Brushes.Black, startX, startY + 100 + (lineSpacing * 6));
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
    }
}
