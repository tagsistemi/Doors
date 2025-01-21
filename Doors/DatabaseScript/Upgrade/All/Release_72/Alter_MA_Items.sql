IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsCoeffL')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsCoeffL] [float] NULL CONSTRAINT DF_MA_Items_DoorsCoeffL_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsCoeffL] = 0 WHERE [dbo].[MA_Items].[DoorsCoeffL] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsCoeffH')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsCoeffH] [float] NULL CONSTRAINT DF_MA_Items_DoorsCoeffH_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsCoeffH] = 0 WHERE [dbo].[MA_Items].[DoorsCoeffH] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsCoeffP')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsCoeffP] [float] NULL CONSTRAINT DF_MA_Items_DoorsCoeffP_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsCoeffP] = 0 WHERE [dbo].[MA_Items].[DoorsCoeffP] IS NULL
GO


