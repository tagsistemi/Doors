IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_ConfigurazioniVar' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Bom')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_ConfigurazioniVar]
	ADD [Bom] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniVar_Bom_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_ConfigurazioniVar] SET [dbo].[TAG_DOORS_ConfigurazioniVar].[Bom] = '' WHERE [dbo].[TAG_DOORS_ConfigurazioniVar].[Bom] IS NULL
GO


