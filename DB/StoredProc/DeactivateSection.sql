CREATE PROCEDURE DeactivateSection
    @SectionCode NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Sections 
    SET Status = 'Inactive' 
    WHERE SectionCode = @SectionCode;
END
GO