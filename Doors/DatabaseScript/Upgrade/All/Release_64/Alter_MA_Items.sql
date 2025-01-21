IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsLNominale')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsLNominale] [float] NULL CONSTRAINT DF_MA_Items_DoorsLNominale_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsLNominale] = 0 WHERE [dbo].[MA_Items].[DoorsLNominale] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsHNominale')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsHNominale] [float] NULL CONSTRAINT DF_MA_Items_DoorsHNominale_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsHNominale] = 0 WHERE [dbo].[MA_Items].[DoorsHNominale] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsPNominale')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsPNominale] [float] NULL CONSTRAINT DF_MA_Items_DoorsPNominale_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsPNominale] = 0 WHERE [dbo].[MA_Items].[DoorsPNominale] IS NULL
GO


