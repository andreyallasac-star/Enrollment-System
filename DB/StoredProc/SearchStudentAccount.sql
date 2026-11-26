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
        CONCAT_WS(', ',
        NULLIF(s.HouseNo, ''),
        NULLIF(s.Barangay, ''), 
        NULLIF(s.Municipality, ''), 
        NULLIF(s.Province, '')) AS Address,
        e.SchoolYear,
        sec.GradeLevel,
        sec.SectionName AS Section, 
        ISNULL(a.TotalAssessment, 0) AS TotalAssessment,
        ISNULL((SELECT SUM(p.AmountPaid) FROM Payments p WHERE p.AssessmentId = a.AssessmentId), 0) AS TotalPaid
    FROM Students s
    OUTER APPLY (
        SELECT TOP 1 en.SchoolYear, en.SectionCode
        FROM Enrollments en
        WHERE en.StudentId = s.StudentId AND en.Status = 'Enrolled'
        ORDER BY en.EnrollmentDate DESC
    ) e
    LEFT JOIN Sections sec ON e.SectionCode = sec.SectionCode
    OUTER APPLY (
        SELECT TOP 1 asm.AssessmentId, asm.TotalAssessment
        FROM Assessments asm
        WHERE asm.StudentId = s.StudentId AND asm.SchoolYear = e.SchoolYear
        ORDER BY asm.AssessmentId DESC
    ) a
    WHERE s.StudentId = @Keyword OR (s.FirstName + ' ' + s.LastName) LIKE '%' + @Keyword + '%';
END