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
            try
            {
                return _assessmentRepo.GetTuitionFee(gradeLevel, schoolYear);
            }
            catch (Exception)
            {
                return 0.00m;
            }
        }

        public string SaveAssessment(Assessment assessment)
        {
            if (string.IsNullOrWhiteSpace(assessment.StudentId))
                return "Please enter a valid Student ID.";

            if (string.IsNullOrWhiteSpace(assessment.SchoolYear))
                return "Student must be officially enrolled to have a valid School Year.";

            if (assessment.TotalAssessment <= 0)
                return "Please compute the fees before saving. Total Assessment must be greater than zero.";

            try
            {
                if (_assessmentRepo.CheckAssessmentExists(assessment.StudentId, assessment.SchoolYear))
                {
                    return "This student has already been assessed for the current school year.";
                }

                return _assessmentRepo.SaveAssessment(assessment) ? "Success" : "Database Error: Could not save assessment.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
