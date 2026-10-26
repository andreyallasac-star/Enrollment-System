CREATE PROCEDURE UpdateUser
    @PasswordHash NVARCHAR(255),
    @Role NVARCHAR(20),
    @UserId INT
AS
BEGIN
    UPDATE Users 
    SET PasswordHash = @PasswordHash, Role = @Role 
    WHERE UserId = @UserId;
END
GO