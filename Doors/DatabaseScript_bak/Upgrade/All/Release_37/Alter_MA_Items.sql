IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsTipoTelaio')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsTipoTelaio] [varchar] (8) NULL CONSTRAINT DF_MA_Items_DoorsTipoTelaio_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsTipoTelaio] = '' WHERE [dbo].[MA_Items].[DoorsTipoTelaio] IS NULL
GO


