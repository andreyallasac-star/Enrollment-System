CREATE PROCEDURE DeactivateUser
    @UserId INT
AS
BEGIN
    UPDATE Users SET Status = 'Inactive' WHERE UserId = @UserId;
END
GO