CREATE PROCEDURE CreateStudent
    @StudentId NVARCHAR(20),
    @FirstName NVARCHAR(50),
    @MiddleName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Address NVARCHAR(255),
    @Gender NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Students (StudentId, FirstName, MiddleName, LastName, DateOfBirth, Address, Gender, Status) 
    VALUES (@StudentId, @FirstName, @MiddleName, @LastName, @DateOfBirth, @Address, @Gender, 'Active');
END