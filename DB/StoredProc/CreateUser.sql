CREATE PROCEDURE CreateUser
    @Username NVARCHAR(50),
    @PasswordHash NVARCHAR(255),
    @Role NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Users (Username, PasswordHash, Role, Status) 
    VALUES (@Username, @PasswordHash, @Role, 'Active');
END
GO