IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsFinitura')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsFinitura] [varchar] (8) NULL CONSTRAINT DF_MA_Items_DoorsFinitura_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsFinitura] = '' WHERE [dbo].[MA_Items].[DoorsFinitura] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsBattuta')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsBattuta] [varchar] (8) NULL CONSTRAINT DF_MA_Items_DoorsBattuta_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsBattuta] = '' WHERE [dbo].[MA_Items].[DoorsBattuta] IS NULL
GO


