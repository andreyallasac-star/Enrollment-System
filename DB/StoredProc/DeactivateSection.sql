CREATE PROCEDURE DeactivateSection
    @SectionCode NVARCHAR(50)
AS
BEGIN
    UPDATE Sections 
    SET Status = 'Inactive' 
    WHERE SectionCode = @SectionCode;
END
GO