CREATE PROCEDURE [dbo].[spLineItems_Delete]
	@Order_Id int,
	@Book_Id int
AS
BEGIN
	DELETE FROM LineItem
	WHERE Order_Id = @Order_Id AND Book_Id = @Book_Id
END