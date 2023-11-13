CREATE PROCEDURE [dbo].[spCustomer_Get]
	@Email varchar(50)
AS
BEGIN
	SELECT *
	FROM [Customer]
	WHERE Email = @Email;
END

