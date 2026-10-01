using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class AssessmentController
    {
        private readonly AssessmentRepository _assessmentRepo = new AssessmentRepository();

        public decimal ComputeTuition(string gradeLevel, string schoolYear)
        {
            return _assessmentRepo.GetTuitionFee(gradeLevel, schoolYear);
        }

        public string SaveAssessment(Assessment assessment)
        {
            if (string.IsNullOrWhiteSpace(assessment.StudentId))
                return "Student ID is required.";

            if (string.IsNullOrWhiteSpace(assessment.SchoolYear))
                return "School Year is required.";

            if (assessment.TotalAssessment <= 0)
                return "Total assessment must be greater than zero.";

            return _assessmentRepo.SaveAssessment(assessment) ? "Success" : "Failed to save assessment to the database.";
        }
    }
}
