CREATE PROCEDURE DeactivateStudent
    @StudentId NVARCHAR(20)
AS
BEGIN
    UPDATE Students SET Status = 'Inactive' WHERE StudentId = @StudentId;
END