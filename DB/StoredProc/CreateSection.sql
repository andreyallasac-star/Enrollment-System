CREATE PROCEDURE CreateSection
    @SectionCode NVARCHAR(20),
    @SectionName NVARCHAR(100),
    @GradeLevel NVARCHAR(20),
    @SchoolYear NVARCHAR(10),
    @Capacity INT = 40
AS
BEGIN
    INSERT INTO Sections (SectionCode, SectionName, GradeLevel, SchoolYear, Capacity, Status) 
    VALUES (@SectionCode, @SectionName, @GradeLevel, @SchoolYear, @Capacity, 'Active');
END