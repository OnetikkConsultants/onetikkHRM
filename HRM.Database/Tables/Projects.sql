CREATE TABLE [dbo].[Projects]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [ClientId] INT NULL, 
    [ClientName] NVARCHAR(50) NULL, 
    [StartDate] DATE NULL, 
    [ExpectedEndDate] DATE NULL, 
    [ActualEndDate] DATE NULL, 
    [ProjectTypeId] NVARCHAR(50) NULL, 
    [Technology] VARCHAR(50) NULL, 
    [DomainId] VARCHAR(50) NULL, 
    [status] INT NULL, 
    [LastModifiedDate] DATE NULL, 
    [LastModifiedBy] NVARCHAR(50) NULL
)
