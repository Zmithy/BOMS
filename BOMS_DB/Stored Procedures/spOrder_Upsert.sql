CREATE PROCEDURE [dbo].[spOrder_Upsert]
	@Order_Id int output,
	@Outstanding bit,
	@Customer_Id int

AS

BEGIN
	if  exists(select 1 FROM Orders where Order_Id = @Order_Id) 
		BEGIN
			update Orders set
			Customer_Id = @Customer_Id,
			Outstanding = @Outstanding
			where Order_Id = @Order_Id;
			select @Order_Id = Order_Id from Orders


		END
	else
		BEGIN
			insert into Orders(Outstanding, Customer_Id)
			values(@Outstanding, @Customer_Id);
			select @Order_Id = SCOPE_IDENTITY();
		END
		
END
