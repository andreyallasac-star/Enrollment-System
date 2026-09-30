using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Model;

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
                var cmd = new SqlCommand("INSERT INTO Sections (SectionCode, SectionName, GradeLevel, SchoolYear, Capacity, Status) VALUES (@Code, @Name, @Grade, @Year, @Capacity, 'Active')", conn);
                cmd.Parameters.AddWithValue("@Code", section.SectionCode);
                cmd.Parameters.AddWithValue("@Name", section.SectionName);
                cmd.Parameters.AddWithValue("@Grade", section.GradeLevel);
                cmd.Parameters.AddWithValue("@Year", section.SchoolYear);
                cmd.Parameters.AddWithValue("@Capacity", section.Capacity);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Section> GetAllSections()
        {
            var sections = new List<Section>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT SectionCode, SectionName, GradeLevel, SchoolYear, Capacity, Status FROM Sections", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sections.Add(new Section
                        {
                            SectionCode = reader["SectionCode"].ToString(),
                            SectionName = reader["SectionName"].ToString(),
                            GradeLevel = reader["GradeLevel"].ToString(),
                            SchoolYear = reader["SchoolYear"].ToString(),
                            Capacity = (int)reader["Capacity"],
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return sections;
        }

        public bool UpdateSection(Section section)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE Sections SET SectionName = @Name, GradeLevel = @Grade, SchoolYear = @Year, Capacity = @Capacity WHERE SectionCode = @Code", conn);
                cmd.Parameters.AddWithValue("@Name", section.SectionName);
                cmd.Parameters.AddWithValue("@Grade", section.GradeLevel);
                cmd.Parameters.AddWithValue("@Year", section.SchoolYear);
                cmd.Parameters.AddWithValue("@Capacity", section.Capacity);
                cmd.Parameters.AddWithValue("@Code", section.SectionCode);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeactivateSection(string sectionCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE Sections SET Status = 'Inactive' WHERE SectionCode = @Code", conn);
                cmd.Parameters.AddWithValue("@Code", sectionCode);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
