CREATE PROCEDURE UpdateSection
    @SectionCode NVARCHAR(20),
    @SectionName NVARCHAR(100),
    @GradeLevel NVARCHAR(20),
    @SchoolYear NVARCHAR(10)
AS
BEGIN
    UPDATE Sections 
    SET SectionName = @SectionName,
        GradeLevel = @GradeLevel, 
        SchoolYear = @SchoolYear
    WHERE SectionCode = @SectionCode;
END