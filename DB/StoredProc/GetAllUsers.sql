CREATE PROCEDURE GetAllUsers
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UserId, Username, PasswordHash, Role, Status FROM Users;
END
GO