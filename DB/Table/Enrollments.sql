CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId NVARCHAR(20) NOT NULL, 
    SectionCode NVARCHAR(20) NOT NULL,
    SchoolYear NVARCHAR(10) NOT NULL,
    AssessedFee DECIMAL(18,2) NOT NULL,
    EnrollmentDate DATETIME NOT NULL DEFAULT GETDATE(),
    Status NVARCHAR(20) NOT NULL DEFAULT 'Enrolled',
    HasPSA BIT NOT NULL DEFAULT 1,
    HasForm138 BIT NOT NULL DEFAULT 1,
    HasGoodMoral BIT NOT NULL DEFAULT 1,
    HasForm137 BIT NOT NULL DEFAULT 0,
    RequirementsStatus NVARCHAR(30) NOT NULL DEFAULT 'Complete',
    CancellationReason NVARCHAR(255) NULL,
    CancelledDate DATETIME NULL,
    
    CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StudentId) REFERENCES Students(StudentId) ON DELETE CASCADE,
    CONSTRAINT FK_Enrollments_Sections FOREIGN KEY (SectionCode) REFERENCES Sections(SectionCode) ON DELETE CASCADE
);