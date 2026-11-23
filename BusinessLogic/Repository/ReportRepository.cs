using System;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BusinessLogic.Repository
{
    public class ReportRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

        public DataTable GetStudentReport(string gradeLevel, string sectionCode, string schoolYear)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GenerateStudentReport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@GradeLevel", string.IsNullOrWhiteSpace(gradeLevel) ? (object)System.DBNull.Value : gradeLevel);
                    cmd.Parameters.AddWithValue("@SectionCode", string.IsNullOrWhiteSpace(sectionCode) ? (object)System.DBNull.Value : sectionCode);
                    cmd.Parameters.AddWithValue("@SchoolYear", string.IsNullOrWhiteSpace(schoolYear) ? (object)System.DBNull.Value : schoolYear);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}