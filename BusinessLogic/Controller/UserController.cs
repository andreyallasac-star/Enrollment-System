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

        public User GetByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            return _userRepository.GetByUsername(username);
        }

        public string CreateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.PasswordHash))
                return "Username and password are required.";

            if (user.PasswordHash.Length < 8)
                return "Password must be at least 8 characters.";

            if (string.IsNullOrWhiteSpace(user.Role))
                return "Please select a valid Role.";

            try
            {
                var existing = _userRepository.GetByUsername(user.Username.Trim());
                if (existing != null)
                    return "Username already exists. Please choose another.";

                user.Username = user.Username.Trim();
                bool success = _userRepository.CreateUser(user);
                return success ? "Success" : "Database error: Could not create user.";
            }
            catch (Exception ex)
            {
                return "Database error while creating user: " + ex.Message;
            }
        }

        public string UpdateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.PasswordHash) || user.PasswordHash.Length < 8)

                
                return "Password must be at least 8 characters.";

            if (string.IsNullOrWhiteSpace(user.Role))
                return "Please select a valid Role.";

            try
            {
                bool success = _userRepository.UpdateUser(user);
                return success ? "Success" : "Database error: Could not update user.";
            }
            catch (Exception ex)
            {
                return "Database error while updating user: " + ex.Message;
            }
        }

        public string DeactivateUser(int userId)
        {
            if (userId <= 0)
                return "Invalid User ID.";

            try
            {
                bool success = _userRepository.DeactivateUser(userId);
                return success ? "Success" : "Database error: Could not deactivate user.";
            }
            catch (Exception ex)
            {
                return "Database error while deactivating user: " + ex.Message;
            }
        }

        public string ReactivateUser(int userId)
        {
            if (userId <= 0)
                return "Invalid User ID.";

            try
            {
                bool success = _userRepository.ReactivateUser(userId);
                return success ? "Success" : "Database error: Could not reactivate user.";
            }
            catch (Exception ex)
            {
                return "Database error while reactivating user: " + ex.Message;
            }
        }
    }
}