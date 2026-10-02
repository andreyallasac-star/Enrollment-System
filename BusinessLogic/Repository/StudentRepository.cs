using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogic.Repository
{
    public class StudentRepository
    {
        private readonly string connectionString = "Server=DESKTOP-TCVIDJV\\SQLEXPRESS01; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

        public bool CreateStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("CreateStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", student.StudentId);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@Address", student.Address ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", student.Gender ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
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
                            Address = reader["Address"].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return students;
        }

        public bool UpdateStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UpdateStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@Address", student.Address ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", student.Gender ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@StudentId", student.StudentId);

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
    }
}
