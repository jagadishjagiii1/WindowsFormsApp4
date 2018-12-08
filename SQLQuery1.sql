CREATE TABLE [dbo].[regtable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NULL, 
    [section] NVARCHAR(50) NULL, 
    [branch] NVARCHAR(50) NULL, 
    [dob] DATE NULL, 
    [image] IMAGE NULL
)
