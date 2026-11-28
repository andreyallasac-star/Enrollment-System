using System;

namespace Model
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public string StudentId { get; set; }
        public string SectionCode { get; set; }
        public string SchoolYear { get; set; }
        public decimal AssessedFee { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; }
        public bool HasPSA { get; set; }
        public bool HasForm138 { get; set; }
        public bool HasGoodMoral { get; set; }
        public bool HasForm137 { get; set; }
        public string RequirementsStatus { get; set; } = "Complete";
        public string CancellationReason { get; set; }
        public DateTime? CancelledDate { get; set; }
    }
}