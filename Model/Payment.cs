using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Payment
    {
        public int ReceiptId { get; set; }
        public string StudentId { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ProcessedBy { get; set; }
    }
}
