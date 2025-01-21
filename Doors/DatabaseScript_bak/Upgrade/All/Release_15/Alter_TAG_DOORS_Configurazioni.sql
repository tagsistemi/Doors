IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'VarianteRoot')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [VarianteRoot] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_VarianteRoot_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[VarianteRoot] = '' WHERE [dbo].[TAG_DOORS_Configurazioni].[VarianteRoot] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'VarianteStandard')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [VarianteStandard] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_VarianteStandard_00 DEFAULT ('0')
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[VarianteStandard] = '0' WHERE [dbo].[TAG_DOORS_Configurazioni].[VarianteStandard] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Configurazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DescRootVar')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Configurazioni]
	ADD [DescRootVar] [varchar] (250) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_DescRootVar_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Configurazioni] SET [dbo].[TAG_DOORS_Configurazioni].[DescRootVar] = '' WHERE [dbo].[TAG_DOORS_Configurazioni].[DescRootVar] IS NULL
GO


