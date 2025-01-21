IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Maggiorazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Sconto1')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Maggiorazioni]
	ADD [Sconto1] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Sconto1_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Maggiorazioni] SET [dbo].[TAG_DOORS_Maggiorazioni].[Sconto1] = 0 WHERE [dbo].[TAG_DOORS_Maggiorazioni].[Sconto1] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Maggiorazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Sconto2')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Maggiorazioni]
	ADD [Sconto2] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Sconto2_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Maggiorazioni] SET [dbo].[TAG_DOORS_Maggiorazioni].[Sconto2] = 0 WHERE [dbo].[TAG_DOORS_Maggiorazioni].[Sconto2] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Maggiorazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Sconto3')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Maggiorazioni]
	ADD [Sconto3] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Sconto3_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Maggiorazioni] SET [dbo].[TAG_DOORS_Maggiorazioni].[Sconto3] = 0 WHERE [dbo].[TAG_DOORS_Maggiorazioni].[Sconto3] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Maggiorazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Provvigione')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Maggiorazioni]
	ADD [Provvigione] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Provvigione_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Maggiorazioni] SET [dbo].[TAG_DOORS_Maggiorazioni].[Provvigione] = 0 WHERE [dbo].[TAG_DOORS_Maggiorazioni].[Provvigione] IS NULL
GO


