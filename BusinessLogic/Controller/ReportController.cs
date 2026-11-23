using System;
using BusinessLogic.Repository;
using System.Data;

namespace BusinessLogic.Controller
{
    public class ReportController
    {
        private readonly ReportRepository _reportRepo = new ReportRepository();

        public DataTable GenerateStudentReport(string gradeLevel, string sectionCode, string schoolYear)
        {
            if (string.IsNullOrWhiteSpace(gradeLevel)) gradeLevel = "All";
            if (string.IsNullOrWhiteSpace(sectionCode)) sectionCode = "All";

            return _reportRepo.GetStudentReport(gradeLevel, sectionCode, schoolYear);
        }
    }
}