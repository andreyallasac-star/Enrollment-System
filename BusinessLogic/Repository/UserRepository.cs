using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        private readonly string connectionString = "Server=DESKTOP-TCVIDJV\\SQLEXPRESS01; Database=EnrollmentSystemDB; Trusted_Connection=True; TrustServerCertificate=True;";

        public User GetByUsername(string username)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetUserByUsername", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            Role = reader["Role"].ToString(),
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public User GetById(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetUserById", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", userId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            Role = reader["Role"].ToString(),
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public bool CreateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("CreateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("GetAllUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            Role = reader["Role"].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return users;
        }

        public bool UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UpdateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@UserId", user.UserId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeactivateUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("DeactivateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", userId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ReactivateUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE Users SET Status = 'Active' WHERE UserId = @UserId", conn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}