CREATE TABLE [dbo].[TaskAssignment]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [TaskId] NVARCHAR(50) NULL, 
    [AssignmentToEmpId] NVARCHAR(50) NULL, 
    [AssignmentByEmpId] NVARCHAR(50) NULL, 
    [AssignedDate] DATETIME NULL, 
    [EstimatedHours] INT NULL, 
    [ActualHours] INT NULL, 
    [Status] INT NULL, 
    [LastModifiedBy] NVARCHAR(50) NULL, 
    [LastModifiedDate] DATETIME NULL
)
