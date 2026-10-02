using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class StudentSearchRepository
    {
        private readonly string connectionString = "Server=DESKTOP-TCVIDJV\\SQLEXPRESS01; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

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
                            FullName = reader["FullName"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]).ToString("yyyy-MM-dd"),
                            Gender = reader["Gender"].ToString(),
                            Address = reader["Address"].ToString(),
                            SchoolYear = reader["SchoolYear"] != DBNull.Value ? reader["SchoolYear"].ToString() : "Not Enrolled",
                            GradeLevel = reader["GradeLevel"] != DBNull.Value ? reader["GradeLevel"].ToString() : "N/A",
                            Section = reader["Section"] != DBNull.Value ? reader["Section"].ToString() : "N/A",
                            TotalAssessment = Convert.ToDecimal(reader["TotalAssessment"]),
                            TotalPaid = Convert.ToDecimal(reader["TotalPaid"])
                        };
                    }
                }
            }
            return null;
        }
    }
}
