CREATE PROCEDURE DeactivateStudent
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Students SET Status = 'Inactive' WHERE StudentId = @StudentId;
END