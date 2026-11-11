using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class StudentRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EnrollmentDB"].ConnectionString;

        public bool CreateStudent(Student s)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("CreateStudent", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentId", s.StudentId);
                    cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", (object)s.MiddleName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", s.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", s.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", (object)s.Gender ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@HouseNo", (object)s.HouseNo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Barangay", (object)s.Barangay ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Municipality", (object)s.Municipality ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Province", (object)s.Province ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PostalCode", (object)s.PostalCode ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@GuardianFirstName", (object)s.GuardianFirstName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianMiddleName", (object)s.GuardianMiddleName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianLastName", (object)s.GuardianLastName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianContact", (object)s.GuardianContact ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianRelationship", (object)s.GuardianRelationship ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianGender", (object)s.GuardianGender ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@GuardianHouseNo", (object)s.GuardianHouseNo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianBarangay", (object)s.GuardianBarangay ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianMunicipality", (object)s.GuardianMunicipality ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianProvince", (object)s.GuardianProvince ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GuardianPostalCode", (object)s.GuardianPostalCode ?? DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }




        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetAllStudents", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentId = reader["StudentId"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Gender = reader["Gender"].ToString(),

                            HouseNo = reader["HouseNo"].ToString(),
                            Barangay = reader["Barangay"].ToString(),
                            Municipality = reader["Municipality"].ToString(),
                            Province = reader["Province"].ToString(),
                            PostalCode = reader["PostalCode"].ToString(),

                            GuardianFirstName = reader["GuardianFirstName"].ToString(),
                            GuardianMiddleName = reader["GuardianMiddleName"].ToString(),
                            GuardianLastName = reader["GuardianLastName"].ToString(),
                            GuardianContact = reader["GuardianContact"].ToString(),
                            GuardianRelationship = reader["GuardianRelationship"].ToString(),
                            GuardianGender = reader["GuardianGender"].ToString(),

                            GuardianHouseNo = reader["GuardianHouseNo"].ToString(),
                            GuardianBarangay = reader["GuardianBarangay"].ToString(),
                            GuardianMunicipality = reader["GuardianMunicipality"].ToString(),
                            GuardianProvince = reader["GuardianProvince"].ToString(),
                            GuardianPostalCode = reader["GuardianPostalCode"].ToString(),

                            Status = reader["AccountStatus"].ToString(),
                            EnrollmentStatus = reader["EnrollmentStatus"].ToString()
                        });
                    }
                }
            }
            return students;
        }

        public Student GetStudentById(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetStudentById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            StudentId = reader["StudentId"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Gender = reader["Gender"].ToString(),

                            HouseNo = reader["HouseNo"].ToString(),
                            Barangay = reader["Barangay"].ToString(),
                            Municipality = reader["Municipality"].ToString(),
                            Province = reader["Province"].ToString(),
                            PostalCode = reader["PostalCode"].ToString(),

                            GuardianFirstName = reader["GuardianFirstName"].ToString(),
                            GuardianMiddleName = reader["GuardianMiddleName"].ToString(),
                            GuardianLastName = reader["GuardianLastName"].ToString(),
                            GuardianContact = reader["GuardianContact"].ToString(),
                            GuardianRelationship = reader["GuardianRelationship"].ToString(),
                            GuardianGender = reader["GuardianGender"].ToString(),

                            GuardianHouseNo = reader["GuardianHouseNo"].ToString(),
                            GuardianBarangay = reader["GuardianBarangay"].ToString(),
                            GuardianMunicipality = reader["GuardianMunicipality"].ToString(),
                            GuardianProvince = reader["GuardianProvince"].ToString(),
                            GuardianPostalCode = reader["GuardianPostalCode"].ToString(),

                            Status = reader["AccountStatus"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public bool UpdateStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UpdateStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", student.StudentId);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", student.Gender ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@HouseNo", student.HouseNo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Barangay", student.Barangay ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Municipality", student.Municipality ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Province", student.Province ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PostalCode", student.PostalCode ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@GuardianFirstName", student.GuardianFirstName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianMiddleName", student.GuardianMiddleName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianLastName", student.GuardianLastName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianContact", student.GuardianContact ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianRelationship", student.GuardianRelationship ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianGender", student.GuardianGender ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@GuardianHouseNo", student.GuardianHouseNo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianBarangay", student.GuardianBarangay ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianMunicipality", student.GuardianMunicipality ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianProvince", student.GuardianProvince ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GuardianPostalCode", student.GuardianPostalCode ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool DeactivateStudent(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("DeactivateStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActivateStudent(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Students SET Status = 'Active' WHERE StudentId = @StudentId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public string GenerateNextStudentId()
        {
            string yearPrefix = DateTime.Now.Year.ToString();
            string lastId = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetLatestStudentId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@YearPrefix", yearPrefix);

                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    lastId = result.ToString();
                }
            }

            int nextNumber = 1;
            if (!string.IsNullOrEmpty(lastId))
            {
                string[] parts = lastId.Split('-');
                if (parts.Length == 2 && int.TryParse(parts[1], out int currentNum))
                {
                    nextNumber = currentNum + 1;
                }
            }

            return $"{yearPrefix}-{nextNumber:D4}";
        }
    }
}
