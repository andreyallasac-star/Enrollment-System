CREATE PROCEDURE GetAllSections
AS
BEGIN
    SET NOCOUNT ON;
    SELECT SectionCode, GradeLevel, Capacity, Status 
    FROM Sections;
END
GO