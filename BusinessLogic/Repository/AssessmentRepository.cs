using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class AssessmentRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

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
                    return result != null ? Convert.ToDecimal(result) : 0.00m;
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
                        "INSERT INTO Assessments (StudentId, SchoolYear, TuitionFee, OtherFee, TotalAssessment, Status) " +
                        "VALUES (@StudentId, @SchoolYear, @TuitionFee, @OtherFee, @TotalAssessment, 'Unpaid')", conn);

                    cmd.Parameters.AddWithValue("@StudentId", assessment.StudentId);
                    cmd.Parameters.AddWithValue("@SchoolYear", assessment.SchoolYear);
                    cmd.Parameters.AddWithValue("@TuitionFee", assessment.TuitionFee);
                    cmd.Parameters.AddWithValue("@OtherFee", assessment.OtherFee);
                    cmd.Parameters.AddWithValue("@TotalAssessment", assessment.TotalAssessment);

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
                    var cmd = new SqlCommand("SELECT COUNT(1) FROM Assessments WHERE StudentId = @StudentId AND SchoolYear = @SchoolYear", conn);
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
    }
}
