CREATE PROCEDURE UpdateUser
    @PasswordHash NVARCHAR(255),
    @Role NVARCHAR(20),
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Users 
    SET PasswordHash = @PasswordHash, Role = @Role 
    WHERE UserId = @UserId;
END
GO