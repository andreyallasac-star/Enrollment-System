using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class EnrollmentRepository
    {
        private readonly string connectionString = "Server=DESKTOP-TCVIDJV\\SQLEXPRESS01; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

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
    }
}
