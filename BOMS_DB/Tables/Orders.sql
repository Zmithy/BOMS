CREATE TABLE [dbo].[Orders]
(
	[Order_Id] INT NOT NULL PRIMARY KEY Identity, 
    [Outstanding] BIT NOT NULL, 
    [Customer_Id] INT NULL, 
    CONSTRAINT [Customer_Id] FOREIGN KEY (Customer_Id) REFERENCES [dbo].[Customer](Id)
)

