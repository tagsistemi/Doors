IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'LIntBattuta')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [LIntBattuta] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_LIntBattuta_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[LIntBattuta] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[LIntBattuta] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'HIntBattuta')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [HIntBattuta] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_HIntBattuta_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[HIntBattuta] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[HIntBattuta] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'AriaH')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [AriaH] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_AriaH_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[AriaH] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[AriaH] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'AriaL')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [AriaL] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_AriaL_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[AriaL] = 0 WHERE [dbo].[TAG_DOORS_Configurazioni].[AriaL] IS NULL
GO


