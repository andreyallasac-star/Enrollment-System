CREATE PROCEDURE GetLatestStudentId
    @YearPrefix NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 StudentId 
    FROM Students 
    WHERE StudentId LIKE @YearPrefix + '%' 
    ORDER BY StudentId DESC;
END
GO
