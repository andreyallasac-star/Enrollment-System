CREATE PROCEDURE EnrollStudent
    @StudentId NVARCHAR(50),
    @SectionCode NVARCHAR(20),
    @SchoolYear NVARCHAR(10),
    @AssessedFee DECIMAL(18,2),
    @HasPSA BIT = 1,
    @HasForm138 BIT = 1,
    @HasGoodMoral BIT = 1,
    @HasForm137 BIT = 0,
    @RequirementsStatus NVARCHAR(30) = 'Complete'
AS
BEGIN
    INSERT INTO Enrollments (
        StudentId, SectionCode, SchoolYear, AssessedFee, Status,
        HasPSA, HasForm138, HasGoodMoral, HasForm137, RequirementsStatus
    )
    VALUES (
        @StudentId, @SectionCode, @SchoolYear, @AssessedFee, 'Enrolled',
        @HasPSA, @HasForm138, @HasGoodMoral, @HasForm137, @RequirementsStatus
    );
END
GO