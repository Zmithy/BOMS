CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Name] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Region] NVARCHAR(50) NULL, 
    [PostalCode] NVARCHAR(50) NULL
)
