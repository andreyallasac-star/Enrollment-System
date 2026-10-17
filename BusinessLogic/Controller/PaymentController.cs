using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class PaymentController
    {
        private readonly PaymentRepository _paymentRepo = new PaymentRepository();

        public Assessment GetStudentAssessment(string studentId) => _paymentRepo.GetStudentAssessment(studentId);

        public decimal GetTotalPaid(string studentId) => _paymentRepo.GetTotalPaid(studentId);

        public (bool Success, string Message, int ReceiptId) ProcessPayment(Payment payment, decimal currentBalance)
        {
            if (string.IsNullOrWhiteSpace(payment.StudentId))
                return (false, "Please search for a student first.", 0);

            if (payment.AmountPaid <= 0)
                return (false, "Payment amount must be greater than zero.", 0);

            if (payment.AmountPaid > currentBalance)
                return (false, "Payment cannot exceed the current balance.", 0);

            if (string.IsNullOrWhiteSpace(payment.PaymentMethod))
                return (false, "Please select a payment method.", 0);

            int receiptId = _paymentRepo.ProcessPayment(payment);

            if (receiptId > 0)
                return (true, "Payment successful!", receiptId);

            return (false, "Database error: Could not process payment.", 0);
        }
    }
}
