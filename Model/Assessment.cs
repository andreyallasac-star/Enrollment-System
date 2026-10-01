using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public string StudentId { get; set; }
        public string SchoolYear { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal OtherFee { get; set; }
        public decimal TotalAssessment { get; set; }
        public DateTime AssessmentDate { get; set; }
        public string Status { get; set; }
    }
}
