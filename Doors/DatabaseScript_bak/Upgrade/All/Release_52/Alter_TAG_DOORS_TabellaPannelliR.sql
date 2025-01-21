IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_TabellaPannelliR' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'BattutaComponente')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_TabellaPannelliR]
	ADD [BattutaComponente] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_BattutaComponente_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_TabellaPannelliR] SET [dbo].[TAG_DOORS_TabellaPannelliR].[BattutaComponente] = '' WHERE [dbo].[TAG_DOORS_TabellaPannelliR].[BattutaComponente] IS NULL
GO


