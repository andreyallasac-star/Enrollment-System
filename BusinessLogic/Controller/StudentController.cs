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

            return _studentRepo.CreateStudent(student) ? "Success" : "Failed to create student.";
        }

        public string UpdateStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName))
                return "First and Last names are required.";

            if (string.IsNullOrWhiteSpace(student.StudentType))
                return "Please select a Student Type (New, Old, or Transferee).";

            return _studentRepo.UpdateStudent(student) ? "Success" : "Failed to update student.";
        }

        public string DeactivateStudent(string studentId)
        {
            return _studentRepo.DeactivateStudent(studentId) ? "Success" : "Failed to deactivate student.";
        }

        public string ActivateStudent(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                return "System Error: No valid student ID detected from the selection.";

            return _studentRepo.ActivateStudent(studentId) ? "Success" : "Failed to activate student.";
        }

        public string GetNextStudentId()
        {
            return _studentRepo.GenerateNextStudentId();
        }
    }
}