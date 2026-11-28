using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class StudentSearchRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

        public StudentProfileDTO SearchStudent(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("SearchStudentAccount", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", keyword);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new StudentProfileDTO
                        {
                            StudentId = reader["StudentId"].ToString(),
                            LRN = reader["LRN"] != DBNull.Value ? reader["LRN"].ToString() : "",
                            StudentType = reader["StudentType"] != DBNull.Value ? reader["StudentType"].ToString() : "",
                            FullName = reader["FullName"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]).ToString("yyyy-MM-dd"),
                            Gender = reader["Gender"].ToString(),
                            Address = reader["Address"].ToString(),
                            SchoolYear = reader["SchoolYear"] != DBNull.Value ? reader["SchoolYear"].ToString() : "Not Enrolled",
                            GradeLevel = reader["GradeLevel"] != DBNull.Value ? reader["GradeLevel"].ToString() : "N/A",
                            Section = reader["Section"] != DBNull.Value ? reader["Section"].ToString() : "N/A",
                            RequirementsStatus = reader["RequirementsStatus"] != DBNull.Value ? reader["RequirementsStatus"].ToString() : "N/A",
                            AssessmentId = reader["AssessmentId"] != DBNull.Value ? Convert.ToInt32(reader["AssessmentId"]) : 0,
                            TuitionFee = reader["TuitionFee"] != DBNull.Value ? Convert.ToDecimal(reader["TuitionFee"]) : 0m,
                            OtherFee = reader["OtherFee"] != DBNull.Value ? Convert.ToDecimal(reader["OtherFee"]) : 0m,
                            DiscountName = reader["DiscountName"] != DBNull.Value ? reader["DiscountName"].ToString() : "None",
                            DiscountAmount = reader["DiscountAmount"] != DBNull.Value ? Convert.ToDecimal(reader["DiscountAmount"]) : 0m,
                            TotalAssessment = Convert.ToDecimal(reader["TotalAssessment"]),
                            AssessmentStatus = reader["AssessmentStatus"] != DBNull.Value ? reader["AssessmentStatus"].ToString() : "Not Assessed",
                            TotalPaid = Convert.ToDecimal(reader["TotalPaid"])
                        };
                    }
                }
            }
            return null;
        }
    }
}