CREATE PROCEDURE [dbo].[spLineItems_GetTotal]
	@Order_Id int
AS
BEGIN
	SELECT SUM(Book.Price) FROM dbo.LineItem inner join Book on LineItem.Book_Id = Book.Id
	where Order_Id = @Order_Id
END