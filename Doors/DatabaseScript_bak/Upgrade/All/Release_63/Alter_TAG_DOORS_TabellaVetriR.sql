IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_TabellaVetriR' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Tipologia')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_TabellaVetriR]
	ADD [Tipologia] [int] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetriR_Tipologia_00 DEFAULT (1511522304)
END
GO


UPDATE [dbo].[TAG_DOORS_TabellaVetriR] SET [dbo].[TAG_DOORS_TabellaVetriR].[Tipologia] = 1511522304 WHERE [dbo].[TAG_DOORS_TabellaVetriR].[Tipologia] IS NULL
GO


