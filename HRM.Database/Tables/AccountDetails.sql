CREATE TABLE [dbo].[AccountDetails]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [EmployeeId ] NVARCHAR(50) NULL, 
    [NWDays ] INT NULL, 
    [NLeaves ] INT NULL, 
    [WeekHRS ] FLOAT NULL, 
    [TWHRS ] FLOAT NULL, 
    [CSalary ] NVARCHAR(50) NULL, 
    [THSalary ] NVARCHAR(50) NULL
)
