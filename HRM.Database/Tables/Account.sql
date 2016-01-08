CREATE TABLE [dbo].[Account]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [EmployeeName] VARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Department] INT NULL, 
    [DOB] DATE NULL, 
    [JobType] VARCHAR(50) NULL, 
    [Designation] VARCHAR(50) NULL, 
    [DateOf_Join] DATETIME NULL, 
    [Address] NVARCHAR(50) NULL, 
    [Street] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(50) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone_no] INT NULL, 
    [Photo] VARCHAR(50) NULL, 
    [password] NVARCHAR(50) NULL
)
