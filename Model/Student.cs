using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string HouseNo { get; set; }
        public string Barangay { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public string GuardianFirstName { get; set; }
        public string GuardianMiddleName { get; set; }
        public string GuardianLastName { get; set; }
        public string GuardianContact { get; set; }
        public string GuardianRelationship { get; set; }
        public string GuardianGender { get; set; }

        public string GuardianHouseNo { get; set; }
        public string GuardianBarangay { get; set; }
        public string GuardianMunicipality { get; set; }
        public string GuardianProvince { get; set; }
        public string GuardianPostalCode { get; set; }

        public string Status { get; set; }
        public string EnrollmentStatus { get; set; }
    }
}
