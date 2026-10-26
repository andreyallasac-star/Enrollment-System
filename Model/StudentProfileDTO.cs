using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class StudentProfileDTO
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string SchoolYear { get; set; }
        public string GradeLevel { get; set; }
        public string Section { get; set; }
        public decimal TotalAssessment { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal RemainingBalance => TotalAssessment - TotalPaid;
    }
}
