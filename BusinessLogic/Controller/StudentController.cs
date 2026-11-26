using BusinessLogic.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller
{
    public class StudentController
    {
        private readonly StudentRepository _studentRepo = new StudentRepository();

        public List<Student> GetAllStudents()
        {
            return _studentRepo.GetAllStudents();
        }

        public Student GetStudentById(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                return null;

            return _studentRepo.GetStudentById(studentId);
        }

        public string CreateStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.StudentId))
                return "Student ID is required.";

            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName))
                return "First and Last names are required.";

            if (string.IsNullOrWhiteSpace(student.StudentType))
                return "Please select a Student Type (New, Old, or Transferee).";

            try
            {
                if (_studentRepo.GetStudentById(student.StudentId) != null)
                    return $"Student ID '{student.StudentId}' already exists. Click Update to edit this student.";

                return _studentRepo.CreateStudent(student) ? "Success" : "Failed to create student.";
            }
            catch (Exception ex)
            {
                return "Database error while creating student: " + ex.Message;
            }
        }

        public string UpdateStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.StudentId))
                return "Please select a student to update.";

            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName))
                return "First and Last names are required.";

            if (string.IsNullOrWhiteSpace(student.StudentType))
                return "Please select a Student Type (New, Old, or Transferee).";

            try
            {
                return _studentRepo.UpdateStudent(student) ? "Success" : "Failed to update student.";
            }
            catch (Exception ex)
            {
                return "Database error while updating student: " + ex.Message;
            }
        }

        public string DeactivateStudent(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                return "Please select a student to deactivate.";

            try
            {
                return _studentRepo.DeactivateStudent(studentId) ? "Success" : "Failed to deactivate student.";
            }
            catch (Exception ex)
            {
                return "Database error while deactivating student: " + ex.Message;
            }
        }

        public string ActivateStudent(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                return "System Error: No valid student ID detected from the selection.";

            try
            {
                return _studentRepo.ActivateStudent(studentId) ? "Success" : "Failed to activate student.";
            }
            catch (Exception ex)
            {
                return "Database error while activating student: " + ex.Message;
            }
        }

        public string GetNextStudentId()
        {
            return _studentRepo.GenerateNextStudentId();
        }
    }
}