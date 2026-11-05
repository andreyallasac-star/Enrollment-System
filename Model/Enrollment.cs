using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
