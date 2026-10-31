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
                return "Please enter a valid Student ID.";

            if (string.IsNullOrWhiteSpace(assessment.SchoolYear))
                return "Student must be officially enrolled to have a valid School Year.";

            if (assessment.TotalAssessment <= 0)
                return "Please compute the fees before saving. Total Assessment must be greater than zero.";

            return _assessmentRepo.SaveAssessment(assessment) ? "Success" : "Database Error: Could not save assessment.";
        }
    }
}
