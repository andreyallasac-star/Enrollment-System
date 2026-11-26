using System;
using System.Collections.Generic;
using System.Text;
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

                return cmd.ExecuteNonQuery() > 0;
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