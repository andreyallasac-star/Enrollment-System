CREATE PROCEDURE GetDashboardMetrics
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        (SELECT COUNT(*) FROM Students WHERE Status = 'Active') AS TotalStudents,
        (SELECT COUNT(*) FROM Enrollments WHERE Status = 'Enrolled') AS CurrentlyEnrolled,
        (SELECT COUNT(*) FROM Sections WHERE Status = 'Active') AS TotalSections,
        (SELECT COUNT(DISTINCT StudentId) FROM Assessments WHERE Status IN ('Unpaid', 'Partial')) AS PendingPayments;
END