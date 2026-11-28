CREATE PROCEDURE SearchPaymentHistory
    @StudentId NVARCHAR(20) = NULL,
    @ReceiptId INT = NULL,
    @DateFrom DATE,
    @DateTo DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.ReceiptId, 
        p.PaymentDate, 
        p.StudentId, 
        (s.FirstName + ' ' + s.LastName) AS StudentName,
        ISNULL(sec.SectionName, 'N/A') AS Section,
        p.AmountPaid,
        p.PaymentMethod,
        p.ProcessedBy
    FROM Payments p
    INNER JOIN Students s ON p.StudentId = s.StudentId
    LEFT JOIN Assessments a ON p.AssessmentId = a.AssessmentId
    OUTER APPLY (
        SELECT TOP 1 e.SectionCode
        FROM Enrollments e
        WHERE e.StudentId = p.StudentId
          AND (a.SchoolYear IS NULL OR e.SchoolYear = a.SchoolYear)
        ORDER BY CASE WHEN e.Status = 'Enrolled' THEN 0 ELSE 1 END, e.EnrollmentDate DESC
    ) e
    LEFT JOIN Sections sec ON e.SectionCode = sec.SectionCode
    WHERE CAST(p.PaymentDate AS DATE) >= @DateFrom 
      AND CAST(p.PaymentDate AS DATE) <= @DateTo
      AND (@StudentId IS NULL OR p.StudentId = @StudentId)
      AND (@ReceiptId IS NULL OR p.ReceiptId = @ReceiptId)
    ORDER BY p.PaymentDate DESC;
END