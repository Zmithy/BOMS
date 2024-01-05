CREATE PROCEDURE [dbo].[spBook_Upsert]
	@BookId int output,
	@Title varchar(50),
	@Price smallmoney,
	@Discount int,
	@ISBN varchar(50),
	@Notes varchar(100)
	
AS
begin
	if exists(select 1 FROM Book where ISBN = @ISBN)
	begin
		update Book set
		Title = @Title,
		Price = @Price,
		Discount = @Discount,
		Notes = convert(varchar,Notes) +  convert(varchar,@Notes)
		where ISBN = @ISBN;
		select @BookId = Id from Book 
	end
	else
		begin
			insert into Book (Title, Price, Discount, Notes, ISBN)
			values (@Title, @Price, @Discount, @Notes, @ISBN);
			select @BookId = SCOPE_IDENTITY();
		end
	
end

