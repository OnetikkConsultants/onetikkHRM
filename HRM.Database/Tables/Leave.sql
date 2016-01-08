CREATE TABLE [dbo].[Leave]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [EmployeeId] NVARCHAR(50) NULL, 
    [TotalLeaves] FLOAT NULL, 
    [LeaveTaken] FLOAT NULL, 
    [LeaveRemianing] FLOAT NULL, 
    [LeaveId] INT NULL, 
    [LeaveType] INT NULL, 
    [LeaveReason] NVARCHAR(50) NULL, 
    [LeaveStatus] INT NULL
)
