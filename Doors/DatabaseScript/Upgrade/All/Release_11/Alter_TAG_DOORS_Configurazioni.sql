IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Larghezza')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [Larghezza] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_Larghezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[Larghezza] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[Larghezza] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Altezza')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [Altezza] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_Altezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[Altezza] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[Altezza] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'SpessoreMuro')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [SpessoreMuro] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_SpessoreMuro_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[SpessoreMuro] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[SpessoreMuro] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'SpessoreTelaio')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [SpessoreTelaio] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_SpessoreTelaio_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[SpessoreTelaio] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[SpessoreTelaio] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'NoteConfText')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [NoteConfText] [text] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_NoteConfText_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[NoteConfText] = '' WHERE [dbo].[TAG_DOORS_Configurazioni].[NoteConfText] IS NULL
GO


