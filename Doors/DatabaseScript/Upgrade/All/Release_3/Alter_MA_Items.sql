IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsApertura')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsApertura] [varchar] (12) NULL CONSTRAINT DF_MA_Items_DoorsApertura_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsApertura] = '' WHERE [dbo].[MA_Items].[DoorsApertura] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsNote')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsNote] [varchar] (50) NULL CONSTRAINT DF_MA_Items_DoorsNote_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsNote] = '' WHERE [dbo].[MA_Items].[DoorsNote] IS NULL
GO


