CREATE TABLE Students (
    StudentId NVARCHAR(20) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50) NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NULL,
    StudentType NVARCHAR(20) NULL,
    
    HouseNo NVARCHAR(50) NULL,
    Barangay NVARCHAR(100) NULL,
    Municipality NVARCHAR(100) NULL,
    Province NVARCHAR(100) NULL,
    PostalCode NVARCHAR(20) NULL,

    GuardianFirstName NVARCHAR(50) NULL,
    GuardianMiddleName NVARCHAR(50) NULL,
    GuardianLastName NVARCHAR(50) NULL,
    GuardianContact NVARCHAR(20) NULL,
    GuardianRelationship NVARCHAR(50) NULL,
    GuardianGender NVARCHAR(10) NULL,
    GuardianHouseNo NVARCHAR(50) NULL,
    GuardianBarangay NVARCHAR(100) NULL,
    GuardianMunicipality NVARCHAR(100) NULL,
    GuardianProvince NVARCHAR(100) NULL,
    GuardianPostalCode NVARCHAR(20) NULL,
    
    Status NVARCHAR(20) NOT NULL DEFAULT 'Inactive'
);