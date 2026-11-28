using System;

namespace Model
{
    public class StudentProfileDTO
    {
        public string StudentId { get; set; }
        public string LRN { get; set; }
        public string StudentType { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string SchoolYear { get; set; }
        public string GradeLevel { get; set; }
        public string Section { get; set; }
        public string RequirementsStatus { get; set; }
        public int AssessmentId { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal OtherFee { get; set; }
        public string DiscountName { get; set; } = "None";
        public decimal DiscountAmount { get; set; }
        public decimal TotalAssessment { get; set; }
        public string AssessmentStatus { get; set; } = "Not Assessed";
        public decimal TotalPaid { get; set; }
        public decimal RemainingBalance => Math.Max(0m, TotalAssessment - TotalPaid);
    }
}