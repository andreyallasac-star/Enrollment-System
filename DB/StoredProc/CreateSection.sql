CREATE PROCEDURE CreateSection
    @SectionCode NVARCHAR(50),
    @GradeLevel NVARCHAR(50),
    @Capacity INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Sections (SectionCode, GradeLevel, Capacity, Status) 
    VALUES (@SectionCode, @GradeLevel, @Capacity, 'Active');
END
GO