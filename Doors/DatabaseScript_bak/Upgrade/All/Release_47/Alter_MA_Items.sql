IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSpProfIntTelaio')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsSpProfIntTelaio] [float] NULL CONSTRAINT DF_MA_Items_DoorsSpProfIntTelaio_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsSpProfIntTelaio] = 0 WHERE [dbo].[MA_Items].[DoorsSpProfIntTelaio] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSpProfEstTelaio')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsSpProfEstTelaio] [float] NULL CONSTRAINT DF_MA_Items_DoorsSpProfEstTelaio_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsSpProfEstTelaio] = 0 WHERE [dbo].[MA_Items].[DoorsSpProfEstTelaio] IS NULL
GO


