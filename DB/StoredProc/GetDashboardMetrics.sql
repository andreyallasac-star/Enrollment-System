CREATE PROCEDURE GetDashboardMetrics
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        (SELECT COUNT(*) FROM Students WHERE Status = 'Active') AS TotalStudents,
        (SELECT COUNT(*) FROM Enrollments WHERE Status = 'Enrolled') AS CurrentlyEnrolled,
        (SELECT COUNT(*) FROM Sections WHERE Status = 'Active') AS TotalSections,
        (
            SELECT COUNT(DISTINCT e.StudentId) 
            FROM Enrollments e
            INNER JOIN Assessments a ON e.StudentId = a.StudentId AND e.SchoolYear = a.SchoolYear
            WHERE e.Status = 'Enrolled' 
              AND a.TotalAssessment > ISNULL((SELECT SUM(AmountPaid) FROM Payments p WHERE p.StudentId = e.StudentId), 0)
        ) AS PendingPayments;
END