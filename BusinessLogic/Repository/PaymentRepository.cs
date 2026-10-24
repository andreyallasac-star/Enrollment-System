using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;
using System.Data;

namespace BusinessLogic.Repository
{
    public class PaymentRepository
    {
        private readonly string connectionString = "Server=.\\SQLEXPRESS; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

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

        public DataTable GetPaymentHistory(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PaymentDate, PaymentMethod, AmountPaid, ReceiptId FROM Payments WHERE StudentId = @StudentId ORDER BY PaymentDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        public DataTable SearchPaymentHistory(string studentId, string receiptId, DateTime dateFrom, DateTime dateTo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    p.ReceiptId, 
                    p.PaymentDate, 
                    p.StudentId, 
                    (s.FirstName + ' ' + s.LastName) AS StudentName,
                    e.SectionCode AS Section,
                    p.AmountPaid
                FROM Payments p
                INNER JOIN Students s ON p.StudentId = s.StudentId
                LEFT JOIN Enrollments e ON p.StudentId = e.StudentId AND e.Status = 'Enrolled'
                WHERE CAST(p.PaymentDate AS DATE) >= @DateFrom 
                  AND CAST(p.PaymentDate AS DATE) <= @DateTo";

                if (!string.IsNullOrWhiteSpace(studentId))
                    query += " AND p.StudentId = @StudentId";

                if (!string.IsNullOrWhiteSpace(receiptId))
                    query += " AND p.ReceiptId = @ReceiptId";

                query += " ORDER BY p.PaymentDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom.Date);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo.Date);

                    if (!string.IsNullOrWhiteSpace(studentId))
                        cmd.Parameters.AddWithValue("@StudentId", studentId);

                    if (!string.IsNullOrWhiteSpace(receiptId))
                        cmd.Parameters.AddWithValue("@ReceiptId", receiptId);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }
    }
}
