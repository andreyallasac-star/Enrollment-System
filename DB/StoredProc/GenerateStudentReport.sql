CREATE PROCEDURE GenerateStudentReport
    @GradeLevel NVARCHAR(50) = NULL,
    @SectionCode NVARCHAR(20) = NULL,
    @SchoolYear NVARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        s.StudentId,
        s.FirstName + ' ' + ISNULL(s.MiddleName + ' ', '') + s.LastName AS FullName,
        sec.GradeLevel,
        sec.SectionName AS Section,
        e.EnrollmentDate AS DateEnrolled
    FROM Students s
    INNER JOIN Enrollments e ON s.StudentId = e.StudentId
    INNER JOIN Sections sec ON e.SectionCode = sec.SectionCode
    WHERE e.Status = 'Enrolled'
      AND (@GradeLevel IS NULL OR @GradeLevel = 'All' OR sec.GradeLevel = @GradeLevel)
      AND (@SectionCode IS NULL OR @SectionCode = 'All' OR sec.SectionCode = @SectionCode)
      AND (@SchoolYear IS NULL OR sec.SchoolYear = @SchoolYear)
    ORDER BY sec.GradeLevel, sec.SectionName, s.LastName, s.FirstName;
END