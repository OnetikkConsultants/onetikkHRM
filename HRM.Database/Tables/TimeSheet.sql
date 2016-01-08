CREATE TABLE [dbo].[TimeSheet]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [ProfileId] NVARCHAR(50) NULL, 
    [Date] DATETIME NULL, 
    [CheckingTime] TIME NULL, 
    [CheckOutTime] TIME NULL, 
    [LunchBreak] TIME NULL, 
    [TotlaHours] TIME NULL, 
    [TargetHours] TIME NULL, 
    [RemainingHours] TIME NULL, 
    [IPAddress] NVARCHAR(MAX) NULL
)
