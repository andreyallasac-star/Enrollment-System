using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Model;
using System.Data;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class PaymentRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

        public Assessment GetStudentAssessment(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT TOP 1 AssessmentId, TotalAssessment, Status FROM Assessments " +
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

        public Assessment GetLatestAssessment(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT TOP 1 AssessmentId, TotalAssessment, Status FROM Assessments " +
                    "WHERE StudentId = @StudentId AND Status <> 'Voided' " +
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

        public decimal GetTotalPaid(string studentId, int? assessmentId = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;
                if (assessmentId.HasValue && assessmentId.Value > 0)
                {
                    cmd = new SqlCommand("SELECT ISNULL(SUM(AmountPaid), 0) FROM Payments WHERE AssessmentId = @AssessmentId", conn);
                    cmd.Parameters.AddWithValue("@AssessmentId", assessmentId.Value);
                }
                else
                {
                    cmd = new SqlCommand("SELECT ISNULL(SUM(AmountPaid), 0) FROM Payments WHERE StudentId = @StudentId", conn);
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                }
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public int ProcessPayment(Payment payment, int assessmentId = 0)
        {
            int targetAssessmentId = assessmentId > 0 ? assessmentId : (payment.AssessmentId ?? 0);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {
                        var cmd = new SqlCommand(
                            "INSERT INTO Payments (StudentId, AssessmentId, AmountPaid, PaymentMethod, ProcessedBy, PaymentDate) " +
                            "OUTPUT INSERTED.ReceiptId " +
                            "VALUES (@StudentId, @AssessmentId, @AmountPaid, @PaymentMethod, @ProcessedBy, GETDATE())", conn, tx);

                        cmd.Parameters.AddWithValue("@StudentId", payment.StudentId);
                        cmd.Parameters.AddWithValue("@AssessmentId", targetAssessmentId > 0 ? (object)targetAssessmentId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@AmountPaid", payment.AmountPaid);
                        cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                        cmd.Parameters.AddWithValue("@ProcessedBy", payment.ProcessedBy);

                        var result = cmd.ExecuteScalar();
                        int receiptId = result != null ? Convert.ToInt32(result) : 0;

                        if (receiptId > 0 && targetAssessmentId > 0)
                        {
                            var updateCmd = new SqlCommand(@"
                                DECLARE @TotalPaid DECIMAL(18,2) = (SELECT ISNULL(SUM(AmountPaid), 0) FROM Payments WHERE AssessmentId = @AssessmentId);
                                UPDATE Assessments
                                SET Status = CASE
                                    WHEN @TotalPaid >= TotalAssessment THEN 'Paid'
                                    WHEN @TotalPaid > 0 THEN 'Partial'
                                    ELSE 'Unpaid'
                                END
                                WHERE AssessmentId = @AssessmentId;", conn, tx);

                            updateCmd.Parameters.AddWithValue("@AssessmentId", targetAssessmentId);
                            updateCmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                        return receiptId;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public InvoiceData GetInvoiceDetails(int receiptId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT
                        p.ReceiptId,
                        p.PaymentDate,
                        p.StudentId,
                        s.FirstName + ' ' + ISNULL(s.MiddleName + ' ', '') + s.LastName AS StudentName,
                        ISNULL(a.SchoolYear, ISNULL(e.SchoolYear, 'N/A')) AS SchoolYear,
                        ISNULL(sec.GradeLevel, 'N/A') AS GradeLevel,
                        ISNULL(sec.SectionName, 'N/A') AS Section,
                        p.PaymentMethod,
                        p.AmountPaid,
                        ISNULL(a.TotalAssessment, p.AmountPaid) AS TotalAssessment,
                        ISNULL((SELECT SUM(p2.AmountPaid) FROM Payments p2 WHERE p2.AssessmentId = p.AssessmentId AND p2.ReceiptId <= p.ReceiptId), p.AmountPaid) AS TotalPaidToDate,
                        p.ProcessedBy
                    FROM Payments p
                    INNER JOIN Students s ON p.StudentId = s.StudentId
                    LEFT JOIN Assessments a ON p.AssessmentId = a.AssessmentId
                    OUTER APPLY (
                        SELECT TOP 1 en.SchoolYear, en.SectionCode
                        FROM Enrollments en
                        WHERE en.StudentId = p.StudentId
                          AND (a.SchoolYear IS NULL OR en.SchoolYear = a.SchoolYear)
                        ORDER BY CASE WHEN en.Status = 'Enrolled' THEN 0 ELSE 1 END, en.EnrollmentDate DESC
                    ) e
                    LEFT JOIN Sections sec ON e.SectionCode = sec.SectionCode
                    WHERE p.ReceiptId = @ReceiptId";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReceiptId", receiptId);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new InvoiceData
                            {
                                ReceiptId = Convert.ToInt32(r["ReceiptId"]),
                                PaymentDate = Convert.ToDateTime(r["PaymentDate"]),
                                StudentId = r["StudentId"].ToString(),
                                StudentName = r["StudentName"].ToString(),
                                SchoolYear = r["SchoolYear"].ToString(),
                                GradeLevel = r["GradeLevel"].ToString(),
                                Section = r["Section"].ToString(),
                                PaymentMethod = r["PaymentMethod"].ToString(),
                                AmountPaid = Convert.ToDecimal(r["AmountPaid"]),
                                TotalAssessment = Convert.ToDecimal(r["TotalAssessment"]),
                                TotalPaidToDate = Convert.ToDecimal(r["TotalPaidToDate"]),
                                ProcessedBy = r["ProcessedBy"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<SoaPaymentLine> GetPaymentsForAssessment(string studentId, int assessmentId)
        {
            var list = new List<SoaPaymentLine>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = assessmentId > 0
                    ? "SELECT ReceiptId, PaymentDate, PaymentMethod, ProcessedBy, AmountPaid FROM Payments WHERE AssessmentId = @AssessmentId ORDER BY PaymentDate ASC, ReceiptId ASC"
                    : "SELECT ReceiptId, PaymentDate, PaymentMethod, ProcessedBy, AmountPaid FROM Payments WHERE StudentId = @StudentId ORDER BY PaymentDate ASC, ReceiptId ASC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    if (assessmentId > 0)
                        cmd.Parameters.AddWithValue("@AssessmentId", assessmentId);
                    else
                        cmd.Parameters.AddWithValue("@StudentId", studentId);

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new SoaPaymentLine
                            {
                                ReceiptId = Convert.ToInt32(r["ReceiptId"]),
                                PaymentDate = Convert.ToDateTime(r["PaymentDate"]),
                                PaymentMethod = r["PaymentMethod"].ToString(),
                                ProcessedBy = r["ProcessedBy"].ToString(),
                                AmountPaid = Convert.ToDecimal(r["AmountPaid"])
                            });
                        }
                    }
                }
            }
            return list;
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

                using (SqlCommand cmd = new SqlCommand("SearchPaymentHistory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom.Date);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo.Date);
                    cmd.Parameters.AddWithValue("@StudentId",
                        string.IsNullOrWhiteSpace(studentId) ? (object)DBNull.Value : studentId.Trim());

                    if (!string.IsNullOrWhiteSpace(receiptId) && int.TryParse(receiptId.Trim(), out int parsedReceiptId))
                        cmd.Parameters.AddWithValue("@ReceiptId", parsedReceiptId);
                    else
                        cmd.Parameters.AddWithValue("@ReceiptId", DBNull.Value);

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