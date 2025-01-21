IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsLarghezza')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsLarghezza] [float] NULL CONSTRAINT DF_MA_Items_DoorsLarghezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsLarghezza] = 0 WHERE [dbo].[MA_Items].[DoorsLarghezza] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAltezza')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsAltezza] [float] NULL CONSTRAINT DF_MA_Items_DoorsAltezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsAltezza] = 0 WHERE [dbo].[MA_Items].[DoorsAltezza] IS NULL
GO


