IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'HVetro')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [HVetro] [float] NULL CONSTRAINT DF_MA_Items_HVetro_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[HVetro] = 0 WHERE [dbo].[MA_Items].[HVetro] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'LVetro')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [LVetro] [float] NULL CONSTRAINT DF_MA_Items_LVetro_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[LVetro] = 0 WHERE [dbo].[MA_Items].[LVetro] IS NULL
GO


