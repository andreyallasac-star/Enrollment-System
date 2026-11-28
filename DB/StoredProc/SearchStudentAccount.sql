CREATE PROCEDURE SearchStudentAccount
    @Keyword NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        s.StudentId,
        ISNULL(s.LRN, '') AS LRN,
        ISNULL(s.StudentType, '') AS StudentType,
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
        ISNULL(e.RequirementsStatus, 'N/A') AS RequirementsStatus,
        ISNULL(a.AssessmentId, 0) AS AssessmentId,
        ISNULL(a.TuitionFee, 0) AS TuitionFee,
        ISNULL(a.OtherFee, 0) AS OtherFee,
        ISNULL(a.DiscountName, 'None') AS DiscountName,
        ISNULL(a.DiscountAmount, 0) AS DiscountAmount,
        ISNULL(a.TotalAssessment, 0) AS TotalAssessment,
        ISNULL(a.Status, 'Not Assessed') AS AssessmentStatus,
        ISNULL((SELECT SUM(p.AmountPaid) FROM Payments p WHERE p.AssessmentId = a.AssessmentId), 0) AS TotalPaid
    FROM Students s
    OUTER APPLY (
        SELECT TOP 1 en.SchoolYear, en.SectionCode, en.RequirementsStatus
        FROM Enrollments en
        WHERE en.StudentId = s.StudentId AND en.Status = 'Enrolled'
        ORDER BY en.EnrollmentDate DESC
    ) e
    LEFT JOIN Sections sec ON e.SectionCode = sec.SectionCode
    OUTER APPLY (
        SELECT TOP 1 asm.AssessmentId, asm.TuitionFee, asm.OtherFee, asm.DiscountName, asm.DiscountAmount, asm.TotalAssessment, asm.Status
        FROM Assessments asm
        WHERE asm.StudentId = s.StudentId
          AND asm.SchoolYear = e.SchoolYear
          AND asm.Status <> 'Voided'
        ORDER BY asm.AssessmentId DESC
    ) a
    WHERE s.StudentId = @Keyword
       OR s.LRN = @Keyword
       OR (s.FirstName + ' ' + s.LastName) LIKE '%' + @Keyword + '%';
END