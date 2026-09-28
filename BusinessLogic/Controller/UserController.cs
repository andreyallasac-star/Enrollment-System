using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public string CreateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.PasswordHash))
                return "Username and password are required.";

            if (user.PasswordHash.Length < 8)
                return "Password must be at least 8 characters.";

            var existing = _userRepository.GetByUsername(user.Username);
            if (existing != null)
                return "Username already exists. Please choose another.";

            bool success = _userRepository.CreateUser(user);
            return success ? "Success" : "Database error: Could not create user.";
        }

        public string UpdateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.PasswordHash) || user.PasswordHash.Length < 8)
                return "Password must be at least 8 characters.";

            bool success = _userRepository.UpdateUser(user);
            return success ? "Success" : "Database error: Could not update user.";
        }

        public string DeactivateUser(int userId)
        {
            if (userId <= 0)
                return "Invalid User ID.";

            bool success = _userRepository.DeactivateUser(userId);
            return success ? "Success" : "Database error: Could not deactivate user.";
        }

        public string ReactivateUser(int userId)
        {
            if (userId <= 0)
                return "Invalid User ID.";

            bool success = _userRepository.ReactivateUser(userId);
            return success ? "Success" : "Database error: Could not reactivate user.";
        }
    }
}