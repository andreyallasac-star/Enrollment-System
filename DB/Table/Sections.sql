CREATE TABLE Sections (
    SectionCode NVARCHAR(20) PRIMARY KEY,
    SectionName NVARCHAR(100) NOT NULL,
    GradeLevel NVARCHAR(20) NOT NULL,
    SchoolYear NVARCHAR(10) NOT NULL,
    Capacity INT NOT NULL DEFAULT 40 CHECK (Capacity > 0),
	Status NVARCHAR(20) NOT NULL DEFAULT 'Active' 
);