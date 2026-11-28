using System;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class EnrollmentController
    {
        private readonly EnrollmentRepository _enrollmentRepo = new EnrollmentRepository();

        public (bool IsFull, int CurrentCount, int Capacity) GetSectionCapacity(string sectionCode)
        {
            if (string.IsNullOrWhiteSpace(sectionCode))
                return (false, 0, 0);

            try
            {
                return _enrollmentRepo.CheckSectionCapacity(sectionCode);
            }
            catch
            {
                return (false, 0, 0);
            }
        }

        public Enrollment GetActiveEnrollment(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId)) return null;
            try
            {
                return _enrollmentRepo.GetActiveEnrollment(studentId);
            }
            catch
            {
                return null;
            }
        }

        public (bool Success, string Message) CancelEnrollment(string studentId, string reason)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                return (false, "Please search for an enrolled student first.");

            if (string.IsNullOrWhiteSpace(reason))
                return (false, "Please provide a reason for cancelling/voiding this enrollment.");

            return _enrollmentRepo.CancelEnrollment(studentId.Trim(), reason.Trim());
        }

        public string EnrollStudent(Enrollment enrollment)
        {
            if (string.IsNullOrWhiteSpace(enrollment.StudentId))
                return "Student ID is required. Please search for a student first.";

            if (string.IsNullOrWhiteSpace(enrollment.SectionCode))
                return "Please select a Section.";

            if (string.IsNullOrWhiteSpace(enrollment.SchoolYear))
                return "Please select a School Year.";

            try
            {
                string studentStatus = _enrollmentRepo.GetStudentStatus(enrollment.StudentId);

                if (studentStatus == "Inactive")
                    return "Cannot enroll an inactive student. Please activate their account in Student Management first.";

                if (_enrollmentRepo.IsStudentAlreadyEnrolled(enrollment.StudentId, enrollment.SchoolYear))
                    return $"Student {enrollment.StudentId} is already enrolled for the {enrollment.SchoolYear} school year.";

                var balanceCheck = _enrollmentRepo.GetPreviousUnpaidBalance(enrollment.StudentId, enrollment.SchoolYear);
                if (balanceCheck.HasUnpaidBalance)
                    return $"Cannot enroll Student {enrollment.StudentId}. They still have an unpaid balance of PHP {balanceCheck.RemainingBalance:N2} from School Year {balanceCheck.UnpaidSchoolYear}. Please settle it at the Cashier first.";

                var capacityCheck = _enrollmentRepo.CheckSectionCapacity(enrollment.SectionCode);
                if (capacityCheck.Capacity > 0 && capacityCheck.IsFull)
                    return $"Section {enrollment.SectionCode} is full ({capacityCheck.CurrentCount}/{capacityCheck.Capacity}). Please choose another section.";

                return _enrollmentRepo.EnrollStudent(enrollment) ? "Success" : "Database error: Could not enroll student.";
            }
            catch (Exception ex)
            {
                return "Database error while enrolling student: " + ex.Message;
            }
        }
    }
}