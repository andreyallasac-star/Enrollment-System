CREATE PROCEDURE EnrollStudent
    @StudentId NVARCHAR(50),
    @SectionCode NVARCHAR(20),
    @SchoolYear NVARCHAR(10),
    @AssessedFee DECIMAL(18,2)
AS
BEGIN
    INSERT INTO Enrollments (StudentId, SectionCode, SchoolYear, AssessedFee, Status)
    VALUES (@StudentId, @SectionCode, @SchoolYear, @AssessedFee, 'Enrolled');
END
GO