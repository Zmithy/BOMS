CREATE PROCEDURE [dbo].[spLineItems_Get]
	@Order_Id varchar(50)
AS
BEGIN
	SELECT Book_Id
	FROM [LineItem]
	WHERE Order_Id = @Order_Id;
END