CREATE TABLE [dbo].[Book]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Title] NVARCHAR(50) NULL, 
    [Price] SMALLMONEY NOT NULL, 
    [Discount] INT NULL, 
    [ISBN] NVARCHAR(50) NOT NULL, 
    [Notes] TEXT NULL, 
    
)
