using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class AssessmentRepository
    {
        private readonly string connectionString = "Server=DESKTOP-TCVIDJV\\SQLEXPRESS01; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

        public decimal GetTuitionFee(string gradeLevel, string schoolYear)
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

        public bool SaveAssessment(Assessment assessment)
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
    }
}
