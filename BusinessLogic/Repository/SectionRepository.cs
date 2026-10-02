using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogic.Repository
{
    public class SectionRepository
    {
        private readonly string connectionString = "Server=DESKTOP-TCVIDJV\\SQLEXPRESS01; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

        public bool CreateSection(Section section)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("CreateSection", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SectionCode", section.SectionCode);
                cmd.Parameters.AddWithValue("@SectionName", section.SectionName);
                cmd.Parameters.AddWithValue("@GradeLevel", section.GradeLevel);
                cmd.Parameters.AddWithValue("@SchoolYear", section.SchoolYear);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateSection(Section section)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UpdateSection", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SectionCode", section.SectionCode);
                cmd.Parameters.AddWithValue("@SectionName", section.SectionName);
                cmd.Parameters.AddWithValue("@GradeLevel", section.GradeLevel);
                cmd.Parameters.AddWithValue("@SchoolYear", section.SchoolYear);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeactivateSection(string sectionCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("DeactivateSection", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SectionCode", sectionCode);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Section> GetAllSections()
        {
            var sections = new List<Section>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetAllSections", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sections.Add(new Section
                        {
                            SectionCode = reader["SectionCode"].ToString(),
                            SectionName = reader["SectionName"] != DBNull.Value ? reader["SectionName"].ToString() : "",
                            GradeLevel = reader["GradeLevel"].ToString(),
                            SchoolYear = reader["SchoolYear"] != DBNull.Value ? reader["SchoolYear"].ToString() : "",
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return sections;
        }
    }
}
