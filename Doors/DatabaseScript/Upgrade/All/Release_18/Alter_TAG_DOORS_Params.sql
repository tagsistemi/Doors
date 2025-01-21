IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'CatMercAccessori')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [CatMercAccessori] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercAccessori_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[CatMercAccessori] = '' WHERE [dbo].[TAG_DOORS_Params].[CatMercAccessori] IS NULL
GO


