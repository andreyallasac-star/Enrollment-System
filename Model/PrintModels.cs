using System;
using System.Collections.Generic;

namespace Model
{
    public class InvoiceData
    {
        public int ReceiptId { get; set; }
        public string InvoiceNumber => $"INV-{ReceiptId:D6}";
        public DateTime PaymentDate { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string SchoolYear { get; set; }
        public string GradeLevel { get; set; }
        public string Section { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal TotalAssessment { get; set; }
        public decimal TotalPaidToDate { get; set; }
        public decimal RemainingBalance => Math.Max(0m, TotalAssessment - TotalPaidToDate);
        public string ProcessedBy { get; set; }
    }

    public class SoaPaymentLine
    {
        public int ReceiptId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string ProcessedBy { get; set; }
        public decimal AmountPaid { get; set; }
    }

    public class SoaData
    {
        public StudentProfileDTO Profile { get; set; }
        public List<SoaPaymentLine> Payments { get; set; } = new List<SoaPaymentLine>();
    }
}