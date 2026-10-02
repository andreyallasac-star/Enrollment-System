CREATE PROCEDURE UpdateSection
    @SectionCode NVARCHAR(50),
    @GradeLevel NVARCHAR(50),
    @Capacity INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Sections 
    SET GradeLevel = @GradeLevel, 
        Capacity = @Capacity 
    WHERE SectionCode = @SectionCode;
END
GO