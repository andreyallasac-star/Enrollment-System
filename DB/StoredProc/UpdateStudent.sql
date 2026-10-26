CREATE PROCEDURE UpdateStudent
    @StudentId NVARCHAR(20),
    @FirstName NVARCHAR(50),
    @MiddleName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Address NVARCHAR(255),
    @Gender NVARCHAR(10)
AS
BEGIN
    UPDATE Students 
    SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, 
        DateOfBirth = @DateOfBirth, Address = @Address, Gender = @Gender 
    WHERE StudentId = @StudentId;
END