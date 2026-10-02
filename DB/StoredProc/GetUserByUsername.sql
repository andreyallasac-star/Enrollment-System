CREATE PROCEDURE GetUserByUsername
    @Username NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Users WHERE Username = @Username;
END
GO