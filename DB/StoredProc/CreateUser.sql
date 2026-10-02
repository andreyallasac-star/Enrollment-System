CREATE PROCEDURE CreateUser
    @Username NVARCHAR(50),
    @PasswordHash NVARCHAR(255),
    @Role NVARCHAR(20)
AS
BEGIN
    INSERT INTO Users (Username, PasswordHash, Role, Status) 
    VALUES (@Username, @PasswordHash, @Role, 'Active');
END
GO