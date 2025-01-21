IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAriaL')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsAriaL] [float] NULL CONSTRAINT DF_MA_Items_DoorsAriaL_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsAriaL] = 0 WHERE [dbo].[MA_Items].[DoorsAriaL] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAriaH')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsAriaH] [float] NULL CONSTRAINT DF_MA_Items_DoorsAriaH_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsAriaH] = 0 WHERE [dbo].[MA_Items].[DoorsAriaH] IS NULL
GO


