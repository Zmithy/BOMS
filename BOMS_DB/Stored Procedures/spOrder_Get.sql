CREATE PROCEDURE [dbo].[spOrder_Get]
	@Order_Id varchar(50)
AS
BEGIN
	SELECT *
	FROM [Orders]
	WHERE Order_Id = @Order_Id;
END
