using System;
using System.Collections.Generic;
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
                string query = @"
                    SELECT 
                        s.StudentId,
                        s.FirstName + ' ' + ISNULL(s.MiddleName + ' ', '') + s.LastName AS FullName,
                        s.DateOfBirth,
                        s.Gender,
                        s.Address,
                        e.SchoolYear,
                        sec.GradeLevel,
                        e.SectionCode AS Section,
                        ISNULL((SELECT TOP 1 TotalAssessment FROM Assessments WHERE StudentId = s.StudentId ORDER BY AssessmentId DESC), 0) AS TotalAssessment,
                        ISNULL((SELECT SUM(AmountPaid) FROM Payments WHERE StudentId = s.StudentId), 0) AS TotalPaid
                    FROM Students s
                    LEFT JOIN Enrollments e ON s.StudentId = e.StudentId AND e.Status = 'Enrolled'
                    LEFT JOIN Sections sec ON e.SectionCode = sec.SectionCode
                    WHERE s.StudentId = @Keyword OR (s.FirstName + ' ' + s.LastName) LIKE '%' + @Keyword + '%'";

                var cmd = new SqlCommand(query, conn);
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
