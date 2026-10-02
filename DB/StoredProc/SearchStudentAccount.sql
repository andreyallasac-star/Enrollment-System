CREATE PROCEDURE SearchStudentAccount
    @Keyword NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        s.StudentId,
        s.FirstName + ' ' + ISNULL(s.MiddleName + ' ', '') + s.LastName AS FullName,
        s.DateOfBirth,
        s.Gender,
        s.Address,
        e.SchoolYear,
        sec.GradeLevel,
        e.SectionCode AS Section,
        ISNULL((SELECT TOP 1 TotalAssessment FROM Assessments WHERE StudentId = s.StudentId ORDER BY AssessmentId DESC), 0) AS TotalAssessment,
        ISNULL((SELECT SUM(AmountPaid) FROM Payments WHERE StudentId = s.StudentId), 0) AS TotalPaid
    FROM Students s
    LEFT JOIN Enrollments e ON s.StudentId = e.StudentId AND e.Status = 'Enrolled'
    LEFT JOIN Sections sec ON e.SectionCode = sec.SectionCode
    WHERE s.StudentId = @Keyword OR (s.FirstName + ' ' + s.LastName) LIKE '%' + @Keyword + '%';
END