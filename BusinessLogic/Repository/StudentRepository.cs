using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;

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
                var cmd = new SqlCommand(
                    "INSERT INTO Students (StudentId, FirstName, MiddleName, LastName, DateOfBirth, Address, Gender, Status) " +
                    "VALUES (@StudentId, @FirstName, @MiddleName, @LastName, @DateOfBirth, @Address, @Gender, 'Inactive')", conn);

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
                var cmd = new SqlCommand("SELECT StudentId, FirstName, MiddleName, LastName, DateOfBirth, Gender, Address, Status FROM Students", conn);
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
                var cmd = new SqlCommand(
                    "UPDATE Students SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, " +
                    "DateOfBirth = @DateOfBirth, Address = @Address, Gender = @Gender WHERE StudentId = @StudentId", conn);

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
                var cmd = new SqlCommand("UPDATE Students SET Status = 'Inactive' WHERE StudentId = @StudentId", conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
