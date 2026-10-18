CREATE PROCEDURE CreateSection
    @SectionCode NVARCHAR(20),
    @SectionName NVARCHAR(100),
    @GradeLevel NVARCHAR(20),
    @SchoolYear NVARCHAR(10)
AS
BEGIN
    INSERT INTO Sections (SectionCode, SectionName, GradeLevel, SchoolYear, Status) 
    VALUES (@SectionCode, @SectionName, @GradeLevel, @SchoolYear, 'Active');
END
GO