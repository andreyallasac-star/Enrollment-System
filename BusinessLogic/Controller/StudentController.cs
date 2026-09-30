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

        public string CreateStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.StudentId)) 
                return "Student ID is required.";

            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName)) 
                return "First and Last names are required.";

            return _studentRepo.CreateStudent(student) ? "Success" : "Failed to create student.";
        }

        public string UpdateStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName)) 
                return "First and Last names are required.";

            return _studentRepo.UpdateStudent(student) ? "Success" : "Failed to update student.";
        }

        public string DeactivateStudent(string studentId) 
        { 
            return _studentRepo.DeactivateStudent(studentId) ? "Success" : "Failed to deactivate student."; 
        }
    }
}
