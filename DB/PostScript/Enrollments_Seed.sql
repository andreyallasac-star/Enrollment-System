;WITH Numbered AS (
    SELECT StudentId, ROW_NUMBER() OVER (ORDER BY StudentId) AS rn
    FROM Students
    WHERE LRN IS NULL OR LTRIM(RTRIM(LRN)) = ''
)
UPDATE s
SET s.LRN = '107823' + RIGHT('000000' + CAST(n.rn AS VARCHAR(6)), 6)
FROM Students s
INNER JOIN Numbered n ON s.StudentId = n.StudentId;

INSERT INTO Enrollments (StudentId, SectionCode, SchoolYear, AssessedFee, Status, HasPSA, HasForm138, HasGoodMoral, HasForm137, RequirementsStatus)
SELECT s.StudentId, v.SectionCode, '2026-2027', v.Fee, 'Enrolled', 1, 1, 1,
       CASE WHEN s.StudentType = 'Transferee' THEN 1 ELSE 0 END,
       'Complete'
FROM (VALUES
    ('2026-0001', 'GREEN', 10000.00),
    ('2026-0002', 'GREEN', 10000.00),
    ('2026-0003', 'GREEN', 10000.00),
    ('2026-0004', 'GREEN', 10000.00),
    ('2026-0005', 'GREEN', 10000.00),
    ('2026-0006', 'BLUE',  12500.00),
    ('2026-0007', 'BLUE',  12500.00),
    ('2026-0008', 'BLUE',  12500.00),
    ('2026-0009', 'BLUE',  12500.00),
    ('2026-0010', 'BLUE',  12500.00),
    ('2026-0011', 'RED',   13000.00),
    ('2026-0012', 'RED',   13000.00),
    ('2026-0013', 'RED',   13000.00),
    ('2026-0014', 'RED',   13000.00),
    ('2026-0015', 'RED',   13000.00),
    ('2026-0016', 'YELLOW', 14500.00),
    ('2026-0017', 'YELLOW', 14500.00),
    ('2026-0018', 'YELLOW', 14500.00),
    ('2026-0019', 'YELLOW', 14500.00),
    ('2026-0020', 'YELLOW', 14500.00)
) AS v(StudentId, SectionCode, Fee)
INNER JOIN Students s ON s.StudentId = v.StudentId
INNER JOIN Sections sec ON sec.SectionCode = v.SectionCode
WHERE NOT EXISTS (
    SELECT 1 FROM Enrollments e
    WHERE e.StudentId = v.StudentId AND e.SchoolYear = '2026-2027' AND e.Status = 'Enrolled'
);