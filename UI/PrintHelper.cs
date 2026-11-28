using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Model;

namespace UI
{
    public static class PrintHelper
    {
        public static void PreviewOfficialInvoice(InvoiceData invoice)
        {
            if (invoice == null)
            {
                MessageBox.Show("Unable to load invoice details for this receipt.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument doc = new PrintDocument();
            doc.DocumentName = $"Official_Invoice_{invoice.InvoiceNumber}";
            doc.PrintPage += (s, e) => DrawOfficialInvoice(e, invoice);

            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = doc;
                preview.WindowState = FormWindowState.Maximized;
                preview.Text = $"Official Receipt / Billing Invoice - {invoice.InvoiceNumber}";
                preview.ShowDialog();
            }
        }

        public static void PreviewStatementOfAccount(SoaData soa)
        {
            if (soa == null || soa.Profile == null)
            {
                MessageBox.Show("Please search for a student first before printing Statement of Account.", "Print SOA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument doc = new PrintDocument();
            doc.DocumentName = $"SOA_{soa.Profile.StudentId}";
            doc.PrintPage += (s, e) => DrawStatementOfAccount(e, soa);

            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = doc;
                preview.WindowState = FormWindowState.Maximized;
                preview.Text = $"Statement of Account (SOA) - {soa.Profile.StudentId}";
                preview.ShowDialog();
            }
        }

        private static void DrawOfficialInvoice(PrintPageEventArgs e, InvoiceData inv)
        {
            Graphics g = e.Graphics;
            int left = e.MarginBounds.Left;
            int right = e.MarginBounds.Right;
            int width = right - left;
            int y = e.MarginBounds.Top;

            using var fSchool = new Font("Segoe UI", 16, FontStyle.Bold);
            using var fSub = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            using var fTitle = new Font("Segoe UI", 14, FontStyle.Bold);
            using var fBold = new Font("Segoe UI", 10.5f, FontStyle.Bold);
            using var fReg = new Font("Segoe UI", 10.5f, FontStyle.Regular);
            using var fTotal = new Font("Segoe UI", 12, FontStyle.Bold);
            using var fSmall = new Font("Segoe UI", 8.5f, FontStyle.Italic);
            using var penDark = new Pen(Color.Black, 1.5f);
            using var penGray = new Pen(Color.Gray, 1f);

            var centerFmt = new StringFormat { Alignment = StringAlignment.Center };
            var rightFmt = new StringFormat { Alignment = StringAlignment.Far };

            g.DrawString(SchoolConfig.SchoolName, fSchool, Brushes.Black, new RectangleF(left, y, width, 30), centerFmt);
            y += 28;
            g.DrawString(SchoolConfig.SchoolAddress, fSub, Brushes.DimGray, new RectangleF(left, y, width, 20), centerFmt);
            y += 18;
            g.DrawString(SchoolConfig.SchoolContact, fSub, Brushes.DimGray, new RectangleF(left, y, width, 20), centerFmt);
            y += 26;
            g.DrawLine(penDark, left, y, right, y);
            y += 12;

            g.DrawString("OFFICIAL RECEIPT / BILLING INVOICE", fTitle, Brushes.Black, new RectangleF(left, y, width, 28), centerFmt);
            y += 36;

            g.DrawString($"Invoice / OR No.: {inv.InvoiceNumber} (OR #{inv.ReceiptId})", fBold, Brushes.Black, left, y);
            g.DrawString($"Date: {inv.PaymentDate:MMMM dd, yyyy hh:mm tt}", fReg, Brushes.Black, new RectangleF(left, y, width, 22), rightFmt);
            y += 28;

            g.DrawRectangle(penGray, left, y, width, 96);
            int bx = left + 12;
            int by = y + 10;
            g.DrawString($"Student ID:   {inv.StudentId}", fBold, Brushes.Black, bx, by);
            g.DrawString($"School Year:  {inv.SchoolYear}", fReg, Brushes.Black, left + width / 2, by);
            by += 26;
            g.DrawString($"Student Name: {inv.StudentName}", fReg, Brushes.Black, bx, by);
            by += 26;
            g.DrawString($"Grade Level:  {inv.GradeLevel}", fReg, Brushes.Black, bx, by);
            g.DrawString($"Section:      {inv.Section}", fReg, Brushes.Black, left + width / 2, by);
            y += 112;

            g.FillRectangle(Brushes.Gainsboro, left, y, width, 28);
            g.DrawRectangle(penGray, left, y, width, 28);
            g.DrawString("Description", fBold, Brushes.Black, left + 10, y + 5);
            g.DrawString("Payment Method", fBold, Brushes.Black, left + (int)(width * 0.50), y + 5);
            g.DrawString("Amount (PHP)", fBold, Brushes.Black, new RectangleF(left, y + 5, width - 10, 22), rightFmt);
            y += 28;

            g.DrawRectangle(penGray, left, y, width, 34);
            g.DrawString($"Tuition & School Fees Payment (SY {inv.SchoolYear})", fReg, Brushes.Black, left + 10, y + 8);
            g.DrawString(inv.PaymentMethod, fReg, Brushes.Black, left + (int)(width * 0.50), y + 8);
            g.DrawString($"{inv.AmountPaid:N2}", fBold, Brushes.Black, new RectangleF(left, y + 8, width - 10, 24), rightFmt);
            y += 48;

            int labelX = left + (int)(width * 0.50);
            g.DrawString("Total Assessment:", fReg, Brushes.Black, labelX, y);
            g.DrawString($"PHP {inv.TotalAssessment:N2}", fReg, Brushes.Black, new RectangleF(left, y, width - 10, 22), rightFmt);
            y += 24;

            g.DrawString("Amount Paid (This Invoice):", fBold, Brushes.Black, labelX, y);
            g.DrawString($"PHP {inv.AmountPaid:N2}", fBold, Brushes.Black, new RectangleF(left, y, width - 10, 22), rightFmt);
            y += 24;

            g.DrawString("Total Paid to Date:", fReg, Brushes.Black, labelX, y);
            g.DrawString($"PHP {inv.TotalPaidToDate:N2}", fReg, Brushes.Black, new RectangleF(left, y, width - 10, 22), rightFmt);
            y += 26;

            g.DrawLine(penDark, labelX, y, right, y);
            y += 8;

            string balLabel = inv.RemainingBalance <= 0 ? "FULLY PAID (PHP 0.00)" : $"PHP {inv.RemainingBalance:N2}";
            g.DrawString("Remaining Balance:", fTotal, Brushes.Black, labelX, y);
            g.DrawString(balLabel, fTotal, inv.RemainingBalance <= 0 ? Brushes.DarkGreen : Brushes.Black, new RectangleF(left, y, width - 10, 26), rightFmt);
            y += 55;

            g.DrawString($"Processed By: {inv.ProcessedBy}", fBold, Brushes.Black, left, y);
            y += 40;
            g.DrawLine(penGray, left, y, left + 220, y);
            g.DrawLine(penGray, right - 220, y, right, y);
            y += 6;
            g.DrawString("Cashier / Authorized Signature", fSmall, Brushes.DimGray, left, y);
            g.DrawString("Student / Parent Signature", fSmall, Brushes.DimGray, right - 220, y);
            y += 32;

            g.DrawString("This Official Receipt / Billing Invoice serves as valid proof of payment. Keep for your records.", fSmall, Brushes.DimGray, new RectangleF(left, y, width, 20), centerFmt);
        }

        private static void DrawStatementOfAccount(PrintPageEventArgs e, SoaData soa)
        {
            Graphics g = e.Graphics;
            var p = soa.Profile;
            int left = e.MarginBounds.Left;
            int right = e.MarginBounds.Right;
            int width = right - left;
            int y = e.MarginBounds.Top;

            using var fSchool = new Font("Segoe UI", 16, FontStyle.Bold);
            using var fSub = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            using var fTitle = new Font("Segoe UI", 14, FontStyle.Bold);
            using var fSection = new Font("Segoe UI", 11, FontStyle.Bold);
            using var fBold = new Font("Segoe UI", 10f, FontStyle.Bold);
            using var fReg = new Font("Segoe UI", 10f, FontStyle.Regular);
            using var fTotal = new Font("Segoe UI", 12, FontStyle.Bold);
            using var fSmall = new Font("Segoe UI", 8.5f, FontStyle.Italic);
            using var penDark = new Pen(Color.Black, 1.5f);
            using var penGray = new Pen(Color.Gray, 1f);

            var centerFmt = new StringFormat { Alignment = StringAlignment.Center };
            var rightFmt = new StringFormat { Alignment = StringAlignment.Far };

            g.DrawString(SchoolConfig.SchoolName, fSchool, Brushes.Black, new RectangleF(left, y, width, 30), centerFmt);
            y += 28;
            g.DrawString(SchoolConfig.SchoolAddress, fSub, Brushes.DimGray, new RectangleF(left, y, width, 20), centerFmt);
            y += 18;
            g.DrawString(SchoolConfig.SchoolContact, fSub, Brushes.DimGray, new RectangleF(left, y, width, 20), centerFmt);
            y += 24;
            g.DrawLine(penDark, left, y, right, y);
            y += 10;

            g.DrawString("STATEMENT OF ACCOUNT (SOA)", fTitle, Brushes.Black, new RectangleF(left, y, width, 28), centerFmt);
            y += 26;
            g.DrawString($"Generated On: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", fSub, Brushes.DimGray, new RectangleF(left, y, width, 20), centerFmt);
            y += 26;

            g.DrawRectangle(penGray, left, y, width, 110);
            int bx = left + 12;
            int by = y + 10;
            g.DrawString($"Student ID:   {p.StudentId}", fBold, Brushes.Black, bx, by);
            g.DrawString($"LRN:          {(string.IsNullOrWhiteSpace(p.LRN) ? "N/A" : p.LRN)}", fReg, Brushes.Black, left + width / 2, by);
            by += 24;
            g.DrawString($"Student Name: {p.FullName}", fBold, Brushes.Black, bx, by);
            g.DrawString($"School Year:  {p.SchoolYear}", fReg, Brushes.Black, left + width / 2, by);
            by += 24;
            g.DrawString($"Grade Level:  {p.GradeLevel}", fReg, Brushes.Black, bx, by);
            g.DrawString($"Section:      {p.Section}", fReg, Brushes.Black, left + width / 2, by);
            by += 24;
            g.DrawString($"Requirements: {p.RequirementsStatus}", fReg, Brushes.Black, bx, by);
            g.DrawString($"Status:       {p.AssessmentStatus}", fBold, Brushes.Black, left + width / 2, by);
            y += 126;

            g.DrawString("I. ASSESSMENT BREAKDOWN", fSection, Brushes.Black, left, y);
            y += 24;

            void DrawLineItem(string desc, string amount, bool bold = false)
            {
                var font = bold ? fBold : fReg;
                g.DrawString(desc, font, Brushes.Black, left + 10, y);
                g.DrawString(amount, font, Brushes.Black, new RectangleF(left, y, width - 10, 22), rightFmt);
                y += 22;
            }

            DrawLineItem("Tuition Fee", $"PHP {p.TuitionFee:N2}");
            DrawLineItem("Other / Miscellaneous Fees", $"PHP {p.OtherFee:N2}");
            DrawLineItem($"Less: Discount ({p.DiscountName})", $"- PHP {p.DiscountAmount:N2}");
            g.DrawLine(penGray, left, y, right, y);
            y += 6;
            DrawLineItem("NET TOTAL ASSESSMENT", $"PHP {p.TotalAssessment:N2}", bold: true);
            y += 16;

            g.DrawString("II. PAYMENTS RECORDED", fSection, Brushes.Black, left, y);
            y += 24;

            g.FillRectangle(Brushes.Gainsboro, left, y, width, 24);
            g.DrawRectangle(penGray, left, y, width, 24);
            g.DrawString("Invoice / OR #", fBold, Brushes.Black, left + 8, y + 4);
            g.DrawString("Date", fBold, Brushes.Black, left + 140, y + 4);
            g.DrawString("Method", fBold, Brushes.Black, left + 270, y + 4);
            g.DrawString("Cashier", fBold, Brushes.Black, left + 450, y + 4);
            g.DrawString("Amount (PHP)", fBold, Brushes.Black, new RectangleF(left, y + 4, width - 8, 20), rightFmt);
            y += 24;

            if (soa.Payments == null || soa.Payments.Count == 0)
            {
                g.DrawRectangle(penGray, left, y, width, 26);
                g.DrawString("No payments recorded yet.", fSmall, Brushes.DimGray, left + 10, y + 5);
                y += 26;
            }
            else
            {
                foreach (var pay in soa.Payments)
                {
                    g.DrawRectangle(penGray, left, y, width, 24);
                    g.DrawString($"INV-{pay.ReceiptId:D6}", fReg, Brushes.Black, left + 8, y + 4);
                    g.DrawString(pay.PaymentDate.ToString("yyyy-MM-dd"), fReg, Brushes.Black, left + 140, y + 4);
                    g.DrawString(pay.PaymentMethod, fReg, Brushes.Black, left + 270, y + 4);
                    g.DrawString(pay.ProcessedBy, fReg, Brushes.Black, left + 450, y + 4);
                    g.DrawString($"{pay.AmountPaid:N2}", fReg, Brushes.Black, new RectangleF(left, y + 4, width - 8, 20), rightFmt);
                    y += 24;
                }
            }

            y += 18;
            g.DrawLine(penDark, left, y, right, y);
            y += 10;

            DrawLineItem("Total Assessment:", $"PHP {p.TotalAssessment:N2}");
            DrawLineItem("Less: Total Payments Made:", $"PHP {p.TotalPaid:N2}");
            y += 4;
            g.DrawString("OUTSTANDING BALANCE DUE:", fTotal, Brushes.Black, left + 10, y);
            string dueText = p.RemainingBalance <= 0 && p.TotalAssessment > 0
                ? "FULLY PAID (PHP 0.00)"
                : $"PHP {p.RemainingBalance:N2}";
            g.DrawString(dueText, fTotal, p.RemainingBalance <= 0 ? Brushes.DarkGreen : Brushes.DarkRed, new RectangleF(left, y, width - 10, 26), rightFmt);
            y += 55;

            g.DrawLine(penGray, left, y, left + 220, y);
            g.DrawLine(penGray, right - 220, y, right, y);
            y += 6;
            g.DrawString("Prepared By (Cashier / Registrar)", fSmall, Brushes.DimGray, left, y);
            g.DrawString("Acknowledged By (Parent / Guardian)", fSmall, Brushes.DimGray, right - 220, y);
        }
    }
}