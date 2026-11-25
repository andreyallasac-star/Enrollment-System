using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class SectionRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

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
                cmd.Parameters.AddWithValue("@Capacity", section.Capacity);

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
                cmd.Parameters.AddWithValue("@Capacity", section.Capacity);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeactivateSection(string sectionCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Sections SET Status = 'Inactive' WHERE SectionCode = @SectionCode AND Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectionCode", sectionCode);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ActivateSection(string sectionCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Sections SET Status = 'Active' WHERE SectionCode = @SectionCode AND Status = 'Inactive'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectionCode", sectionCode);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SectionCodeExists(string sectionCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM Sections WHERE SectionCode = @SectionCode", conn))
                {
                    cmd.Parameters.AddWithValue("@SectionCode", sectionCode);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
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
                            Capacity = reader["Capacity"] != DBNull.Value ? Convert.ToInt32(reader["Capacity"]) : 40,
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return sections;
        }

        public List<string> GetDistinctSchoolYears()
        {
            var schoolYears = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT DISTINCT SchoolYear FROM Sections ORDER BY SchoolYear DESC", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        schoolYears.Add(reader["SchoolYear"].ToString());
                    }
                }
            }
            return schoolYears;
        }
    }
}