IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'CatMercPorte')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [CatMercPorte] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercPorte_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[CatMercPorte] = '' WHERE [dbo].[TAG_DOORS_Params].[CatMercPorte] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'CatMercTelai')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [CatMercTelai] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercTelai_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[CatMercTelai] = '' WHERE [dbo].[TAG_DOORS_Params].[CatMercTelai] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'CatMercImbotti')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [CatMercImbotti] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercImbotti_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[CatMercImbotti] = '' WHERE [dbo].[TAG_DOORS_Params].[CatMercImbotti] IS NULL
GO


