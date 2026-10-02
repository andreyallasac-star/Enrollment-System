CREATE PROCEDURE DeactivateUser
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Users SET Status = 'Inactive' WHERE UserId = @UserId;
END
GO