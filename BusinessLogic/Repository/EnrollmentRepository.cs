using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class EnrollmentRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

        public bool EnrollStudent(Enrollment enrollment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("EnrollStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", enrollment.StudentId);
                cmd.Parameters.AddWithValue("@SectionCode", enrollment.SectionCode);
                cmd.Parameters.AddWithValue("@SchoolYear", enrollment.SchoolYear);
                cmd.Parameters.AddWithValue("@AssessedFee", enrollment.AssessedFee);
                cmd.Parameters.AddWithValue("@HasPSA", enrollment.HasPSA);
                cmd.Parameters.AddWithValue("@HasForm138", enrollment.HasForm138);
                cmd.Parameters.AddWithValue("@HasGoodMoral", enrollment.HasGoodMoral);
                cmd.Parameters.AddWithValue("@HasForm137", enrollment.HasForm137);
                cmd.Parameters.AddWithValue("@RequirementsStatus", string.IsNullOrWhiteSpace(enrollment.RequirementsStatus) ? "Complete" : enrollment.RequirementsStatus);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Enrollment GetActiveEnrollment(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT TOP 1 EnrollmentId, StudentId, SectionCode, SchoolYear, AssessedFee, EnrollmentDate, Status,
                                 HasPSA, HasForm138, HasGoodMoral, HasForm137, RequirementsStatus
                    FROM Enrollments
                    WHERE StudentId = @StudentId AND Status = 'Enrolled'
                    ORDER BY EnrollmentDate DESC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Enrollment
                            {
                                EnrollmentId = Convert.ToInt32(reader["EnrollmentId"]),
                                StudentId = reader["StudentId"].ToString(),
                                SectionCode = reader["SectionCode"].ToString(),
                                SchoolYear = reader["SchoolYear"].ToString(),
                                AssessedFee = Convert.ToDecimal(reader["AssessedFee"]),
                                EnrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"]),
                                Status = reader["Status"].ToString(),
                                HasPSA = Convert.ToBoolean(reader["HasPSA"]),
                                HasForm138 = Convert.ToBoolean(reader["HasForm138"]),
                                HasGoodMoral = Convert.ToBoolean(reader["HasGoodMoral"]),
                                HasForm137 = Convert.ToBoolean(reader["HasForm137"]),
                                RequirementsStatus = reader["RequirementsStatus"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public (bool Success, string Message) CancelEnrollment(string studentId, string reason)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {
                        int enrollmentId = 0;
                        string schoolYear = "";
                        using (var findCmd = new SqlCommand(
                            "SELECT TOP 1 EnrollmentId, SchoolYear FROM Enrollments WHERE StudentId = @StudentId AND Status = 'Enrolled' ORDER BY EnrollmentDate DESC", conn, tx))
                        {
                            findCmd.Parameters.AddWithValue("@StudentId", studentId);
                            using (var r = findCmd.ExecuteReader())
                            {
                                if (r.Read())
                                {
                                    enrollmentId = Convert.ToInt32(r["EnrollmentId"]);
                                    schoolYear = r["SchoolYear"].ToString();
                                }
                            }
                        }

                        if (enrollmentId == 0)
                        {
                            tx.Rollback();
                            return (false, "No active enrollment found for this student to cancel.");
                        }

                        using (var payCheck = new SqlCommand(@"
                            SELECT ISNULL(SUM(p.AmountPaid), 0)
                            FROM Payments p
                            INNER JOIN Assessments a ON p.AssessmentId = a.AssessmentId
                            WHERE a.StudentId = @StudentId AND a.SchoolYear = @SchoolYear AND a.Status <> 'Voided'", conn, tx))
                        {
                            payCheck.Parameters.AddWithValue("@StudentId", studentId);
                            payCheck.Parameters.AddWithValue("@SchoolYear", schoolYear);
                            decimal paidAmount = Convert.ToDecimal(payCheck.ExecuteScalar());

                            if (paidAmount > 0)
                            {
                                tx.Rollback();
                                return (false,
                                    $"Cannot cancel enrollment for School Year {schoolYear} because PHP {paidAmount:N2} in payments has already been recorded.\n\n" +
                                    "Please coordinate with the Cashier / Accounting office for refund or withdrawal adjustment first.");
                            }
                        }

                        using (var cancelCmd = new SqlCommand(@"
                            UPDATE Enrollments
                            SET Status = 'Cancelled',
                                CancellationReason = @Reason,
                                CancelledDate = GETDATE()
                            WHERE EnrollmentId = @EnrollmentId", conn, tx))
                        {
                            cancelCmd.Parameters.AddWithValue("@Reason", reason);
                            cancelCmd.Parameters.AddWithValue("@EnrollmentId", enrollmentId);
                            cancelCmd.ExecuteNonQuery();
                        }

                        using (var voidAsmCmd = new SqlCommand(@"
                            UPDATE Assessments
                            SET Status = 'Voided'
                            WHERE StudentId = @StudentId AND SchoolYear = @SchoolYear AND Status IN ('Unpaid', 'Partial')", conn, tx))
                        {
                            voidAsmCmd.Parameters.AddWithValue("@StudentId", studentId);
                            voidAsmCmd.Parameters.AddWithValue("@SchoolYear", schoolYear);
                            voidAsmCmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                        return (true, $"Enrollment for School Year {schoolYear} has been cancelled/voided. The section slot has been released and any unpaid assessment was voided.");
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        return (false, "Database error while cancelling enrollment: " + ex.Message);
                    }
                }
            }
        }

        public string GetStudentStatus(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Status FROM Students WHERE StudentId = @StudentId", conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                var result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "";
            }
        }

        public bool IsStudentAlreadyEnrolled(string studentId, string schoolYear)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Enrollments WHERE StudentId = @StudentId AND SchoolYear = @SchoolYear AND Status = 'Enrolled'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public (bool IsFull, int CurrentCount, int Capacity) CheckSectionCapacity(string sectionCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        s.Capacity,
                        (SELECT COUNT(*) FROM Enrollments e WHERE e.SectionCode = s.SectionCode AND e.Status = 'Enrolled') AS CurrentCount
                    FROM Sections s
                    WHERE s.SectionCode = @SectionCode";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectionCode", sectionCode);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int capacity = Convert.ToInt32(reader["Capacity"]);
                            int currentCount = Convert.ToInt32(reader["CurrentCount"]);
                            return (currentCount >= capacity, currentCount, capacity);
                        }
                    }
                }
            }
            return (false, 0, 0);
        }

        public (bool HasUnpaidBalance, string UnpaidSchoolYear, decimal RemainingBalance) GetPreviousUnpaidBalance(string studentId, string targetSchoolYear)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT TOP 1
                        a.SchoolYear,
                        a.TotalAssessment - ISNULL((SELECT SUM(p.AmountPaid) FROM Payments p WHERE p.AssessmentId = a.AssessmentId), 0) AS RemainingBalance
                    FROM Assessments a
                    WHERE a.StudentId = @StudentId
                      AND a.SchoolYear <> @TargetSchoolYear
                      AND a.Status IN ('Unpaid', 'Partial')
                    ORDER BY a.AssessmentDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@TargetSchoolYear", targetSchoolYear);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string unpaidYear = reader["SchoolYear"].ToString();
                            decimal balance = Convert.ToDecimal(reader["RemainingBalance"]);
                            if (balance > 0)
                                return (true, unpaidYear, balance);
                        }
                    }
                }
            }
            return (false, "", 0m);
        }
    }
}