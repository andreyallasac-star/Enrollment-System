CREATE PROCEDURE GetStudentById
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        StudentId,
        FirstName, 
        MiddleName, 
        LastName, 
        DateOfBirth,
        Gender, 
        StudentType,
        HouseNo, 
        Barangay, 
        Municipality,
        Province,
        PostalCode,
        GuardianFirstName,
        GuardianMiddleName, 
        GuardianLastName, 
        GuardianContact, 
        GuardianRelationship,
        GuardianGender, 
        GuardianHouseNo,
        GuardianBarangay, 
        GuardianMunicipality,
        GuardianProvince,
        GuardianPostalCode,
        Status AS AccountStatus
    FROM Students
    WHERE StudentId = @StudentId;
END