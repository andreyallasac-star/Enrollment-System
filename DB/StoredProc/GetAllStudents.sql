CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SET NOCOUNT ON;
    SELECT StudentId, FirstName, MiddleName, LastName, DateOfBirth, Gender, Address, Status FROM Students;
END