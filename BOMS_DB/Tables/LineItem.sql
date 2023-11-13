CREATE TABLE [dbo].[LineItem]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Book_Id] INT NOT NULL FOREIGN KEY (Book_Id) REFERENCES [dbo].[Book](Id),
	[Order_Id] INT NOT NULL Foreign KEY (Order_Id) REFERENCES [dbo].[Orders](Order_Id)
)
