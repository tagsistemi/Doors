IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'RootItem')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [RootItem] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_RootItem_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[RootItem] = '' WHERE [dbo].[TAG_DOORS_Configurazioni].[RootItem] IS NULL
GO


