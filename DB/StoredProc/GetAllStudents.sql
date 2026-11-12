Create  PROCEDURE GetAllStudents
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        s.StudentId, s.FirstName, s.MiddleName, s.LastName, s.DateOfBirth, s.Gender, 
        s.StudentType, 
        s.HouseNo, s.Barangay, s.Municipality, s.Province, s.PostalCode,
        s.GuardianFirstName, s.GuardianMiddleName, s.GuardianLastName, s.GuardianContact, 
        s.GuardianRelationship, s.GuardianGender, s.GuardianHouseNo, s.GuardianBarangay, 
        s.GuardianMunicipality, s.GuardianProvince, s.GuardianPostalCode,
        s.Status AS AccountStatus,
        ISNULL(e.Status, 'Not Enrolled') AS EnrollmentStatus
    FROM Students s
    LEFT JOIN (
        SELECT StudentId, Status,
               ROW_NUMBER() OVER(PARTITION BY StudentId ORDER BY EnrollmentDate DESC) as rn
        FROM Enrollments WHERE Status = 'Enrolled'
    ) e ON s.StudentId = e.StudentId AND e.rn = 1;
END