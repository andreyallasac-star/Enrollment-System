using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Model;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class AssessmentRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

        public List<Discount> GetActiveDiscounts()
        {
            var discounts = new List<Discount>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "SELECT DiscountId, DiscountName, DiscountPercent, IsActive " +
                        "FROM Discounts WHERE IsActive = 1 " +
                        "ORDER BY DiscountPercent ASC, DiscountName ASC", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            discounts.Add(new Discount
                            {
                                DiscountId = Convert.ToInt32(reader["DiscountId"]),
                                DiscountName = reader["DiscountName"].ToString(),
                                DiscountPercent = Convert.ToDecimal(reader["DiscountPercent"]),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error while fetching discounts: " + ex.Message);
            }
            return discounts;
        }

        public decimal GetTuitionFee(string gradeLevel, string schoolYear)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT TuitionFee FROM GradeLevelFees WHERE GradeLevel = @GradeLevel AND SchoolYear = @SchoolYear", conn);
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeLevel);
                    cmd.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        return Convert.ToDecimal(result);

                    var fallbackCmd = new SqlCommand(
                        "SELECT TOP 1 TuitionFee FROM GradeLevelFees WHERE GradeLevel = @GradeLevel ORDER BY SchoolYear DESC, FeeId DESC", conn);
                    fallbackCmd.Parameters.AddWithValue("@GradeLevel", gradeLevel);

                    var fallbackResult = fallbackCmd.ExecuteScalar();
                    return (fallbackResult != null && fallbackResult != DBNull.Value) ? Convert.ToDecimal(fallbackResult) : 0.00m;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error while fetching tuition fee: " + ex.Message);
            }
        }

        public bool SaveAssessment(Assessment assessment)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "INSERT INTO Assessments (StudentId, SchoolYear, TuitionFee, OtherFee, DiscountName, DiscountAmount, TotalAssessment, Status) " +
                        "VALUES (@StudentId, @SchoolYear, @TuitionFee, @OtherFee, @DiscountName, @DiscountAmount, @TotalAssessment, @Status)", conn);

                    string initialStatus = assessment.TotalAssessment <= 0 ? "Paid" : "Unpaid";

                    cmd.Parameters.AddWithValue("@StudentId", assessment.StudentId);
                    cmd.Parameters.AddWithValue("@SchoolYear", assessment.SchoolYear);
                    cmd.Parameters.AddWithValue("@TuitionFee", assessment.TuitionFee);
                    cmd.Parameters.AddWithValue("@OtherFee", assessment.OtherFee);
                    cmd.Parameters.AddWithValue("@DiscountName", string.IsNullOrWhiteSpace(assessment.DiscountName) ? "None" : assessment.DiscountName);
                    cmd.Parameters.AddWithValue("@DiscountAmount", assessment.DiscountAmount);
                    cmd.Parameters.AddWithValue("@TotalAssessment", assessment.TotalAssessment);
                    cmd.Parameters.AddWithValue("@Status", initialStatus);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error while saving assessment: " + ex.Message);
            }
        }

        public bool CheckAssessmentExists(string studentId, string schoolYear)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "SELECT COUNT(1) FROM Assessments WHERE StudentId = @StudentId AND SchoolYear = @SchoolYear AND Status <> 'Voided'", conn);
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error while checking existing assessments: " + ex.Message);
            }
        }

        public bool IsStudentEnrolled(string studentId, string schoolYear)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "SELECT COUNT(1) FROM Enrollments WHERE StudentId = @StudentId AND SchoolYear = @SchoolYear AND Status = 'Enrolled'", conn);
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error while checking enrollment: " + ex.Message);
            }
        }
    }
}