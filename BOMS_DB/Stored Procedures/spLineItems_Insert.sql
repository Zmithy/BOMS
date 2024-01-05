CREATE PROCEDURE [dbo].[spLineItems_Insert]
	@Order_Id int,
	@Book_Id int
AS
BEGIN
	INSERT INTO LineItem(Order_Id, Book_Id)
	VALUES (@Order_Id, @Book_Id)
END