CREATE PROCEDURE GetAllSections
AS
BEGIN
    SELECT SectionCode, SectionName, GradeLevel, SchoolYear, Status 
    FROM Sections;
END
GO