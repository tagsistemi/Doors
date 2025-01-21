IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_PolIntela' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Quantita')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_PolIntela]
	ADD [Quantita] [float] NULL CONSTRAINT DF_TAG_DOORS_PolIntela_Quantita_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_PolIntela] SET [dbo].[TAG_DOORS_PolIntela].[Quantita] = 0 WHERE [dbo].[TAG_DOORS_PolIntela].[Quantita] IS NULL
GO


