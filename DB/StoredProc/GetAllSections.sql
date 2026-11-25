CREATE PROCEDURE GetAllSections
AS
BEGIN
    SELECT SectionCode, SectionName, GradeLevel, SchoolYear, Capacity, Status 
    FROM Sections;
END