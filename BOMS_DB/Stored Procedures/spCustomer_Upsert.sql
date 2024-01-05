CREATE PROCEDURE [dbo].[spCustomer_Upsert]
	@CustomerId int output,
	@Name nvarchar(50),
	@Email nvarchar(50),
	@Phone nvarchar(50),
	@City nvarchar(50),
	@Region nvarchar(50),
	@PostalCode nvarchar(50)
AS
begin
	if exists (select 1 from Customer where Email = @Email)
		begin
			update Customer set 
				Name = @Name,
				Phone = @Phone,
				City = @City,
				Region = @Region,
				PostalCode = @PostalCode
			where Email = @Email;
			select @CustomerId = Id from Customer where Email = @Email;
		end
	else
		begin
			insert into Customer (Name, Email, Phone, City, Region, PostalCode)
			values (@Name, @Email, @Phone, @City, @Region, @PostalCode);
			select @CustomerId = SCOPE_IDENTITY();
		end

end

