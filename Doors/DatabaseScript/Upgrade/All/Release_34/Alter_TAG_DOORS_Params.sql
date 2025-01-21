IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'CatMercTelaiLav')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [CatMercTelaiLav] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercTelaiLav_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[CatMercTelaiLav] = '' WHERE [dbo].[TAG_DOORS_Params].[CatMercTelaiLav] IS NULL
GO


