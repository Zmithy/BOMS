CREATE PROCEDURE [dbo].[spOrder_Delete]
	@Order_Id int
	
AS
BEGIN
	DELETE FROM LineItem
	WHERE Order_Id = @Order_Id

	DELETE FROM Orders
	WHERE Id = @Order_Id
END