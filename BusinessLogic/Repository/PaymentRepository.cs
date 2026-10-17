using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class PaymentRepository
    {
        private readonly string connectionString = "Server=DESKTOP-TCVIDJV\\SQLEXPRESS01; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

        public Assessment GetStudentAssessment(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT AssessmentId, TotalAssessment, Status FROM Assessments " +
                    "WHERE StudentId = @StudentId AND Status IN ('Unpaid', 'Partial') " +
                    "ORDER BY AssessmentDate DESC", conn);

                cmd.Parameters.AddWithValue("@StudentId", studentId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Assessment
                        {
                            AssessmentId = (int)reader["AssessmentId"],
                            TotalAssessment = (decimal)reader["TotalAssessment"],
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public decimal GetTotalPaid(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT ISNULL(SUM(AmountPaid), 0) FROM Payments WHERE StudentId = @StudentId", conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public int ProcessPayment(Payment payment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(
                    "INSERT INTO Payments (StudentId, AmountPaid, PaymentMethod, ProcessedBy, PaymentDate) " +
                    "OUTPUT INSERTED.ReceiptId " +
                    "VALUES (@StudentId, @AmountPaid, @PaymentMethod, @ProcessedBy, GETDATE())", conn);

                cmd.Parameters.AddWithValue("@StudentId", payment.StudentId);
                cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                cmd.Parameters.AddWithValue("@ProcessedBy", payment.ProcessedBy);

                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
    }
}
