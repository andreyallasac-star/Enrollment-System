using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class EnrollmentController
    {
        private readonly EnrollmentRepository _enrollmentRepo = new EnrollmentRepository();

        public string EnrollStudent(Enrollment enrollment)
        {
            string studentStatus = _enrollmentRepo.GetStudentStatus(enrollment.StudentId);

            if (string.IsNullOrWhiteSpace(enrollment.StudentId))
                return "Student ID is required. Please search for a student first.";

            if (studentStatus == "Inactive")
                return "Cannot enroll an inactive student. Please activate their account in Student Management first.";

            if (string.IsNullOrWhiteSpace(enrollment.SectionCode))
                return "Please select a Section.";

            if (string.IsNullOrWhiteSpace(enrollment.SchoolYear))
                return "Please select a School Year.";

            if (_enrollmentRepo.IsStudentAlreadyEnrolled(enrollment.StudentId, enrollment.SchoolYear))
                return $"Student {enrollment.StudentId} is already enrolled for the {enrollment.SchoolYear} school year.";

            return _enrollmentRepo.EnrollStudent(enrollment) ? "Success" : "Database error: Could not enroll student.";
        }
    }
}
